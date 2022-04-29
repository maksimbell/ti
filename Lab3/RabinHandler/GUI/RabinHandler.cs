using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class RabinHandler
    {
        private static RabinHandler Instance;
        private int P { get; set; }

        private int Q { get; set; }
       
        private int B { get; set; }
        
        private RabinHandler(int p, int q, int b)
        {
            Reset(p, q, b);
        }

        public static RabinHandler getInstance(int p = 0, int q = 0, int b = 0)
        {
            if (Instance == null)
                Instance = new RabinHandler(p, q, b);
            return Instance;
        }

        public byte[] Encrypt(byte[] m)
        {
            int N = P * Q;
            int cipherIndex, messageIndex;
            byte[] c = new byte[m.Length];
            //also check for b<n outside
            for (int i = 0; i < m.Length; i++)
            {
                cipherIndex = m[i] * (m[i] + B) % N;
                c[i] = (byte)cipherIndex;
            }

            return c;
        }

        public byte[] Decrypt(byte[] c)
        {
            byte[] m =  new byte[c.Length];

            int[] roots = Calculator.performEuclid(P, Q);
            int N = P * Q;

            int count = 0;
            foreach (byte letter in c)
            {
                long D = ((B * B % N) + (4 * letter % N)) % N;
                long Mp = Calculator.PerformFastExp(D, (P + 1) / 4, P);
                long Mq = Calculator.PerformFastExp(D, (Q + 1) / 4, Q);

                long[] d = new long[4]
                {
                      (roots[1] * P * Mq + roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq + roots[2] * Q * Mp) % N),
                      (roots[1] * P * Mq - roots[2] * Q * Mp) % N,
                      N - ((roots[1] * P * Mq - roots[2] * Q * Mp) % N)
                };

                foreach (int di in d)
                {
                    int index;
                    if (((di - B) % 2) == 0)
                        index = ((di - B) / 2) % N;
                    else
                        index = ((di - B + N) / 2) % N;

                    if (index >= 0 && index < 256)
                    {
                        m[count] = (byte)index;
                    }

                }

                count++;
            }

            return m;
        }

        public void Reset(int p, int q, int b)
        {
            P = p;
            Q = q;
            B = b;
        }
    }
}
