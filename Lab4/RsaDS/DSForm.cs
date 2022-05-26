using System.Numerics;

namespace RsaDS
{
    public partial class DSForm : Form
    {
        private BigInteger p;

        private BigInteger q;

        private BigInteger r;

        private BigInteger e;

        private BigInteger d;

        private BigInteger PhiR;

        public DSForm()
        {
            InitializeComponent();
        }

        private void DSForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKeyGen_Click(object sender, EventArgs e)
        {
            try
            {
                p = BigInteger.Parse(tbPnum.Text);
                q = BigInteger.Parse(tbQnum.Text);
                d = BigInteger.Parse(tbDnum.Text);
                if (Helper.IsPrime(p) && Helper.IsPrime(q))
                {
                    r = p * q;
                    PhiR = (p - 1) * (q - 1);
                    if (d > 1 && d < PhiR)
                    {
                        if (Helper.GCD(PhiR, d) == 1)
                        {
                            tbRnum.Text = r.ToString();
                            e = GetPublicKey(PhiR, d);
                            tbEnum.Text = e.ToString();
                            SelectFile.Enabled = true;
                            button1.Enabled = true;
                        }
                        else
                            MessageBox.Show($"d должно быть взаимнопростым с (p - 1)(q - 1) = {PhiR}");

                    }
                    else
                        MessageBox.Show($"d должно быть больше 1 и меньше {PhiR}");
                }
                else
                    MessageBox.Show("p и q должны быть простыми числами");
            }
            catch
            {
                MessageBox.Show("p, q и d должны быть числами");
            }
        }
    }
}