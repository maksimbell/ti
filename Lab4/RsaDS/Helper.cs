using System;
using System.Numerics;

namespace RsaDS
{
    public static class Helper
    {
        public static BigInteger BigIntSqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!IsSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }
                return root;
            }
            return n;
        }

        public static Boolean IsSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n > lowerBound && n < upperBound);
        }

        public static bool IsPrime(BigInteger number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            BigInteger sqrt = BigIntSqrt(number);
            for (BigInteger i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
                if (a < b)
                    b %= a;
                else
                    a %= b;
            return a + b;
        }

        public static BigInteger GetHash(byte[] bytes, BigInteger n)
        {
            BigInteger H = 100;
            foreach (byte b in bytes)
                H = BigInteger.ModPow(b + H, 2, n);
            return H;
        }
    }
}