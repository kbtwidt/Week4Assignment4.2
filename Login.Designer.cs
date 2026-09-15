namespace Week4Assignment4._2
{
    partial class Login
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
            lblHeader = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(165, 34);
            lblHeader.Margin = new Padding(8, 0, 8, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(621, 45);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Teacher Administration Login";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Lucida Fax", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(17, 129);
            lblUserName.Margin = new Padding(8, 0, 8, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(188, 34);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Lucida Fax", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(25, 187);
            lblPassword.Margin = new Padding(8, 0, 8, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(168, 34);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(243, 110);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(389, 55);
            txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(389, 55);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(402, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(25F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 306);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(lblHeader);
            Font = new Font("Lucida Fax", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8, 6, 8, 6);
            Name = "Login";
            Text = "Teacher Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}
