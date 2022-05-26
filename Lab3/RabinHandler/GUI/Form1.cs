using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using GUI.Serializer;

namespace GUI
{
    public partial class RabinForm : Form
    {
        private string Path = @"C:\Users\maksimbell\bsuir\4sem\ti\labs\Lab3\RabinHandler\GUI\bin\Debug\net6.0-windows\tests\";

        private RabinHandler handler;

        private CustomBinarySerializer<long[]> serializer;

        public RabinForm()
        {
            InitializeComponent();

            serializer = new CustomBinarySerializer<long[]>();
        }

        private void RabinForm_Load(object sender, EventArgs e)
        {
            handler = RabinHandler.getInstance(0, 0, 0);
        }
        private bool CheckFormInput()
        {
            bool error = false;
            string errorString = string.Empty;

            
            errorString = ArgsChecker.CheckPublicKey(long.Parse(tbPrime1.Text) *
                long.Parse(tbPrime2.Text), long.Parse(tbRan.Text), ref error);
            if (error) {
                MessageBox.Show(errorString, "Warnings");
                return !error;
            }

            errorString += ArgsChecker.CheckPrivateKey(long.Parse(tbPrime1.Text), long.Parse(tbPrime2.Text), ref error);
            if (error)
            {
                MessageBox.Show(errorString, "Warnings");
                return !error;
            }

            return !error;
        }


        /*⠀⠀⠀⣀⡠⠤⠤⠤⠠⠤⠄⠤⠤⠤⡤⣄⠀⠀⠀⠀
        ⠀⠐⡍⢀⣴⣶⣶⣦⡄⠠⣶⣶⣶⣷⡆⢸⠀⠀⠀⠀
        ⠀⠀⡇⠙⠿⠿⠏⢻⠃⠀⠉⠛⠛⠛⠁⢸⣀⡏⣆⡀
        ⠀⢠⠇⠀⠀⠀⢀⣿⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⡇
        ⢠⡋⢀⠀⠀⠀⣨⣿⣛⣋⣁⢀⠂⠀⠀⣀⡠⠴⠒⠃
        ⠈⠻⢾⠀⠀⠀⠈⠛⠲⠒⠊⠁⠀⠄⠀⢸⠀⠀⠀⠀
        ⠀⠀⢸⣀⠀⠀⠐⡟⠒⠒⠒⣷⠀⠀⠀⢘⠀⠀⠀⠀
        ⠀⠀⠀⠉⠉⠉⠉⠁⠀⠀⠀⠙⠒⠒⠊⠉
        ⠀*/

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!CheckFormInput()) return;

            string cipherText = string.Empty;
            byte[] message = File.ReadAllBytes(Path + "m.txt");
            long[] cipher = new long[message.Length];

            handler.Reset(long.Parse(tbPrime1.Text), long.Parse(tbPrime2.Text), long.Parse(tbRan.Text));
            cipher = handler.Encrypt(message);

            serializer.Serialize(cipher, Path + "c.txt");

            if (cbSize.Checked)
            {
                foreach (long c in cipher)
                {
                    cipherText += c.ToString() + " ";
                }
                rtbOutput.Text = "Cipher:\n";
                rtbOutput.Text += cipherText;
            }

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!CheckFormInput()) return;

            long[] cipher = serializer.Deserialize(Path + "c.txt");
            byte[] message = new byte[cipher.Length];

            List<int[]> allBytes = new List<int[]>();

            handler.Reset(long.Parse(tbPrime1.Text), long.Parse(tbPrime2.Text), long.Parse(tbRan.Text));
            message = handler.Decrypt(cipher, ref allBytes);

            File.WriteAllBytes(Path + "m.txt", message);

            if (cbSize.Checked)
            {
                rtbOutput.Text += "\nMessage:\n";
                foreach (byte b in message)
                {
                    rtbOutput.Text += b.ToString() + " ";
                }

                rtbOutput.Text += "\n\n";
                foreach (int[] b in allBytes)
                {
                    foreach (int ex in b)
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