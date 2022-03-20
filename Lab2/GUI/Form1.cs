namespace GUI
{
    public partial class MainForm : Form
    {
        private const int registerSize = 23;
        public MainForm()
        {
            InitializeComponent();

            rtbRegister.MaxLength = registerSize;
        }
    }
}