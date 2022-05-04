using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GUI
{
    public class RabinHandler
    {
        private static RabinHandler Instance;
        public BigInteger P { get; set; }

        public BigInteger Q { get; set; }

        public BigInteger B { get; set; }
        public BigInteger N { get; set; }

        private RabinHandler(BigInteger p, BigInteger q, BigInteger b)
        {
            Reset(p, q, b);
        }

        public static RabinHandler getInstance(BigInteger p, BigInteger q, BigInteger b)
        {
            if (Instance == null)
                Instance = new RabinHandler(p, q, b);
            return Instance;
        }

        public BigInteger[] Encrypt(byte[] m)
        {
            BigInteger cipherIndex, messageIndex;
            BigInteger[] c = new BigInteger[m.Length];

            for (int i = 0; i < m.Length; i++)
            {
                cipherIndex = m[i] * (m[i] + B) % N;
                c[i] = cipherIndex;
            }

            return c;
        }

        public byte[] Decrypt(BigInteger[] c, ref List<BigInteger[]> allBytes)
        {
            byte[] m =  new byte[c.Length];

            allBytes = new List<BigInteger[]>();
            for (int i = 0; i < c.Length; i++)
            {
                BigInteger[] bigInt = new BigInteger[4];
                allBytes.Add(bigInt);
            }

            BigInteger[] roots = Calculator.PerformEuclid(P, Q);

            int count = 0;
            foreach (BigInteger bigInt in c)
            {
                BigInteger D = ((B * B % N) + (4 * bigInt % N)) % N;
                BigInteger Mp = Calculator.PerformFastModExp(D, (P + 1) / 4, P);
                BigInteger Mq = Calculator.PerformFastModExp(D, (Q + 1) / 4, Q);

                BigInteger[] d = new BigInteger[4]
                {
                      (roots[1] * P * Mq + roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq + roots[2] * Q * Mp) % N),
                      (roots[1] * P * Mq - roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq - roots[2] * Q * Mp) % N)
                };

                int p = 0;
                foreach (BigInteger di in d)
                {
                    BigInteger index;
                    if (((di - B) % 2) == 0)
                        index = ((di - B) / 2) % N;
                    else
                        index = ((di - B + N) / 2) % N;

                    if (index >= 0 && index < 256)
                    {
                        m[count] = (byte)index;
                    }

                    allBytes[count][p] = index;
                    p++;
                }

                count++;
            }

            return m;
        }

        public void Reset(BigInteger p, BigInteger q, BigInteger b)
        {
            P = p;
            Q = q;
            B = b;
            N = p * q;
        }
    }
}
