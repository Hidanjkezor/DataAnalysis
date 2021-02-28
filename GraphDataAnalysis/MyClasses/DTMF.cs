using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace GraphDataAnalysis.MyClasses
{
    class DTMF
    {
   static     Dictionary<char, double> freq_1 = new Dictionary<char, double>()
        {
            {'1',697},
            {'2',697},
            {'3',697},
            {'A',697},
            {'4',770},
            {'5',770},
            {'6',770},
            {'B',770},
            {'7',852},
            {'8',852},
            {'9',852},
            {'C',852},
            {'*',941},
            {'0',941},
            {'#',941},
            {'D',941},
        };
   static Dictionary<char, double> freq_2 = new Dictionary<char, double>()
        {
            {'1',1209},
            {'2',1336},
            {'3',1477},
            {'A',1633},
            {'4',1209},
            {'5',1336},
            {'6',1477},
            {'B',1633},
            {'7',1209},
            {'8',1336},
            {'9',1477},
            {'C',1633},
            {'*',1209},
            {'0',1336},
            {'#',1477},
            {'D',1633},
        };
        public static PointPairList dtmf_from_label(string s, double sample_rate)
        {
            PointPairList result = new PointPairList();
            double dt = 1.0 / sample_rate; // шаг= 1/ частота дискретизации
            double c_freq_time = 0.1 ; // время звучания сигнала
            double c_freq_pause_time = 0.1 ; // 
            double t = 0;

            foreach (var c in s)
            {
                double fin_t = c_freq_time + t; // время звуч сигнала + тек время
                while (t < fin_t)
                {
                    result.Add(t, 0.2*((Math.Sin(2*Math.PI*t* freq_1[c]))+ Math.Sin(2 * Math.PI * t * freq_2[c]))) ;
                    t += dt;
                }

                fin_t = c_freq_pause_time + t;
                while (t < fin_t) // добавляем паузы
                {
                    result.Add(t, 0);
                    t += dt;
                }
            }
            return result;
        }

    }
}
