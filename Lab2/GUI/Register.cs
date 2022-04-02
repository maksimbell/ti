using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Register
    {
        private static Register? instance;//допускает значение null

        private const int SIZE = 23;
        private const int BITS = 8;

        private UInt32 state, poppedBit, newBit, max;

        private readonly int[] bits;

        private string key;

        public UInt32 State { get => state; set => state = value; }

        public int Size { get => SIZE; }

        public List<Boolean> keyList = new List<Boolean>();
        public List<Boolean> bitsList = new List<Boolean>();

        public string Key { get => key; set => key = value; }

        private Register(UInt32 start, int[] bits)
        {
            this.State = start;
            this.bits = bits; 
            
            max = (UInt32)Math.Pow(2, SIZE) - 1;
            //key = String.Empty;
        }

        public static Register getInstance(UInt32 start, int[] bits)
        {
            if (instance == null)
            {
                Register.instance = new Register(start, bits);
            }

            return instance;
        }

        public void Shift()
        {
            newBit = ((State & (UInt32)((2 << bits[0]) - 1)) >> bits[0]) ^ ((State & (UInt32)((2 << bits[1]) - 1)) >> bits[1]);
            poppedBit = (State & max) >> (SIZE - 1);

            ShiftKey(poppedBit);
            State = (State << 1) & max ^ newBit;
        }

        public void ShiftKey(UInt32 bit)
        {
            //key += bit.ToString(); 
            bitsList.Add(bit == 1);
            if (bitsList.Count % BITS == 0)
            {
                for (int i = BITS - 1; i > -1; i--)
                {
                    keyList.Add(bitsList[i]);
                }
                bitsList = new List<bool> { };
            }
        }

        public void GenerateKey(int len)
        {
            ResetKey();

            keyList.Capacity = len;

            for (int i = 0; i < len; i++)
            {
                this.Shift();
            }
        }

        public void ResetKey()
        {
            keyList.Clear();
            bitsList.Clear();
        }
    }
}
