using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace GUI
{
    public static class ArgsChecker
    {
        public static string CheckPublicKey(BigInteger n, BigInteger b, ref bool error)
        {
            error = true;

            if(b > n - 1)
            {
                return "Expected: B < P * Q";
            }

            error = false;
            return String.Empty;
        }

        public static string CheckPrivateKey(BigInteger p, BigInteger q, ref bool error)
        {
            error = true;

            //if (!Calculator.IsPrime(p))
                return "Expected: P - prime number";
            //if (!Calculator.IsPrime(q))
                return "Expected: Q - prime number";
            if (p % 4 != 3)
                return "Expected: P mod 4 == 3";
            if (q % 4 != 3)
                return "Expected: Q mod 4 == 3";
            if (p == q)
                return "Expected: P != Q";

            error = false;
            return String.Empty;
        }
    }
}
