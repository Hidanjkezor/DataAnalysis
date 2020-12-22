using System;
using System.Linq;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    public static class GraphEditor
    {
        private static readonly Random Rnd = new Random();

        public static void AntiTrend(CurveItem ci, int SizeWindow)
        {
            PointPairList input_dots = GraphConverter.GetPointPairListFromCurve(ci);
            for (var i = 1; i< SizeWindow; i+=2)
            {
                var average = Analyser.GetAverageOnRange(input_dots, 0, i);
                ci.Points[i / 2].Y = average;
            }
            for (var i = 0;i < ci.Points.Count - SizeWindow; i++)
            {
                var average = Analyser.GetAverageOnRange(input_dots, i, i + SizeWindow);
                ci.Points[i + SizeWindow / 2].Y = average;
            }
            for (var i = SizeWindow; i >= 1 ;i-=2)
            {
                var average = Analyser.GetAverageOnRange(input_dots, input_dots.Count - i - 1, input_dots.Count - 1);
                ci.Points[ci.Points.Count - 1 - i / 2].Y = average;
            }
            for(var i = 0; i < ci.Points.Count; i++)
            {
                ci.Points[i].Y = input_dots[i].Y - ci.Points[i].Y;
            }
        }
        public static void Trend(CurveItem ci, int SizeWindow)
        {
            PointPairList input_dots = GraphConverter.GetPointPairListFromCurve(ci);
            for (var i = 1; i < SizeWindow; i += 2)
            {
                var average = Analyser.GetAverageOnRange(input_dots, 0, i);
                ci.Points[i / 2].Y = average;
            }
            for (var i = 0; i < ci.Points.Count - SizeWindow; i++)
            {
                var average = Analyser.GetAverageOnRange(input_dots, i, i + SizeWindow);
                ci.Points[i + SizeWindow / 2].Y = average;
            }
            for (var i = SizeWindow; i >= 1; i -= 2)
            {
                var average = Analyser.GetAverageOnRange(input_dots, input_dots.Count - i - 1, input_dots.Count - 1);
                ci.Points[ci.Points.Count - 1 - i / 2].Y = average;
            }
        }
        public static void Shift(CurveItem ci, double c)
        {
            for (var i = 0; i < ci.Points.Count; i++)
            {
                ci.Points[i].Y += c;
            }
        }

        public static void AntiShift(CurveItem ci)
        {
            var list = GraphConverter.GetPointPairListFromCurve(ci);
            var average = Analyser.GetAverageOnRange(list);
            Shift(ci, -average);
        }

        public static void AddRandomSpikes(CurveItem ci, double size, int count)
        {
            if (ci.Points.Count / 100 < count)
                count = ci.Points.Count / 100;

            var nums = Enumerable.Range(0, ci.Points.Count).ToList();
            while (count-- > 0)
            {
                var tmp = Rnd.Next(0, nums.Count);
                var i = nums[tmp];
                nums.RemoveAt(tmp);

                var sign = Rnd.Next(0, 2);
                ci.Points[i].Y += sign > 0 ? size : -size;
            }
        }

        public static void RemoveSpikes(CurveItem ci, double s)
        {
            for (var i = 0; i < ci.Points.Count; i++)
            {
                if (!(Math.Abs(ci.Points[i].Y) > 2 * s)) continue;

                var max = i;
                for (var j = i + 1; j < ci.Points.Count; j++)
                {
                    if (Math.Abs(ci.Points[j].Y) < 2 * s) break;

                    max = j;
                }

                if (i == 0 || max == ci.Points.Count - 1)
                {
                    for (var j = i; j <= max; j++)
                    {
                        ci.RemovePoint(j);
                        j--;
                        max--;
                    }
                }
                else
                {
                    var average = (ci.Points[i - 1].Y + ci.Points[max + 1].Y) / 2;
                    for (var j = i; j <= max; j++)
                    {
                        ci.Points[j].Y = average;
                    }

                    i += max - i;
                }
            }
        }
    }
}
