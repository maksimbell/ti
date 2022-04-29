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
            handler = RabinHandler.getInstance();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            byte[] message = File.ReadAllBytes(Path + "m.txt");
            byte[] cipher = new byte[message.Length];

            handler.Reset(int.Parse(tbPrime1.Text), int.Parse(tbPrime2.Text), int.Parse(tbRan.Text));
            cipher = handler.Encrypt(message); 

            File.WriteAllBytes(Path + "c.txt", cipher);

            rtbOutput.Text = "Cipher:\n";
            foreach (byte b in cipher)
            {
                rtbOutput.Text += b.ToString() + " ";
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            byte[] cipher = File.ReadAllBytes(Path + "c.txt");
            byte[] message = new byte[cipher.Length];

            message = handler.Decrypt(cipher);

            File.WriteAllBytes(Path + "m.txt", message);

            rtbOutput.Text += "\nMessage:\n";
            foreach (byte b in message)
            {
                rtbOutput.Text += b.ToString() + " ";
            }
        }
    }
}