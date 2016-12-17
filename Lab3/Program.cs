using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        private static Random _rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of iteration");
            var count = int.Parse(Console.ReadLine());

            string state = "0000";

            for (int i = 0; i < count; i++)
            {
                state = GetNextState(state);
                Console.WriteLine(state);
            }

            Console.ReadLine();
        }


        private static string GetNextState(string currentState)
        {
            var ver = _rnd.NextDouble();

            Console.Write(ver+"\t");

            if (currentState == "0000")
            {
                if (ver <= 0.7)
                {
                    return "0000";
                }

                return "1010";
            }

            if (currentState == "0001")
            {
                if (ver <= 0.35)
                {
                    return "0000";
                }
                if (ver > 0.35 && ver <= 0.7)
                {
                    return "0001";
                }
                if (ver > 0.7 && ver <= 0.85)
                {
                    return "1010";
                }
                if (ver > 0.85)
                {
                    return "1011";
                }
            }

            if (currentState == "0010")
            {
                if (ver <= 0.245)
                {
                    return "0001";
                }
                if (ver > 0.245 && ver <= 0.7)
                {
                    return "0010";
                }
                if (ver > 0.7 && ver <= 0.805)
                {
                    return "1011";
                }
                if (ver > 0.805)
                {
                    return "1110";
                }
            }

            if (currentState == "0011")
            {
                if (ver <= 0.245)
                {
                    return "0001";
                }
                if (ver > 0.245 && ver <= 0.4725)
                {
                    return "0010";
                }
                if (ver > 0.4725 && ver <= 0.7)
                {
                    return "0011";
                }
                if (ver > 0.7 && ver <= 0.7525)
                {
                    return "1011";
                }
                if (ver > 0.7525 && ver <= 0.85)
                {
                    return "1110";
                }
                if (ver > 0.85)
                {
                    return "1111";
                }
            }

            if (currentState == "0110")
            {
                if (ver <= 0.245)
                {
                    return "0011";
                }
                if (ver > 0.245 && ver <= 0.7)
                {
                    return "0110";
                }
                if (ver > 0.7 && ver <= 0.805)
                {
                    return "1111";
                }
                if (ver > 0.805)
                {
                    return "2110";
                }
            }

            if (currentState == "0111")
            {
                if (ver <= 0.1225)
                {
                    return "0001";
                }
                if (ver > 0.1225 && ver <= 0.245)
                {
                    return "0011";
                }
                if (ver > 0.245 && ver <= 0.4725)
                {
                    return "0110";
                }
                if (ver > 0.4725 && ver <= 0.7)
                {
                    return "0111";
                }
                if (ver > 0.7 && ver <= 0.7525)
                {
                    return "1011";
                }
                if (ver > 0.7525 && ver <= 0.805)
                {
                    return "1111";
                }
                if (ver > 0.805 && ver <= 0.9025)
                {
                    return "2110";
                }
                if (ver > 0.9025)
                {
                    return "2111";
                }
            }

            if (currentState == "1010")
            {
                if (ver <= 0.245)
                {
                    return "0001";
                }
                if (ver > 0.245 && ver <= 0.7)
                {
                    return "0010";
                }
                if (ver > 0.7 && ver <= 0.805)
                {
                    return "1011";
                }
                if (ver > 0.805)
                {
                    return "1110";
                }
            }

            if (currentState == "1011")
            {
                if (ver <= 0.245)
                {
                    return "0001";
                }
                if (ver > 0.245 && ver <= 0.4725)
                {
                    return "0010";
                }
                if (ver > 0.4725 && ver <= 0.7525)
                {
                    return "0011";
                }
                if (ver > 0.7525 && ver <= 0.805)
                {
                    return "1011";
                }
                if (ver > 0.805 && ver <= 0.9025)
                {
                    return "1110";
                }
                if (ver > 0.9025)
                {
                    return "1111";
                }
            }

            if (currentState == "1110")
            {
                if (ver <= 0.245)
                {
                    return "0011";
                }
                if (ver > 0.245 && ver <= 0.7)
                {
                    return "0110";
                }
                if (ver > 0.7 && ver <= 0.805)
                {
                    return "1111";
                }
                if (ver > 0.805)
                {
                    return "2110";
                }
            }

            if (currentState == "1111")
            {
                if (ver <= 0.245)
                {
                    return "0011";
                }
                if (ver > 0.245 && ver <= 0.4725)
                {
                    return "0110";
                }
                if (ver > 0.4725 && ver <= 0.7)
                {
                    return "0111";
                }
                if (ver > 0.7 && ver <= 0.805)
                {
                    return "1111";
                }
                if (ver > 0.805 && ver <= 0.9025)
                {
                    return "2110";
                }
                if (ver > 0.9025)
                {
                    return "2111";
                }
            }

            if (currentState == "2110")
            {
                if (ver <= 0.245)
                {
                    return "0111";
                }
                if (ver > 0.245 && ver <= 0.895)
                {
                    return "2110";
                }
                if (ver > 0.895)
                {
                    return "2111";
                }
            }

            if (currentState == "2111")
            {
                if (ver <= 0.245)
                {
                    return "0111";
                }
                if (ver > 0.245 && ver <= 0.57)
                {
                    return "2110";
                }
                if (ver > 0.57)
                {
                    return "2111";
                }
            }

            return "0000";
        }
    }
}
