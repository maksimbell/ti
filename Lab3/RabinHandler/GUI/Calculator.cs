﻿using System;
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
        public static void Get_d_s(BigInteger n, out BigInteger d, out int s)
        {
            s = 0;
            d = n - 1;
            while (d % 2 != 1)
            {
                d /= 2;
                s++;
            }
        }

        public static BigInteger GetRandBigInt()
        {
            Random random = new Random();

            byte[] bytes = new byte[256];
            random.NextBytes(bytes);

            return new BigInteger(bytes);
        }

        public static bool MillerRabin(BigInteger n)
        {
            Get_d_s(n, out var d, out var s);
            var k = (int)BigInteger.Log(n, 2.8);
            for (var i = 0; i < k; i++)
            {
                var a = BigInteger.ModPow(GetRandBigInt(), d, n);
                if (a == 1 || a == n - 1) continue;
                for (var r = 1; r < s; r++)
                {
                    if (BigInteger.ModPow(a, d * BigInteger.Pow(2, r), n) == n - 1) goto l;
                    return false;
                    l:;
                }
            }

            return true;
        }

        /*public static bool IsPrime(int num)
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
        }*/

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

        public static BigInteger Power(BigInteger x, BigInteger y, BigInteger p)
        {

            BigInteger res = 1;

            x = x % p;

            while (y > 0)
            {

                if ((y & 1) == 1)
                    res = (res * x) % p;

                y = y >> 1; 
                x = (x * x) % p;
            }

            return res;
        }

        public static bool MillerTest(BigInteger d, BigInteger n)
        {

            Random r = new Random();
            BigInteger a = 2 + (int)(r.Next() % (n - 4));

            BigInteger x = Power(a, d, n);

            if (x == 1 || x == n - 1)
                return true;

            while (d != n - 1)
            {
                x = (x * x) % n;
                d *= 2;

                if (x == 1)
                    return false;
                if (x == n - 1)
                    return true;
            }

            return false;
        }
        public static bool IsPrime(BigInteger n, BigInteger k)
        {

            if (n <= 1 || n == 4)
                return false;
            if (n <= 3)
                return true;

            BigInteger d = n - 1;

            while (d % 2 == 0)
                d /= 2;

            for (int i = 0; i < k; i++)
                if (MillerTest(d, n) == false)
                    return false;

            return true;
        }
    }
}
