namespace WinClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMessageHistory = new TextBox();
            txtNick = new TextBox();
            label1 = new Label();
            btnSignIn = new Button();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtMessageHistory
            // 
            txtMessageHistory.Location = new Point(1, 41);
            txtMessageHistory.Multiline = true;
            txtMessageHistory.Name = "txtMessageHistory";
            txtMessageHistory.ReadOnly = true;
            txtMessageHistory.ScrollBars = ScrollBars.Vertical;
            txtMessageHistory.Size = new Size(307, 309);
            txtMessageHistory.TabIndex = 0;
            // 
            // txtNick
            // 
            txtNick.Location = new Point(49, 12);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(178, 23);
            txtNick.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Nick";
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(233, 11);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 3;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(12, 356);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(215, 23);
            txtMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Enabled = false;
            btnSend.Location = new Point(233, 355);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 388);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(btnSignIn);
            Controls.Add(label1);
            Controls.Add(txtNick);
            Controls.Add(txtMessageHistory);
            Name = "Form1";
            Text = "Chat Client";
            FormClosing += Form_Closing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
        }

        #endregion

        private TextBox txtMessageHistory;
        private TextBox txtNick;
        private Label label1;
        private Button btnSignIn;
        private TextBox txtMessage;
        private Button btnSend;


        }
}
