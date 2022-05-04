using System.Numerics;

namespace GUI
{
    public partial class RabinForm : Form
    {
        private string Path = @"C:\Users\maksimbell\bsuir\4sem\ti\labs\Lab3\RabinHandler\GUI\bin\Debug\net6.0-windows\tests\";

        private RabinHandler handler;

        private int MessageSize;

        public RabinForm()
        {
            InitializeComponent();
        }

        private void RabinForm_Load(object sender, EventArgs e)
        {
            handler = RabinHandler.getInstance(0, 0, 0);
        }
        private bool CheckFormInput()
        {
            bool error = false;
            string errorString = string.Empty;

            
            errorString = ArgsChecker.CheckPublicKey(BigInteger.Parse(tbPrime1.Text) *
                BigInteger.Parse(tbPrime2.Text), BigInteger.Parse(tbRan.Text), ref error);
            if (error) {
                MessageBox.Show(errorString, "Warnings");
                return !error;
            }

            errorString += ArgsChecker.CheckPrivateKey(BigInteger.Parse(tbPrime1.Text), BigInteger.Parse(tbPrime2.Text), ref error);
            if (error)
            {
                MessageBox.Show(errorString, "Warnings");
                return !error;
            }

            return !error;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!CheckFormInput()) {
                return;
            }

            byte[] message = File.ReadAllBytes(Path + "m.txt");
            BigInteger[] cipher = new BigInteger[message.Length];

            MessageSize = message.Length;

            handler.Reset(BigInteger.Parse(tbPrime1.Text), BigInteger.Parse(tbPrime2.Text), BigInteger.Parse(tbRan.Text));
            cipher = handler.Encrypt(message);

            int bigIntSize = cipher[0].ToByteArray().Length;
            byte[] result = new byte[cipher.Length * bigIntSize];

            int current = 0;
            foreach(BigInteger bigInt in cipher)
            {
                int lol = bigInt.GetByteCount();
                byte[] arr = bigInt.ToByteArray();

                byte[] temp = new byte[1];
                int count = arr.Length - 1;
                while (count > -1 && arr[count] == 0)
                {
                    Array.Resize(ref arr, arr.Length - 1);
                    count--;
                }

                foreach(byte b in arr)
                {
                    //if (!(b == 0 && arr.Length != 1))
                    //{
                        result[current] = b;
                        current++;
                    //}
                }
            }

            File.WriteAllBytes(Path + "c.txt", result);

            if (cbSize.Checked)
            {
                rtbOutput.Text = "Cipher:\n";
                foreach (BigInteger b in cipher)
                {
                    rtbOutput.Text += b.ToString() + " ";
                }
            }
            
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!CheckFormInput())
            {
                return;
            }
            //fix messagesize problem
            byte[] cipher = File.ReadAllBytes(Path + "c.txt");
            byte[] message = new byte[cipher.Length];

            BigInteger[] bigCipher = new BigInteger[MessageSize];
            byte[] temp = new byte[cipher.Length / MessageSize];

            for(int i = 0; i < MessageSize; i++)
            {
                for (int j = 0; j < cipher.Length/MessageSize; j++)
                {
                    temp[j] = cipher[(cipher.Length/MessageSize) * i + j];
                }

                bigCipher[i] = new BigInteger(temp.Concat(new byte[] { 0 }).ToArray());
                temp = new byte[cipher.Length/MessageSize];
            }

            handler.Reset(BigInteger.Parse(tbPrime1.Text), BigInteger.Parse(tbPrime2.Text), BigInteger.Parse(tbRan.Text));

            List<BigInteger[]> allBytes = new List<BigInteger[]>();

            message = handler.Decrypt(bigCipher, ref allBytes);

            File.WriteAllBytes(Path + "m.txt", message);

            if (cbSize.Checked)
            {
                rtbOutput.Text += "\nMessage:\n";
                foreach (byte b in message)
                {
                    rtbOutput.Text += b.ToString() + " ";
                }

                rtbOutput.Text += "\n\n";
                foreach (BigInteger[] b in allBytes)
                {
                    foreach (BigInteger ex in b)
                    {
                        rtbOutput.Text += ex.ToString() + " ";
                    }
                    rtbOutput.Text += "\n";
                }
            }
        }

        private bool CheckTextBoxes()
        {
            return (tbPrime1.Text == String.Empty || 
                tbPrime2.Text == String.Empty || 
                tbRan.Text == String.Empty);
        }

        private void tbPrime1_TextChanged(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
            else
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }
        }

        private void tbPrime2_TextChanged(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
            else
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }
        }

        private void tbPrime1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbPrime2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbRan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbRan_TextChanged(object sender, EventArgs e)
        {
            if (CheckTextBoxes())
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
            else
            {
                btnDecrypt.Enabled = true;  
                btnEncrypt.Enabled = true;
            }
        }

        private void cbSize_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}