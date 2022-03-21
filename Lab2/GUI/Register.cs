using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Register
    {
        private const int size = 23;

        private UInt32 max;

        private UInt32 state;

        private UInt32 start;

        private int[] bits;

        private UInt32 key;

        public uint State { get => state; set => state = value; }

        public Register(UInt32 start, int[] bits)
        {
            this.start = start;
            this.State = start;
            this.bits = bits; 
            
            max = (UInt32)Math.Pow(2, size) - 1;
            key = 0;
        }

        public void Shift()
        {
            UInt32 bit = ((State & (UInt32)Math.Pow(2, bits[0])) >> bits[0]) ^ ((State & (UInt32)Math.Pow(2, bits[1])) >> bits[1]);

            ShiftKey(bit);
            State = (State << 1) & max ^ bit;
        }

        public void ShiftKey(UInt32 bit)
        {
            key = (key << 1) ^ bit; 
        }

        public UInt32 GenerateKey()
        {
            return key;
        }
    }
}
