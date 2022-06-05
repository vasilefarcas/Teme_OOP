using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2623PbInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), rez = 0;
            int[] v = new int[n], st = new int[n], dr = new int[n];
            string[] buff = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int min = 32000, max = -32000;
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(buff[i]);
            }
            for (int i = 1; i < n - 1; i++)
            {
                if (v[i] > max)
                {
                    st[i] = v[i];
                    max = st[i];
                }
                else
                    st[i] = max;
                if (v[n - i - 1] < min)
                {
                    dr[n - i - 1] = v[n - i - 1];
                    min = dr[n - i - 1];
                }
                else
                    dr[i] = min;
            }
            for (int i = 1; i < n - 1; i++)
            {
                if (st[i] == dr[i])
                    rez++;
            }

            Console.WriteLine(rez--);
            Console.ReadLine();
        }
    }
}
