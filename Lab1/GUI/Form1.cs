namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbKey_CheckedChanged(object sender, EventArgs e)
        {
         
            
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string path = @"./m.txt";
            string message = String.Empty;
            
            if (File.Exists(path))
            {
                message = File.ReadAllText(path).ToLower().Replace(" ", "");
                switch (cbMethods.SelectedIndex)
                {
                    case 0:
                        
                        string key = rtbKey.Text.ToLower();
                        File.WriteAllText(@"./c.txt", ColumnCryptographer.Encrypt(message, key));
                        break;

                    case 1:
                        break;

                    case 2:
                        char[,] keyMatrix = new char[5, 5];
                        string[] lines = File.ReadAllLines(@"./playfair.txt").Take(5).ToArray();
                        for (int i = 0; i < 5; i++)
                        {
                            char[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                            for (int j = 0; j < 5; j++)
                            {
                                keyMatrix[i, j] = Char.ToLower(row[j]);
                            }
                        }
                       
                        File.WriteAllText(@"./c.txt", PlayfairCryptographer.Encrypt(message, keyMatrix));
                        break;
                }

                MessageBox.Show("encryption completed", "cryptographer");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string path = @"./c.txt";
            string cipher = String.Empty;
            string key = rtbKey.Text.ToLower();

            if (File.Exists(path))
            {
                cipher = File.ReadAllText(path).ToLower().Replace(" ", "");
                switch (cbMethods.SelectedIndex)
                {
                    case 0:
                        File.WriteAllText(@"./m.txt", ColumnCryptographer.Decrypt(cipher, key));
                        break;
                    case 1:
                        break;
                    case 2:
                        char[,] keyMatrix = new char[5, 5];
                        string[] lines = File.ReadAllLines(@"./playfair.txt").Take(5).ToArray();
                        for (int i = 0; i < 5; i++)
                        {
                            char[] row = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                            for (int j = 0; j < 5; j++)
                            {
                                keyMatrix[i, j] = Char.ToLower(row[j]);
                            }
                        }

                        File.WriteAllText(@"./m.txt", PlayfairCryptographer.Decrypt(cipher, keyMatrix));
                        break;
                        
                }

                MessageBox.Show("decryption completed", "cryptographer");
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void cbMethods_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbMethods.SelectedIndex == 2)
            {
                rtbKey.Clear();
                panelKey.Hide();
            }
            else
            {
                panelKey.Show();
            }
        }

        private void lbKey_Click(object sender, EventArgs e)
        {

        }
    }
}