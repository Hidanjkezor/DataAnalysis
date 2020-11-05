using System;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    static class Plotter
    {
        private static readonly ColorSymbolRotator Rotator = new ColorSymbolRotator();
        private static readonly Random Rnd = new Random();
        private static readonly MersenneTwister MyRnd = new MersenneTwister();

        public static void Draw(ZedGraphControl control, PointPairList ppl, string name = "Кривая")
        {
            control.GraphPane.AddCurve(name, ppl, Rotator.NextColor, SymbolType.None);
            control.RestoreScale(control.GraphPane);
            control.Invalidate();
        }

        public static void Clear(ZedGraphControl control)
        {
            control.GraphPane.CurveList.Clear();
            control.RestoreScale(control.GraphPane);
            control.Invalidate();
        }

        public static void Merge(ZedGraphControl control)
        {
            var ppl = new PointPairList();
            foreach (var curve in control.GraphPane.CurveList)
            {
                for (var i = 0; i < curve.Points.Count; i++)
                {
                    ppl.Add(curve.Points[i]);
                }
            }
            ppl.Sort();

            for (var i = 1; i < ppl.Count; i++)
            {
                if (ppl[i].X != ppl[i - 1].X) continue;

                ppl[i - 1].Y += ppl[i].Y;
                ppl.RemoveAt(i--);
            }

            control.GraphPane.CurveList.Clear();
            control.GraphPane.AddCurve("Merged", ppl, Rotator.NextColor, SymbolType.None);

            control.RestoreScale(control.GraphPane);
            control.Invalidate();
        }

        public static PointPairList GetLinear(double c, double d, double from, double dt, int N)
        {
            var list = new PointPairList();

            for (var i = 0; i < N; i++)
            {
                var x = i * dt;
                list.Add(x, c * x + d);
            }

            return list;
        }

        public static PointPairList GetExp(double a, double b, double from, double dt, int N)
        {
            var list = new PointPairList();

            for (var i = 0; i < N; i++)
            {
                var x = i * dt;
                list.Add(x, b * Math.Exp(a * x));
            }

            return list;
        }

        public static PointPairList GetRandom(double s, double from, double dt, int N)
        {
            var list = new PointPairList();
            for (var i = 0; i < N; i++)
            {
                var x = i * dt;
                list.Add(x, Rnd.NextDouble() * (2 * s) - s);
            }

            return list;
        }

        public static PointPairList GetMyRandom(double s, double from, double dt, int N)
        {
            var list = new PointPairList();
            for (var i = 0; i < N; i++)
            {
                var x = i * dt;
                list.Add(x, MyRnd.genrand_real1() * (2 * s) - s);
            }

            return list;
        }

        public static PointPairList GetSin(double a, double f, double from, double dt, int N)
        {
            var list = new PointPairList();
            for (var i = 0; i < N; i++)
            {
                var x = i * dt;
                list.Add(x, a * Math.Sin(2 * Math.PI * f * i * dt));
            }
            return list;
        }
    }
}
