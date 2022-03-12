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

            File.WriteAllText(@"./ס.txt", ColumnCryptographer.Encrypt(m, k));

            MessageBox.Show("encryption completed", "cryptographer");
        }
    }
}