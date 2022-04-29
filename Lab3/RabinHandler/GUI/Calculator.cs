using System;
namespace GUI
{
    public class Calculator
    {
        public static int[] performEuclid(int a, int b)
        {
            int[] GCD = new int[] { a, b };
            int[] ArrA = new int[] { 1, 0 };
            int[] ArrB = new int[] { 0, 1 };

            while (GCD[1] != 0)
            {
                int quotient = GCD[0] / GCD[1];
                ArrA = new int[] { ArrA[1], ArrA[0] - quotient * ArrA[1] };
                ArrB = new int[] { ArrB[1], ArrB[0] - quotient * ArrB[1] };
                GCD = new int[] { GCD[1], GCD[0] % GCD[1] };
            }

            int[] Res = { GCD[0], ArrA[0], ArrB[0] };
            return Res;
        }

        public static long PerformFastExp(long number, int power, int modulo)
        {
            long Res = 1;
            while (power != 0)
            {
                while (power % 2 == 0)
                {
                    power /= 2;
                    number = ((number % modulo) * (number % modulo)) % modulo;
                }
                power--;
                Res = ((Res % modulo) * (number % modulo)) % modulo;
            }
            return Res;
        }

    }
}
