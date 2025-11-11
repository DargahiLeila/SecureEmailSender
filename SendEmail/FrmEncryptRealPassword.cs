using SendEmail.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendEmail
{
    public partial class FrmEncryptRealPassword : Form
    {
        public FrmEncryptRealPassword()
        {
            InitializeComponent();
        }

      
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string RealPass=txtRealPassword.Text.Trim();
            string EncryptedPass = CryptoHelper.Encrypt(RealPass);
            txtEncryptedPassword.Text = EncryptedPass;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string DecryptPassword = CryptoHelper.Decrypt(txtEncryptedPassword.Text.Trim());
            txtDecryptedPassword.Text = DecryptPassword;
        }
    }
}
