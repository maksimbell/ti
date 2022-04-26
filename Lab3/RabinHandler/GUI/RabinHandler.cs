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

        public string Encrypt(string m)
        {
            string c = String.Empty;
            int n = P * Q;
            int cipherIndex, messageIndex;
            //also check for b<n outside
            foreach (byte letter in m)
            {
                cipherIndex = letter * (letter + B) % n;
                c += cipherIndex + " ";
            }


            return c;
        }

        public string Decrypt(string c)
        {
            return String.Empty;
        }

        public void Reset(int p, int q, int b)
        {
            P = p;
            Q = q;
            B = b;
        }
    }
}
