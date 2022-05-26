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

        private void DSForm_Load(object sender, EventArgs ev)
        {

        }

        private static BigInteger GetPublicKey(BigInteger a, BigInteger b)
        {
            BigInteger d0 = a;
            BigInteger d1 = b;
            BigInteger x0 = 1;
            BigInteger x1 = 0;
            BigInteger y0 = 0;
            BigInteger y1 = 1;
            BigInteger q;
            BigInteger d2;
            BigInteger x2;
            BigInteger y2;

            while (d1 > 1)
            {
                q = d0 / d1;
                d2 = d0 % d1;
                x2 = x0 - q * x1;
                y2 = y0 - q * y1;
                d0 = d1;
                d1 = d2;
                x0 = x1;
                x1 = x2;
                y0 = y1;
                y1 = y2;
            }
            if (y1 > 0)
                return y1;
            else
                return y1 + a;
        }

        private void btnKeyGen_Click(object sender, EventArgs ev)
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
                            btnFile.Enabled = true;
                            btnFile.Enabled = true;
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

        private static void SaveFile(String file, byte[] bytes, BigInteger sign)
        {
            FileStreamOptions options = new FileStreamOptions();
            options.Access = FileAccess.Write;
            options.Mode = FileMode.Create;
            char[] chars = new char[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                chars[i] = (char)bytes[i];
            }
            using (StreamWriter sw = new StreamWriter(file, options))
            {
                sw.WriteLine(sign.ToString());
                sw.Write(chars);
                sw.Close();
            }
        }

        private void btnFile_Click(object sender, EventArgs ev)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                byte[] defaultText = ReadBytes(openFileDialog.FileName);
                PrintDefaultText(defaultText);
                BigInteger Hash = Helper.GetHash(defaultText, r);
                tbHash.Text = Hash.ToString();
                BigInteger S = BigInteger.ModPow(Hash, d, r);
                tbSignature.Text = S.ToString();
                SaveFile(openFileDialog.FileName, defaultText, S);
            }
        }

        private static byte[] ReadBytes(String file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                fs.Close();
                return bytes;
            }
        }

        private void PrintDefaultText(byte[] bytes)
        {
            rtbText.Text = "";
            foreach (byte b in bytes)
            {
                rtbText.Text += b.ToString() + " ";
            }
        }

        private void rtbText_TextChanged(object sender, EventArgs ev)
        {
            /*tbEnum.Text = "";
            tbRnum.Text = "";
            rtbText.Text = "";
            tbHash.Text = "";
            tbSignature.Text = "";
            btnFile.Enabled = false;
            btnCheck.Enabled = false;*/
        }

        private void btnCheck_Click(object sender, EventArgs ev)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    try
                    {
                        BigInteger signInFile = BigInteger.Parse(sr.ReadLine());
                        BigInteger hashInFile = BigInteger.ModPow(signInFile, e, r);
                        char[] textInFileChars = sr.ReadToEnd().ToCharArray();
                        byte[] textInFile = new byte[textInFileChars.Length];
                        for (int i = 0; i < textInFileChars.Length; i++)
                        {
                            textInFile[i] = (byte)textInFileChars[i];
                        }
                        BigInteger Hash = Helper.GetHash(textInFile, r);
                        if (Hash == hashInFile)
                        {
                            MessageBox.Show($"Подпись верна!\n Хэш файла = {Hash}\n Хэш из файла = {hashInFile}");
                        }
                        else
                        {
                            MessageBox.Show($"Подпись не верна!\n Хэш файла = {Hash}\n Хэш из файла = {hashInFile}");
                        }
                    }
                    catch
                    {
                        MessageBox.Show($"Ошибка при проверке файла");
                    }

                }
            }
        }
    }
}