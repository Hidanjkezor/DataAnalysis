using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuLibrary.Misc;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
  public class ManipulateImages
    {
        public List<PointPairList> Data = new List<PointPairList>();
        public int ColorDepth = 8;
        public void LoadImage(string path)
        {
            Data.Clear();
            var curImage = Image.FromFile(path);
            var bmp = curImage as Bitmap;
            var dirBmp = new DirectBitmap(bmp.Width, bmp.Height);
            dirBmp.Bitmap.SetResolution(curImage.HorizontalResolution, curImage.VerticalResolution);

            using (var g = Graphics.FromImage(dirBmp.Bitmap))   // picture drawing
            {
                g.DrawImage(bmp, new Point(0,0));
            }

            for (var i = 0; i < dirBmp.Height; i++)
            {
                var ppl = new PointPairList(); // line of pixels
                for (var j = 0; j < dirBmp.Width; j++)
                {
                    var clr = dirBmp.GetPixel(j, i);
                    ppl.Add(j, (clr.R + clr.G + clr.B)/3);
                }
                Data.Add(ppl);
            }
        }

        public void LoadXcr(string path)
        {
            Data.Clear();
            if (!File.Exists(path)) return;

            using (var reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                reader.BaseStream.Position += 608;

                //Reading horizontal size
                var hSize = 0;
                for (var i = 0; i < 16; i++)
                {
                    var b = reader.ReadByte();
                    if (b != 0x00)
                        hSize = hSize * 10 + b - 0x30;
                }

                //Reading vertical size
                var vSize = 0;
                for (var i = 0; i < 16; i++)
                {
                    var b = reader.ReadByte();
                    if (b != 0x00)
                        vSize = vSize * 10 + b - 0x30;
                }

                reader.BaseStream.Position += 1408;

                for (var i = 0; i < hSize; i++)
                {
                    var ppl = new PointPairList();
                    for (var j = 0; j < vSize; j++)
                    {
                        var b = reader.ReadByte();
                        byte[] bytes = { reader.ReadByte(), b, 0, 0 };
                        var data = BitConverter.ToInt32(bytes, 0);
                        ppl.Add(j, data);
                    }
                    Data.Add(ppl);
                }
            }
        }

        public Bitmap GetBitmap(bool forceColorChange = false)
        {
            if (Data.Count == 0 || Data[0].Count == 0)
                return new Bitmap(1, 1);

            var colors = (int)Math.Pow(2, ColorDepth) - 1;
            if (colors > 255)
                colors = 255;

            //var divisor = 256 / (colors + 1);

            var dirBmp = new DirectBitmap(Data[0].Count, Data.Count);
            //dirBmp.Bitmap.SetResolution(CurImage.HorizontalResolution, CurImage.VerticalResolution);

            double xMin = double.MaxValue, xMax = double.MinValue;

            for (var i = 0; i < dirBmp.Height; i++)
            {
                for (var j = 0; j < dirBmp.Width; j++)
                {
                    var value = Data[i][j].Y;
                    if (xMin > value)
                        xMin = value;

                    if (xMax < value)
                        xMax = value;
                }
            }

            if (forceColorChange || xMin < 0 || xMax > colors)
            {
                for (var i = 0; i < dirBmp.Height; i++)
                {
                    for (var j = 0; j < dirBmp.Width; j++)
                    {
                        var value = (int)(255 * (Data[i][j].Y - xMin) / (xMax - xMin)); //0..255
                        value = (int)Math.Round(colors * (double)value / 255); //0..3
                        value = (int)Math.Round(255 * (double)value / colors); //0..255
                        dirBmp.SetPixel(j, i, Color.FromArgb(value, value, value));
                    }
                }
            }
            else
            {
                for (var i = 0; i < dirBmp.Height; i++)
                {
                    for (var j = 0; j < dirBmp.Width; j++)
                    {
                        var value = (int)Data[i][j].Y;
                        dirBmp.SetPixel(j, i, Color.FromArgb(value, value, value));
                    }
                }
            }

            return dirBmp.Bitmap;
        }

        public void NearestNeighbour(double mulfactor)
        {
            var newHeight = (int)(Data.Count * mulfactor);
            var newWidth = (int)(Data[0].Count * mulfactor);

            if (newHeight == 0 || newWidth == 0)
                return;

            var newData = new List<PointPairList>(newHeight);

            for (var i = 0; i < newHeight; i++)
            {
                newData.Add(new PointPairList());

                var closestY = (int)(i / mulfactor);

                for (var j = 0; j < newWidth; j++)
                {
                    var closestX = (int)(j / mulfactor);
                    newData[i].Add(Data[closestY][closestX]);
                }
            }

            Data = newData;
        }
        public void Bilinear(double mulfactor)
        {
            var newHeight = (int)(Data.Count * mulfactor);
            var newWidth = (int)(Data[0].Count * mulfactor);

            if (newHeight == 0 || newWidth == 0)
                return;

            var newData = new List<PointPairList>(newHeight);

            //Extrapolation
            foreach (var ppl in Data)
                ppl.Add(ppl[ppl.Count - 1]);
            Data.Add(Data[Data.Count - 1]);

            for (var i = 0; i < newHeight; i++)
            {
                newData.Add(new PointPairList());

                var newY = i / mulfactor;
                var lowClosestY = (int)Math.Floor(newY);
                var highClosestY = lowClosestY + 1;

                for (var j = 0; j < newWidth; j++)
                {
                    var newX = j / mulfactor;
                    var lowClosestX = (int)Math.Floor(newX);
                    var highClosestX = lowClosestX + 1;

                    var x1_y = (highClosestX - newX) * Data[lowClosestY][lowClosestX].Y
                               + (newX - lowClosestX) * Data[lowClosestY][highClosestX].Y;

                    var x2_y = (highClosestX - newX) * Data[highClosestY][lowClosestX].Y
                               + (newX - lowClosestX) * Data[highClosestY][highClosestX].Y;

                    var pp = new PointPair(j, (highClosestY - newY) * x1_y + (newY - lowClosestY) * x2_y);

                    newData[i].Add(pp);
                }
            }

            Data = newData;
        }

        public void RotateImage()
        {
            var maxHeigh = Data[0].Count;
            var newData = new List<PointPairList>(maxHeigh);
            for (var i = 0; i < maxHeigh; i++)
            {
                var newColumn = new PointPairList();
                for (var j = Data.Count-1; j >= 0; j--)
                {
                    newColumn.Add(Data.Count-j-1, Data[j][i].Y);
                }
                newData.Add(newColumn);
            }

            Data = newData;
        }

        public double GetMin()
        {
            return Data.Min(row => row.Min(v => v.Y));
        }

        public double GetMax()
        {
            return Data.Max(row => row.Max(v => v.Y));
        }
        public void ApplyNegative()
        {
            var min = GetMin();
            var max = GetMax() - min;

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = max - (Data[i][j].Y - min) + min;
                }
            }
        }
        public void ApplyLogarithm()
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Log(tmpMax + 1);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = c * Math.Log(Data[i][j].Y + 1 - min) + min;
                }
            }
        }
        public void ApplyInverseLogarithm()
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Log(tmpMax + 1);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = Math.Exp((Data[i][j].Y - min) / c) - 1 + min;
                }
            }
        }
        public void ApplyPower(double power)
        {
            var min = GetMin();
            var max = GetMax();
            var tmpMax = max - min;

            var c = tmpMax / Math.Pow(tmpMax, power);

            var height = Data.Count;
            var width = Data[0].Count;

            for (var i = 0; i < height; i++)
            {
                for (var j = 0; j < width; j++)
                {
                    Data[i][j].Y = c * Math.Pow(Data[i][j].Y - min, power) + min;
                }
            }
        }
    }
}
