namespace SendEmail
{
    partial class FrmSendEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_EmailBody = new System.Windows.Forms.RichTextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView_AttachFile = new System.Windows.Forms.DataGridView();
            this.clmnRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AttachFile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(105, 12);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(499, 20);
            this.txt_From.TabIndex = 1;
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(105, 48);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(499, 20);
            this.txt_To.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(105, 78);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(499, 20);
            this.txt_Subject.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject:";
            // 
            // rtb_EmailBody
            // 
            this.rtb_EmailBody.Location = new System.Drawing.Point(105, 104);
            this.rtb_EmailBody.Name = "rtb_EmailBody";
            this.rtb_EmailBody.Size = new System.Drawing.Size(499, 86);
            this.rtb_EmailBody.TabIndex = 6;
            this.rtb_EmailBody.Text = "";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(105, 258);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 7;
            this.Btn_Send.Text = "Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(127, 310);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 8;
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(105, 217);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 9;
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // dataGridView_AttachFile
            // 
            this.dataGridView_AttachFile.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_AttachFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AttachFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnRow,
            this.clmnFileName,
            this.clmnDelete});
            this.dataGridView_AttachFile.Location = new System.Drawing.Point(309, 217);
            this.dataGridView_AttachFile.Name = "dataGridView_AttachFile";
            this.dataGridView_AttachFile.Size = new System.Drawing.Size(295, 134);
            this.dataGridView_AttachFile.TabIndex = 10;
            this.dataGridView_AttachFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AttachFile_CellContentClick);
            // 
            // clmnRow
            // 
            this.clmnRow.HeaderText = "Row";
            this.clmnRow.Name = "clmnRow";
            this.clmnRow.Width = 50;
            // 
            // clmnFileName
            // 
            this.clmnFileName.HeaderText = "FileName";
            this.clmnFileName.Name = "clmnFileName";
            this.clmnFileName.Width = 150;
            // 
            // clmnDelete
            // 
            this.clmnDelete.HeaderText = "Delete";
            this.clmnDelete.Name = "clmnDelete";
            this.clmnDelete.Text = "-";
            this.clmnDelete.Width = 50;
            // 
            // FrmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 395);
            this.Controls.Add(this.dataGridView_AttachFile);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.rtb_EmailBody);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.label1);
            this.Name = "FrmSendEmail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSendEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AttachFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_EmailBody;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView_AttachFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnFileName;
        private System.Windows.Forms.DataGridViewButtonColumn clmnDelete;
    }
}

