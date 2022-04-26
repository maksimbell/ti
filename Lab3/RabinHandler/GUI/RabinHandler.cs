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

        public static RabinHandler getInstance(int p, int q, int b)
        {
            if (Instance == null)
                Instance = new RabinHandler(p, q, b);
            return Instance;
        }

        private string Encrypt()
        {
            return String.Empty;
        }

        private string Decrypt()
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
