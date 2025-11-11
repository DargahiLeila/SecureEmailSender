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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmSendEmail)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Normal;
                }
            }
            if (!ExistInMyChildren)
            {
                FrmSendEmail frmsendEmail = new FrmSendEmail();
                frmsendEmail.MdiParent = this;
                frmsendEmail.WindowState = FormWindowState.Normal;
                frmsendEmail.Show();
            }
        }

        private void encryptPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool ExistInMyChildren = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm is FrmEncryptRealPassword)
                {
                    ExistInMyChildren = true;
                    frm.Activate();
                    frm.WindowState = FormWindowState.Normal;
                }
            }
            if (!ExistInMyChildren)
            {
                FrmEncryptRealPassword frmsendEmail = new FrmEncryptRealPassword();
                frmsendEmail.MdiParent = this;
                frmsendEmail.WindowState = FormWindowState.Normal;
                frmsendEmail.Show();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
