namespace GUI
{
    public partial class RabinForm : Form
    {
        RabinHandler handler;
        public RabinForm()
        {
            InitializeComponent();
        }

        private void RabinForm_Load(object sender, EventArgs e)
        {
            handler = RabinHandler.getInstance(0, 0, 0);
        }
    }
}