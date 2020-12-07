using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    class FileOperation
    {
    public static PointPairList Data_ReadFile(string filename, double dt = 0.002)
        {
            var res = new PointPairList();
            if (File.Exists(filename))
            {
                var i = 0;
                using (var reader = new BinaryReader(File.Open(filename, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        res.Add(dt * i++, reader.ReadSingle());
                    }
                }
            }
            return res;
        }
    }
}
