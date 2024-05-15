namespace BookStore
{
    partial class ForgetPassword
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
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.button_sendCode = new System.Windows.Forms.Button();
            this.textBox_gmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_vrificationCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_confirmPass = new System.Windows.Forms.TextBox();
            this.textBox_newPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButtonBack
            // 
            this.iconButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.iconButtonBack.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBack.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.iconButtonBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonBack.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonBack.IconSize = 40;
            this.iconButtonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBack.Location = new System.Drawing.Point(580, 298);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(158, 56);
            this.iconButtonBack.TabIndex = 20;
            this.iconButtonBack.Text = "Back";
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // button_sendCode
            // 
            this.button_sendCode.BackColor = System.Drawing.Color.Yellow;
            this.button_sendCode.Location = new System.Drawing.Point(130, 298);
            this.button_sendCode.Name = "button_sendCode";
            this.button_sendCode.Size = new System.Drawing.Size(130, 41);
            this.button_sendCode.TabIndex = 31;
            this.button_sendCode.Text = "Send Code";
            this.button_sendCode.UseVisualStyleBackColor = false;
            this.button_sendCode.Click += new System.EventHandler(this.button_sendCode_Click);
            // 
            // textBox_gmail
            // 
            this.textBox_gmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_gmail.Location = new System.Drawing.Point(218, 87);
            this.textBox_gmail.Multiline = true;
            this.textBox_gmail.Name = "textBox_gmail";
            this.textBox_gmail.Size = new System.Drawing.Size(283, 29);
            this.textBox_gmail.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gmail";
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Yellow;
            this.button_confirm.Location = new System.Drawing.Point(302, 298);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(130, 41);
            this.button_confirm.TabIndex = 27;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_vrificationCode
            // 
            this.textBox_vrificationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_vrificationCode.Location = new System.Drawing.Point(218, 138);
            this.textBox_vrificationCode.Multiline = true;
            this.textBox_vrificationCode.Name = "textBox_vrificationCode";
            this.textBox_vrificationCode.Size = new System.Drawing.Size(283, 24);
            this.textBox_vrificationCode.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Varification";
            // 
            // textBox_confirmPass
            // 
            this.textBox_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_confirmPass.Location = new System.Drawing.Point(218, 242);
            this.textBox_confirmPass.Multiline = true;
            this.textBox_confirmPass.Name = "textBox_confirmPass";
            this.textBox_confirmPass.Size = new System.Drawing.Size(283, 32);
            this.textBox_confirmPass.TabIndex = 24;
            // 
            // textBox_newPass
            // 
            this.textBox_newPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_newPass.Location = new System.Drawing.Point(218, 189);
            this.textBox_newPass.Multiline = true;
            this.textBox_newPass.Name = "textBox_newPass";
            this.textBox_newPass.Size = new System.Drawing.Size(283, 35);
            this.textBox_newPass.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "New Password";
            // 
            // ForgetPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_sendCode);
            this.Controls.Add(this.textBox_gmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_vrificationCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_confirmPass);
            this.Controls.Add(this.textBox_newPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButtonBack);
            this.Name = "ForgetPassword";
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonBack;
        private System.Windows.Forms.Button button_sendCode;
        private System.Windows.Forms.TextBox textBox_gmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_vrificationCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_confirmPass;
        private System.Windows.Forms.TextBox textBox_newPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}