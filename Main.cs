using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ColumnCalculator
{
    class Main
    {
        static double chislo1 = 0, chislo2 = 0, resultat = 0;
        public static double q1 = 0, q2 = 0;
        public static string p = "";
        static int x = 0, c = 0;

        static private void Get(string a, string b)
        {
                chislo1 = Convert.ToDouble(a.Replace(".", ","));
                chislo2 = Convert.ToDouble(b.Replace(".", ","));
            
         }

        static public void Exit()
        {
            Environment.Exit(0);
        }

        static public double Summarize(string TB1, string TB2)
        {
            Get(TB1, TB2);
            resultat = chislo1 + chislo2;
            while ((q1 % 1 != 0) | (q2 % 1 != 0)) { q1 *= 10; q2 *= 10; }
            return resultat;
        }

        static public double Subtraction(string TB1, string TB2)
        {
            Get(TB1, TB2);
            resultat = chislo1 - chislo2;
            while ((q1 % 1 != 0) | (q2 % 1 != 0)) { q1 *= 10; q2 *= 10; }
            return resultat;
        }

        static public string Multiplication(string TB1, string TB2)
        {
            Get(TB1, TB2);
            resultat = chislo1 * chislo2;
            q1 = chislo1;
            q2 = chislo2;
            p = Convert.ToString(q1) + "\n" + "x" + Convert.ToString(q2) + "\n----------";

            while (q1 % 1 != 0) { q1 *= 10; }
            while (q2 % 1 != 0) { q2 *= 10; }
            x = Convert.ToInt32(q2);
            c = Convert.ToInt32(q1);
            for (int i = 1; i < TB2.Length; i++)
            {
                p += "\n+" + Convert.ToString((x % 10) * c);
                for (int j = 0; j <= i - 2; j++)
                    p += "0";
                x /= 10;

            }
            p += "\n----------\n" + Convert.ToString(resultat);
            return p;
        }

        static public string Division(string TB1, string TB2)
        {            
            long count = 0;
            Get(TB1, TB2);
            resultat = chislo1 / chislo2;
            q1 = chislo1;
            q2 = chislo2;
            while (q1 >= q2) { count++;  q1 -= q2; }
            q1 = chislo1;
            q2 = chislo2;
            while ((q1 % 1 != 0) | (q2 % 1 != 0)) { q1 *= 10; q2 *= 10; }
            p = "  " + Convert.ToString(q1) + "|" + Convert.ToString(q2) + "\n-" + Convert.ToString(q2 * count) + "|" + Convert.ToString(Math.Round(resultat, 3));
            q1 -= count * q2;
            count--;
            for (long i = count; i > 0; i--)
            {
                for (int j = 0; j < 100; j++)
                    if (q1 < q2) q1 *= 10; else break;
                p += "\n-----\n" + Convert.ToString(q1) + "\n" + "-" + Convert.ToString(Math.Floor(q1/q2)*q2);
                q1 -= Math.Floor(q1 / q2) * q2;
            }
            return p;
        }
    }
}
