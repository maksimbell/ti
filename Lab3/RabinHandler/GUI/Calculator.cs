using System;
using System.Numerics;

namespace GUI
{
    public class Calculator
    {
        public static BigInteger[] PerformEuclid(BigInteger a, BigInteger b)
        {
            BigInteger[] GCD = new BigInteger[] { a, b };
            BigInteger[] ArrA = new BigInteger[] { 1, 0 };
            BigInteger[] ArrB = new BigInteger[] { 0, 1 };

            while (GCD[1] != 0)
            {
                BigInteger quotient = GCD[0] / GCD[1];
                ArrA = new BigInteger[] { ArrA[1], ArrA[0] - quotient * ArrA[1] };
                ArrB = new BigInteger[] { ArrB[1], ArrB[0] - quotient * ArrB[1] };
                GCD = new BigInteger[] { GCD[1], GCD[0] % GCD[1] };
            }

            BigInteger[] Res = { GCD[0], ArrA[0], ArrB[0] };
            return Res;
        }

        public static BigInteger PerformFastModExp(BigInteger number, BigInteger power, BigInteger modulo)
        {
            BigInteger Res = 1;
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


        private static long sieveBorder = 0;
        private static List<long> primeNumbers = new List<long>();

        public static bool IsPrime(int num)
        {

            if (Math.Truncate(Math.Sqrt(num)) > sieveBorder)
            {
                NewEratosphen(num);
                primeNumbers.Sort();
            }

            if (num < sieveBorder)
            {
                return primeNumbers.Contains(num);
            }

            for (int i = 0; primeNumbers[i] < Math.Truncate(Math.Sqrt(num)); i++)
            {
                if (num % primeNumbers[i] == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void NewEratosphen(long newBorder)
        {
            sieveBorder = newBorder;
            bool[] Eratosphen = new bool[sieveBorder + 1];
            int i = 2;
            while (i * i < sieveBorder)
            {
                if (!Eratosphen[i])
                {
                    int j = i * i;
                    while (j < sieveBorder)
                    {
                        Eratosphen[j] = true;
                        if (i > 2)
                        {
                            j = j + 2 * i;
                        }
                        else
                        {
                            j += i;
                        }
                    }
                }
                i++;
            }

            for (i = 2; i < Eratosphen.Length; i++)
            {
                if (!Eratosphen[i] && !primeNumbers.Contains(i))
                {
                    primeNumbers.Add(i);
                }
            }
        }

    }
}
