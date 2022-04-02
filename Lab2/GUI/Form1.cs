using System.Collections;
using System.Text;

namespace GUI
{
    public partial class MainForm : Form
    {
        private Register register;

        const int BITS = 8;
        string inputFile = @"./biker.txt"; 
        string outputFile = @"./test.mp3";
        string keyFile = @"./key.txt";

        string messageBin = @"./mBinary.txt";
        string cipherBin = @"./cBinary.txt";
        string keyBin = @"./kBinary.txt";

        public MainForm()
        {
            InitializeComponent();

            int[] bits = { 4, 22 };

            rtbRegister.Text = "111111111111111111111111";
            register = Register.getInstance(0, bits);
        }

        private string GetRegisterBoxState()
        {
            string state = rtbRegister.Text;

            int count = 0;
            while (count < state.Length) {
                if (!"01".Contains(state[count])) { 
                    state = state.Remove(count, 1);
                    count--;
                }
                count++;
            }

            state = state.PadLeft(register.Size, '0').Substring(0, register.Size);

            return state;
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            register.ResetKey();
            register.State = Convert.ToUInt32(GetRegisterBoxState(), 2);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void rtbRegister_TextChanged(object sender, EventArgs e)
        {
      
        }

        byte ConvertToByte(BitArray bits)
        {
            if (bits.Count != 8)
            {
                throw new ArgumentException("bits");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }

        private void writeKeyBinary(byte[] k)
        {
            foreach (byte b in k)
            {
                File.WriteAllText(keyBin, "AA");
            }
        }

        private void btnEcrypt_Click(object sender, EventArgs e)
        {
            byte[] m = File.ReadAllBytes(inputFile);
            byte[] c = new byte[m.Length];
            byte[] k = new byte[m.Length];

            register.GenerateKey(m.Length * BITS);

            BitArray messageBits = new(m);
            BitArray keyBits = new(register.keyList.ToArray());
            keyBits.CopyTo(k, 0);

            BitArray cipherBits = keyBits.Xor(messageBits);
            cipherBits.CopyTo(c, 0);

            File.WriteAllBytes(outputFile, c);
            File.WriteAllBytes(keyFile, k);

            writeKeyBinary(k);

     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (openInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFile = openInputFileDialog.FileName;
                tbInput.Text = openInputFileDialog.FileName.Split("\\").Last();
            }
        }

        private void tbOutput_Click(object sender, EventArgs e)
        {
            if (openOutputFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = openOutputFileDialog.FileName;
                tbOutput.Text = openOutputFileDialog.FileName.Split("\\").Last();
            }
        }
    }
}