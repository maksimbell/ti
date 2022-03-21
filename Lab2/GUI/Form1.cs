namespace GUI
{
    public partial class MainForm : Form
    {
        private Register register = null;
        public MainForm()
        {
            InitializeComponent();

            int[] bits = { 4, 22 };
            register = new Register(8388607, bits);
        }

        private void btnKey_Click(object sender, EventArgs e)
        {
            register.Shift();

            //lblTest.Text = Convert.ToString(register.State, 2);
        }
    }
}