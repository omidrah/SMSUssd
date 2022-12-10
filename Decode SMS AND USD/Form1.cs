using System.Text;

namespace Decode_SMS_AND_USD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (rbSms.Checked)
            {
                if (!string.IsNullOrEmpty(txtSMS.Text))
                {
                    string res = string.Empty;
                    var splitor = new string[] { "+CMGL" };
                    var dd = txtSMS.Text.Split(splitor, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in dd)
                    {
                        if (item.Contains(","))
                        {
                            res += decoce(item);
                        }
                    }
                    lbxRes.Items.Add(res);
                    lbxRes.Items.Add("*****************");
                }
            }
            else //rbUssd.Checked
            {
                if (!string.IsNullOrEmpty(txtSMS.Text))
                {
                    string res = string.Empty;
                    var splitor = new string[] { "," };
                    var dd = txtSMS.Text.Split(splitor, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in dd)
                    {
                        if (item.Length> 10)
                        {
                            res += decoce(item);
                        }
                    }
                    lbxRes.Items.Add(res);
                    lbxRes.Items.Add("*****************");
                }
            }

          
        }

        public  string decoce(string str)
        {
            var strHexSplt = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var strHex = strHexSplt[strHexSplt.Length - 1]; //msg body
            int nNumberChars = strHex.Length / 2;
            byte[] aBytes = new byte[nNumberChars];
            using (var sr = new StringReader(strHex))
            {
                /*
                 دو رقم دو رقم ،اعداد راخوانده و به هگز کانورت می کنیم
                 */
                for (int i = 0; i < nNumberChars; i++)
                    aBytes[i] = Convert.ToByte(
                                new String(new char[2] {
                            (char)sr.Read(), (char)sr.Read() }), 16);
            }
            if (rbBigEndianUnicode.Checked)
            {
                return Encoding.BigEndianUnicode.GetString(aBytes, 0, aBytes.Length); ;
            }
            else if (rbAscii.Checked)
            {
                return Encoding.ASCII.GetString(aBytes, 0, aBytes.Length); ;
            }
            else if (rbUnicode.Checked)
            {
                return Encoding.Unicode.GetString(aBytes, 0, aBytes.Length); ;
            }
            else if (rbUTF8.Checked)
            {
                return Encoding.UTF8.GetString(aBytes, 0, aBytes.Length);
            }
            else
                return Encoding.Default.GetString(aBytes, 0, aBytes.Length);
        }
    }
}