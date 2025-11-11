using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using MimeKit;
using MailKit.Net.Smtp;
using System.Configuration;
using SendEmail.Helper;
using System.IO;
using MimeKit.Utils;


namespace SendEmail
{
    public partial class FrmSendEmail : Form
    {
        private List<string> attachedFiles = new List<string>();
        private static int rowIndex = 0;

        public FrmSendEmail()
        {
            InitializeComponent();
        }

      

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txt_From.Text) ||
                    string.IsNullOrWhiteSpace(txt_To.Text) ||
                    string.IsNullOrWhiteSpace(txt_Subject.Text))
                {
                    lblStatus.Text = "❌ Please complete all fields.";
                    lblStatus.ForeColor = Color.Red;
                    return;
                }

                //Create Email Message
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("", txt_From.Text));
                message.To.Add(new MailboxAddress("", txt_To.Text));
                message.Subject = txt_Subject.Text;

                //Build HTML Email Body
                var body = new TextPart("html")
                {
                    Text = $@"
            <div style='direction:rtl; font-family:tahoma; padding:10px;'>
                <p>{rtb_EmailBody.Text}</p>
            </div>"
                };

                // Build a multipart body for attachments
                var multipart = new Multipart("mixed");
                multipart.Add(body);

                // Attach files from the validated list
                foreach (string filePath in attachedFiles)
                {
                    var result = AttachmentValidator.CheckAttachValid(filePath);
                    string mimeType=result.Item2;
                    var attachment = new MimePart(mimeType)
                    {
                        Content = new MimeContent(File.OpenRead(filePath)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        FileName = Path.GetFileName(filePath)
                    };
                    multipart.Add(attachment);
                }

                message.Body = multipart;

                //Connect to SMTP and send email
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    string smtpServer = ConfigurationManager.AppSettings["SmtpServer"];
                    int smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
                    client.Connect(smtpServer, smtpPort, SecureSocketOptions.SslOnConnect);

                    string encryptedPassword = ConfigurationManager.AppSettings["EmailPasswordEecrypt"];
                    string realPassword = CryptoHelper.Decrypt(encryptedPassword);

                    if (string.IsNullOrWhiteSpace(realPassword))
                    {
                        lblStatus.Text = "❌Password decryption failed";
                        lblStatus.ForeColor = Color.Red;
                        return;
                    }

                    client.Authenticate(txt_From.Text, realPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                lblStatus.Text = "✅ Email sent successfully.\t";
                lblStatus.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "❌ Error sending email: " + ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }


        private void FrmSendEmail_Load(object sender, EventArgs e)
        {

            btnAttach.Font = new Font("Segoe MDL2 Assets", 12);
            btnAttach.Text = "\uE16C"; // Attachment icon
            btnAttach.FlatStyle = FlatStyle.Flat;
            btnAttach.FlatAppearance.BorderSize = 0;
            btnAttach.BackColor = Color.Transparent;
            btnAttach.ForeColor = Color.Black; 
            btnAttach.Size = new Size(40, 40); 
            btnAttach.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(btnAttach, "Attach File");

        }



        private void btnAttach_Click(object sender, EventArgs e)
        {
            dataGridView_AttachFile.AllowUserToAddRows = false;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                ofd.Title = "Select file(s) to attach";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    var result = AttachmentValidator.CheckAttachValid(filePath);
                    bool allowedAttach = result.Item1;
                    if (!allowedAttach)
                    {
                        MessageBox.Show("❌ This file type is not permitted for attachment.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Check for duplicate file
                    if (attachedFiles.Contains(filePath))
                    {
                        MessageBox.Show("⚠️ This file is already attached.", "Duplicate file ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Add Valid File To Grid And Static List
                    int rowIndex = dataGridView_AttachFile.Rows.Count + 1;
                    dataGridView_AttachFile.Rows.Add(rowIndex, Path.GetFileName(filePath));
                    attachedFiles.Add(filePath);
                }
            }
        }

        private void dataGridView_AttachFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView_AttachFile.Columns["clmnDelete"].Index && e.RowIndex >= 0)
            {
                string fileName = dataGridView_AttachFile.Rows[e.RowIndex].Cells["clmnFileName"].Value.ToString();

                // Remove File Of Static List
                string fullPath = attachedFiles.FirstOrDefault(f => Path.GetFileName(f) == fileName);
                if (fullPath != null)
                    attachedFiles.Remove(fullPath);

                // Remove File Of Grid
                dataGridView_AttachFile.Rows.RemoveAt(e.RowIndex);

                // Update row numbers
                for (int i = 0; i < dataGridView_AttachFile.Rows.Count; i++)
                {
                    dataGridView_AttachFile.Rows[i].Cells["clmnRow"].Value = i + 1;
                }
            }

        }
    }
}
    

