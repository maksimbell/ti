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
            string a = "אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ";
            string p = @"./m.txt";
            string m = String.Empty;
            string k = rtbKey.Text.ToLower();

            if (File.Exists(p))
            {
                m = File.ReadAllText(p).ToLower().Replace(" ", "");
            }

            File.WriteAllText(@"./c.txt", ColumnCryptographer.Encrypt(m, k));

            MessageBox.Show("encryption completed", "cryptographer");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string a = "אבגדהו¸זחטיךכלםמןנסעףפץצקרשתûü‎‏ÿ";
            string p = @"./c.txt";
            string c = String.Empty;
            string k = rtbKey.Text.ToLower();

            if (File.Exists(p))
            {
                c = File.ReadAllText(p).ToLower().Replace(" ", "");
            }

            File.WriteAllText(@"./m.txt", ColumnCryptographer.Decrypt(c, k));

            MessageBox.Show("decryption completed", "cryptographer");
        }
    }
}