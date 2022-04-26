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
            lblRan.Text =  handler.Encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //nothing
        }
    }
}