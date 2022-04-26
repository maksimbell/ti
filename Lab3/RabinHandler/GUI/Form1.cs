namespace GUI
{
    public partial class RabinForm : Form
    {
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
            handler.Reset(int.Parse(tbPrime1.Text), int.Parse(tbPrime2.Text), int.Parse(tbRan.Text));
            rtbOutput.Text =  handler.Encrypt("BSUIR".ToUpper());
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //nothing
        }
    }
}