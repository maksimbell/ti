using System.Numerics;

namespace GUI
{
    public partial class RabinForm : Form
    {
        private string Path = @"C:\Users\maksimbell\bsuir\4sem\ti\labs\Lab3\RabinHandler\GUI\bin\Debug\net6.0-windows\tests\";

        private RabinHandler handler;
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

            
            //errorString = ArgsChecker.CheckPublicKey(long.Parse(tbPrime1.Text), long.Parse(tbRan.Text), ref error);
            if (error) {
                MessageBox.Show(errorString, "Warnings");
                return !error;
            }

            //errorString += ArgsChecker.CheckPrivateKey(long.Parse(tbPrime1.Text), long.Parse(tbPrime2.Text), ref error);
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

            handler.Reset(BigInteger.Parse(tbPrime1.Text), BigInteger.Parse(tbPrime2.Text), BigInteger.Parse(tbRan.Text));
            cipher = handler.Encrypt(message);

            int bigIntSize = cipher[0].ToByteArray().Length;
            byte[] result = new byte[cipher.Length * bigIntSize];

            int current = 0;
            foreach(BigInteger bigInt in cipher)
            {
                foreach(byte b in bigInt.ToByteArray())
                {
                    result[current] = b;
                    current++;
                }
            }


            File.WriteAllBytes(Path + "c.txt", result);

            rtbOutput.Text = "Cipher:\n";
            foreach (BigInteger b in cipher)
            {
                rtbOutput.Text += b.ToString() + "\n";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!CheckFormInput())
            {
                return;
            }

            byte[] cipher = File.ReadAllBytes(Path + "c.txt");
            byte[] message = new byte[cipher.Length];

            handler.Reset(BigInteger.Parse(tbPrime1.Text), BigInteger.Parse(tbPrime2.Text), BigInteger.Parse(tbRan.Text));
            message = handler.Decrypt(cipher);

            File.WriteAllBytes(Path + "m.txt", message);

            rtbOutput.Text += "\nMessage:\n";
            foreach (byte b in message)
            {
                rtbOutput.Text += b.ToString() + " ";
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
    }
}