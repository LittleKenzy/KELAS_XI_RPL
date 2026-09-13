namespace SMKNusantaraApp
{
    partial class form
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
            usernameTxt = new TextBox();
            label1 = new Label();
            passwordTxt = new TextBox();
            label2 = new Label();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // usernameTxt
            // 
            usernameTxt.Location = new Point(44, 76);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(100, 23);
            usernameTxt.TabIndex = 0;
            usernameTxt.TextChanged += usernameTxt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 58);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(44, 138);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(100, 23);
            passwordTxt.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 120);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(44, 180);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passwordTxt);
            Controls.Add(label1);
            Controls.Add(usernameTxt);
            Name = "form";
            Text = "Form1";
            Load += form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTxt;
        private Label label1;
        private TextBox passwordTxt;
        private Label label2;
        private Button loginBtn;
    }
}
