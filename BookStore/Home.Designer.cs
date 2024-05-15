namespace BookStore
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.iconButtonLogIn = new FontAwesome.Sharp.IconButton();
            this.labelDontHave = new System.Windows.Forms.Label();
            this.iconButtonCreateAccount = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(181, 131);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(187, 114);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "   Welcome \r\n     To The \r\n  BookStore";
            // 
            // iconButtonLogIn
            // 
            this.iconButtonLogIn.BackColor = System.Drawing.Color.Green;
            this.iconButtonLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonLogIn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogIn.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButtonLogIn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonLogIn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonLogIn.IconSize = 55;
            this.iconButtonLogIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonLogIn.Location = new System.Drawing.Point(126, 436);
            this.iconButtonLogIn.Name = "iconButtonLogIn";
            this.iconButtonLogIn.Size = new System.Drawing.Size(305, 74);
            this.iconButtonLogIn.TabIndex = 26;
            this.iconButtonLogIn.Text = "Log In";
            this.iconButtonLogIn.UseVisualStyleBackColor = false;
            this.iconButtonLogIn.Click += new System.EventHandler(this.iconButtonLogIn_Click);
            // 
            // labelDontHave
            // 
            this.labelDontHave.AutoSize = true;
            this.labelDontHave.BackColor = System.Drawing.Color.Transparent;
            this.labelDontHave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontHave.Location = new System.Drawing.Point(185, 535);
            this.labelDontHave.Name = "labelDontHave";
            this.labelDontHave.Size = new System.Drawing.Size(160, 19);
            this.labelDontHave.TabIndex = 27;
            this.labelDontHave.Text = "Dont have an account?";
            // 
            // iconButtonCreateAccount
            // 
            this.iconButtonCreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconButtonCreateAccount.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateAccount.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonCreateAccount.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonCreateAccount.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonCreateAccount.IconSize = 55;
            this.iconButtonCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreateAccount.Location = new System.Drawing.Point(28, 560);
            this.iconButtonCreateAccount.Name = "iconButtonCreateAccount";
            this.iconButtonCreateAccount.Size = new System.Drawing.Size(475, 74);
            this.iconButtonCreateAccount.TabIndex = 28;
            this.iconButtonCreateAccount.Text = "Create New Account";
            this.iconButtonCreateAccount.UseVisualStyleBackColor = false;
            this.iconButtonCreateAccount.Click += new System.EventHandler(this.iconButtonCreateAccount_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonCreateAccount);
            this.bunifuGradientPanel1.Controls.Add(this.labelDontHave);
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonLogIn);
            this.bunifuGradientPanel1.Controls.Add(this.labelWelcome);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.LightCoral;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSalmon;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.LightGoldenrodYellow;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(656, 1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(524, 695);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Image = global::BookStore.Properties.Resources.log00012;
            this.pictureBox2.Location = new System.Drawing.Point(91, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 695);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private FontAwesome.Sharp.IconButton iconButtonLogIn;
        private System.Windows.Forms.Label labelDontHave;
        private FontAwesome.Sharp.IconButton iconButtonCreateAccount;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}