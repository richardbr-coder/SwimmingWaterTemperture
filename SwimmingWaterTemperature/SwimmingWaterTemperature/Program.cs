using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingWaterTemperature
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Write("\nPlease enter the water temperature : ");
                int x = Int32.Parse(ReadLine());
                try
                {
                    if (CheckComfort(x))
                    {
                        Write(x + " degrees is comfortable for swimming.");
                    }
                    else
                    {
                        Write(x + " degrees is not comfortable for swimming.");
                    }
                }
                catch (Exception e)
                {
                    WriteLine(e);
                }
            }
        }

        public static Boolean CheckComfort(int temp)
        {
            if (temp >= 70 && temp <= 85)
            {
                return true;
            }
            else if (temp >= 32 && temp <= 212)
            {
                return false;
            }
            else
            {
                throw new ArgumentException("Value does not fall within the exptected range.");
            }
        }
    }
}
