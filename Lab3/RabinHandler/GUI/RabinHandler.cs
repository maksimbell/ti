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

        public long P { get; set; }

        public long Q { get; set; }

        public long B { get; set; }

        public long N { get; set; }

        private RabinHandler(long p, long q, long b)
        {
            Reset(p, q, b);
        }

        public static RabinHandler getInstance(long p, long q, long b)
        {
            if (Instance == null)
                Instance = new RabinHandler(p, q, b);
            return Instance;
        }

        public long[] Encrypt(byte[] m)
        {
            long cipherIndex, messageIndex;
            long[] c = new long[m.Length];

            for (int i = 0; i < m.Length; i++)
            {
                cipherIndex = (m[i] * (m[i] + B) % N);
                c[i] = cipherIndex;
            }

            return c;
        }

        public byte[] Decrypt(long[] c, ref List<int[]> allBytes)
        {
            byte[] m =  new byte[c.Length];

            allBytes = new List<int[]>();
            for (int i = 0; i < c.Length; i++)
            {
                int[] b = new int[4];
                allBytes.Add(b);
            }

            long[] roots = Calculator.PerformEuclid(P, Q);

            int count = 0;
            foreach (long letter in c)
            {
                long D = ((B * B % N) + (4 * letter % N)) % N;
                long Mp = Calculator.PerformFastModExp(D, (P + 1) / 4, P);
                long Mq = Calculator.PerformFastModExp(D, (Q + 1) / 4, Q);

                long[] d = new long[4]
                {
                      (roots[1] * P * Mq + roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq + roots[2] * Q * Mp) % N),
                      (roots[1] * P * Mq - roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq - roots[2] * Q * Mp) % N)
                };

                int p = 0;
                foreach (long di in d)
                {
                    long index;
                    if (((di - B) % 2) == 0)
                        index = ((di - B) / 2) % N;
                    else
                        index = ((di - B + N) / 2) % N;

                    if (index >= 0 && index < 256)
                    {
                        m[count] = (byte)index;
                    }

                    allBytes[count][p] = (int)index;
                    p++;
                }

                count++;
            }

            return m;
        }

        public void Reset(long p, long q, long b)
        {
            P = p;
            Q = q;
            B = b;
            N = p * q;
        }
    }
}
