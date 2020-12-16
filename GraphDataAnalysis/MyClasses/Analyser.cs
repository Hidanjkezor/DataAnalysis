using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    class Analyser
    {
        private static readonly Random Rnd = new Random();
        public static double GetMaxOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var max = double.MinValue;
            for (var i = minI; i <= maxI; i++)
            {
                var dot = ppl[i];
                if (max < dot.Y)
                {
                    max = dot.Y;
                }
            }

            return max;
        }

        public static double GetMinOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var min = double.MaxValue;
            for (var i = minI; i <= maxI; i++)
            {
                var dot = ppl[i];
                if (min > dot.Y)
                {
                    min = dot.Y;
                }
            }

            return min;
        }

        public static double GetAverageOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += ppl[i].Y;
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetDispersionOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);
            return GetDispersionOnRange(ppl, average, minI, maxI);
        }

        public static double GetDispersionOnRange(PointPairList ppl, double average, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 2);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetSigmaOnRange(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);
            return Math.Sqrt(GetDispersionOnRange(ppl, average, minI, maxI));
        }

        public static double GetSigmaByDispersion(double dispersion)
        {
            return Math.Sqrt(dispersion);
        }

        public static double GetMeanSquare(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            double sum = 0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y, 2);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetRootMeanSquare(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            return Math.Sqrt(GetMeanSquare(ppl, minI, maxI));
        }

        public static double GetRootMeanSquare(double meanSquare)
        {
            return Math.Sqrt(meanSquare);
        }

        public static double GetAsymmetryMoment(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);

            var sum = 0.0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 3);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetAsymmetryCoefficient(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            return GetAsymmetryMoment(ppl, minI, maxI) / Math.Pow(GetSigmaOnRange(ppl, minI, maxI), 3);
        }

        public static double GetExcess(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var average = GetAverageOnRange(ppl, minI, maxI);

            var sum = 0.0;
            for (var i = minI; i <= maxI; i++)
            {
                sum += Math.Pow(ppl[i].Y - average, 4);
            }

            return sum / (maxI - minI + 1);
        }

        public static double GetKurtosis(PointPairList ppl, int minI = 0, int maxI = int.MaxValue)
        {
            if (maxI >= ppl.Count)
                maxI = ppl.Count - 1;

            var excess = GetExcess(ppl, minI, maxI);
            var sigma = GetSigmaOnRange(ppl, minI, maxI);

            return excess / Math.Pow(sigma, 4) - 3;
        }

        public static double GetPercentDiff(double a, double b, double min, double max)
        {
            if (b > a)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            return Math.Abs((a - b) / (max - min) * 100);
            //return Math.Abs((a - b) / ((a + b) / 2)) * 100;
        }

        public static bool CheckStationary(PointPairList list, double percent = 2.5, int n = 10)
        {
            var min = list.Min(x => x.Y);
            var max = list.Max(x => x.Y);
            var part = list.Count / n;

            var averages = new List<double>(n);
            var sigmas = new List<double>(n);
            var meanSquares = new List<double>(n);


            var ans = new StringBuilder();

            var isFirst = true;
            for (var i = 0; i < n; i++)
            {
                averages.Add(Analyser.GetAverageOnRange(list, i * part, Math.Min((i + 1) * part - 1, list.Count - 1))); ;
                sigmas.Add(Analyser.GetSigmaOnRange(list, i * part, Math.Min((i + 1) * part - 1, list.Count - 1)));
                meanSquares.Add(Analyser.GetMeanSquare(list, i * part, Math.Min((i + 1) * part - 1, list.Count - 1)));

                ans.Append($"Range [{i + 1}/{n}]\n");
                ans.Append($"Average: {averages[i] }\n");
                ans.Append($"Dispersion: {sigmas[i] }\n");
                ans.Append($"Mean Square: {meanSquares[i] }\n");

                if (!isFirst)
                {
                    ans.Append($"Average diff: {Analyser.GetPercentDiff(averages[i], averages[i - 1], min, max)}%\n");
                    ans.Append($"Dispersion diff: {Analyser.GetPercentDiff(sigmas[i], sigmas[i - 1], min, max)}%\n");
                    ans.Append($"Mean squares diff: {Analyser.GetPercentDiff(meanSquares[i], meanSquares[i - 1], min, max)}%\n");
                }

                isFirst = false;
            }

            var adiff = Analyser.GetPercentDiff(averages.Min(), averages.Max(), min, max);
            var ddiff = Analyser.GetPercentDiff(sigmas.Min(), sigmas.Max(), min, max);
            var meandiff = Analyser.GetPercentDiff(meanSquares.Min(), meanSquares.Max(), min, max);

            ans.Append($"Globally:\nMax average diff: {adiff}%\nMax dispersion diff: {ddiff}%\nMax mean square diff: {meandiff}%\n");

            return adiff < percent * 2 && ddiff < percent * 2;
        }

        public static PointPairList GetDistribution(PointPairList ppl, int partAmount = 100)
        {
            var res = new PointPairList();

            var fromY = ppl.Min(t => t.Y);
            var toY = ppl.Max(t => t.Y);

            var partSize = (toY - fromY) / partAmount;
            var parts = new List<int>(partAmount);
            parts.AddRange(Enumerable.Repeat(0, partAmount));

            foreach (var point in ppl)
            {
                parts[Math.Min((int)((point.Y - fromY) / partSize), parts.Count - 1)]++;
            }

            for (var i = 0; i < parts.Count; i++)
            {
                res.Add(fromY + partSize * i, parts[i]);
            }

            return res;
        }

        private static double GetRxxL(PointPairList ppl, int l)
        {
            var ans = 0.0;
            var upBorder = ppl.Count - l;
            for (var i = 0; i < upBorder; i++)
            {
                ans += ppl[i].Y * ppl[i + l].Y;
            }

            return ans / ppl.Count;
        }

        public static PointPairList GetRxx(PointPairList ppl)
        {
            var ans = new PointPairList();
            for (var i = 0; i < ppl.Count; i++)
            {
                ans.Add(i, GetRxxL(ppl, i));
            }
            return ans;
        }

        private static double GetRxyL(PointPairList ppl, PointPairList ppl2, int l)
        {
            var ans = 0.0;
            var upBorder = Math.Min(ppl.Count - l, ppl2.Count - l);
            for (var i = 0; i < upBorder; i++)
            {
                ans += ppl[i].Y * ppl2[i + l].Y;
            }

            return ans / ppl.Count;
        }

        public static PointPairList GetRxy(PointPairList ppl, PointPairList ppl2)
        {
            var ans = new PointPairList();
            for (var i = 0; i < ppl.Count; i++)
            {
                ans.Add(i, GetRxyL(ppl, ppl2, i));
            }
            return ans;
        }

        public static PointPairList GetRe(PointPairList ppl, bool normalization) // 
        {
            var res = new PointPairList();
            for (var n = 0; n < ppl.Count; n++)
            {
                var sum = ppl.Select((t, k) => t.Y * Math.Cos(2.0 * Math.PI * n * k / ppl.Count)).Sum();
                if( normalization)
                sum /= ppl.Count;

                res.Add(n, sum);
            }

            return res;
        }

        public static PointPairList GetIm(PointPairList ppl, bool normalization) // комплексное (мнимая часть)
        {
            var res = new PointPairList();
            for (var n = 0; n < ppl.Count; n++)
            {
                var sum = ppl.Select((t, k) => t.Y * Math.Sin(2.0 * Math.PI * n * k / ppl.Count)).Sum();
                if(normalization)
                sum /= ppl.Count;

                res.Add(n, sum);
            }

            return res;
        }

        public static double GetDf(PointPairList ppl)
        {
            var dt = ppl[1].X - ppl[0].X;
            return 1.0 / dt / ppl.Count;
        }

        public static PointPairList GetSpectre(PointPairList ppl, bool normalization)
        {
            var res = new PointPairList();
            var im = GetIm(ppl, normalization);
            var re = GetRe(ppl, normalization);
            var df = GetDf(ppl);

            for (var i = 0; i < im.Count; i++)
            {
                res.Add(i * df, Math.Sqrt(re[i].Y * re[i].Y + im[i].Y * im[i].Y));
            }

            return res;
        }
        public static PointPairList GetPeaks()
        {
            var res = new PointPairList();
            for(var i = 0; i < 1000; i++)
            {
                res.Add(i, 0);
            }
            for(var i = 100; i < 900; i += 200)
            {
                res[i].Y += Rnd.NextDouble() * 20+110; //130-110
            }
            return res;
        }
        public static PointPairList GetH()
        {
            var res = new PointPairList();
            var dlT = 0.005;
            var f = 4;
            var alph = 20;
            for(var i = 0; i< 200; i++)
            {
                var t = i * dlT;
                res.Add(t, Math.Sin(2 * Math.PI * f *t)*Math.Exp(t*-alph));
            }
            return res;
        }
        public static PointPairList Heart() // cardiogram
        {
            var x = GetPeaks();
            var h = GetH();
            return GetConvolution(x, h);
        }
        public static PointPairList GetBadHeart()
        {
            var res = new PointPairList();
            for (var i = 0; i < 1000; i++)
            {
                res.Add(i, 0);
            }
            for (var i = 100; i < 900; i += Rnd.Next(1,299))
            {
                res[i].Y += Rnd.NextDouble() * 20 + 110; //130-110
            }
            return res;

        }
        public static PointPairList BadHeart() // tachycardia
        {
            var x = GetBadHeart();
            var h = GetH();
            return GetConvolution(x, h);
        }

        public static PointPairList GetConvolution(PointPairList x, PointPairList h)
        {
            var dt = x[1].X - x[0].X;
            var N = x.Count;
            var M = h.Count;
            var res = new PointPairList();
            for (int k = 0; k < N + M; k++)
            {
                var sum = 0.0;
                for (var j = 0; j < M; j++)
                {
                    if (k - j < 0 || k - j > N - 1)
                        continue;
                    sum += h[j].Y * x[k - j].Y;
                }
                res.Add(dt* k, sum);
            }
            return res;
        }

        public static PointPairList Accum(int n, bool check_graph)
        {
            var res = Plotter.GetLinear(0,0,0,0.001,1000);
            for (var i = 0; i < n; i++)
            {
                var Rnd = Plotter.GetRandom(1,0, 0.001, 1000);
                for(var j = 0; j < Rnd.Count(); j++)
                {
                    res[j].Y += Rnd[j].Y;
                }
            }
            if (check_graph) { 
            for (var i = 0; i < n; i++)
            {
                var Rnd = Plotter.GetSin(1,5,0,0.001,1000);
                for (var j = 0; j < Rnd.Count(); j++)
                {
                    res[j].Y += Rnd[j].Y;
                }
            }
            }
            for (var j = 0; j < res.Count(); j++)   // Компенсируем рандомы
            {
                res[j].Y /= n;
            }
            return res;
        }
        
        public static PointPairList GetHarryPotter(double fc, int m, double dt) // fc - частота, m - длина фильтра
        {
            var w = new PointPairList();
            double fact = 2.0*fc*dt;
            w.Add(0, fact);
            fact *= Math.PI;
            for(var i = 1; i<=m; i++)
            {
                w.Add(i, Math.Sin(fact * i) / (Math.PI * i));
            }
            w[m].Y /= 2;

            var d = new[] { 0.35577019, 0.2436983, 0.07211497, 0.00630164 };
            var sumg = w[0].Y;
            for (var i = 1; i <= m; i++)
            {
                var sum = d[0];
                fact = Math.PI * i / m;
                for (int j = 1; j <= 3; j++)
                {
                    sum +=  2.0 * d[j] * Math.Cos(fact * j); 
                }
                w[i].Y *= sum;
                sumg += 2.0 * w[i].Y;
            }

            for (var i=0; i<=m; i++)
            {
                w[i].Y /= sumg;
            }


            for(var i = m; i >= 0; i--)
            {
                w.Add(i+m, w[i].Y);
            }
            w.RemoveAt(m);
            w.Sort();
            for (var i = 0; i<m;i++)
            {
                w[i].Y = w[2 * m - i].Y;
            }

            for(var i=0; i < 2m+1; i++)
            {
                w[i].X = i * dt;
            }

            return w;
        }
        public static PointPairList GetHarryPotter_HPF(double fc, int m, double dt) // fc - частота, m - длина фильтра
        {
            var w_hpf = GetHarryPotter(fc, m, dt);

            for (int i = 0; i<= 2*m;i++)
            {
                if (i == m) { w_hpf[i].Y = 1.0 - w_hpf[i].Y; } else
                {
                    w_hpf[i].Y = -w_hpf[i].Y;
                }
            }
            return w_hpf;
        }

        public static PointPairList GetHarryPotter_BP(double fc1, double fc2, int m, double dt) // fc - частота, m - длина фильтра
        {
            var lpw1 = GetHarryPotter(fc1, m, dt);
            var lpw2 = GetHarryPotter(fc2, m, dt);

            for (int i = 0; i<= 2*m;i++)
            {
                lpw2[i].Y -= lpw1[i].Y;
            }
            return lpw2;
        }

        public static PointPairList GetHarryPotter_BS(double fc1, double fc2, int m, double dt) // fc - частота, m - длина фильтра
        {
            var lpw1 = GetHarryPotter(fc1, m, dt);
            var lpw2 = GetHarryPotter(fc2, m, dt);

            for (int i = 0;i <= 2 * m; i++)
            {
                if (i == m) { lpw1[i].Y += 1.0 - lpw2[i].Y; } else
                {
                    lpw1[i].Y -= lpw2[i].Y;
                }
            }
            return lpw1;
        }
 
    }
}
