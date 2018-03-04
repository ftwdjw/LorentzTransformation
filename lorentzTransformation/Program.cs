using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lorentzTransformation
{
    class MainClass
    {
        public const int N = 100;

        public static void Main(string[] args)
        {
            
            int i;
            double v,vSquared,gamma;

            string[] lorentz = new string[N]; 

            for (i = 0; i < N; i++)
            {
                v = (double)i / (double)N;//normalilzed to the speed of light C
                vSquared = Math.Pow(v, 2);
                gamma = 1 / Math.Sqrt((1 - vSquared));

                lorentz[i] = v.ToString() + "," + gamma.ToString();
            }


            File.WriteAllLines("lorentz.csv", lorentz); 
            Console.WriteLine("have written file"); 
            Console.ReadLine();

        }
    }
}
