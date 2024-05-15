namespace BookStore
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.iconButtonBack = new FontAwesome.Sharp.IconButton();
            this.iconButtonSeller = new FontAwesome.Sharp.IconButton();
            this.iconButtonBuyer = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonBack);
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonSeller);
            this.bunifuGradientPanel1.Controls.Add(this.iconButtonBuyer);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(834, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(369, 700);
            this.bunifuGradientPanel1.TabIndex = 0;
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
            this.iconButtonBack.Location = new System.Drawing.Point(76, 512);
            this.iconButtonBack.Name = "iconButtonBack";
            this.iconButtonBack.Size = new System.Drawing.Size(176, 56);
            this.iconButtonBack.TabIndex = 13;
            this.iconButtonBack.Text = "Back";
            this.iconButtonBack.UseVisualStyleBackColor = false;
            this.iconButtonBack.Click += new System.EventHandler(this.iconButtonBack_Click);
            // 
            // iconButtonSeller
            // 
            this.iconButtonSeller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(138)))), ((int)(((byte)(198)))));
            this.iconButtonSeller.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSeller.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.iconButtonSeller.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonSeller.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonSeller.IconSize = 55;
            this.iconButtonSeller.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSeller.Location = new System.Drawing.Point(17, 402);
            this.iconButtonSeller.Name = "iconButtonSeller";
            this.iconButtonSeller.Size = new System.Drawing.Size(305, 74);
            this.iconButtonSeller.TabIndex = 12;
            this.iconButtonSeller.Text = "Seller";
            this.iconButtonSeller.UseVisualStyleBackColor = false;
            this.iconButtonSeller.Click += new System.EventHandler(this.iconButtonSeller_Click);
            // 
            // iconButtonBuyer
            // 
            this.iconButtonBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(60)))), ((int)(((byte)(198)))));
            this.iconButtonBuyer.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBuyer.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.iconButtonBuyer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButtonBuyer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonBuyer.IconSize = 55;
            this.iconButtonBuyer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonBuyer.Location = new System.Drawing.Point(17, 278);
            this.iconButtonBuyer.Name = "iconButtonBuyer";
            this.iconButtonBuyer.Size = new System.Drawing.Size(305, 74);
            this.iconButtonBuyer.TabIndex = 11;
            this.iconButtonBuyer.Text = "Buyer";
            this.iconButtonBuyer.UseVisualStyleBackColor = false;
            this.iconButtonBuyer.Click += new System.EventHandler(this.iconButtonBuyer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Brown;
            this.pictureBox2.Image = global::BookStore.Properties.Resources.log00012;
            this.pictureBox2.Location = new System.Drawing.Point(185, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(473, 695);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1202, 694);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private FontAwesome.Sharp.IconButton iconButtonBack;
        private FontAwesome.Sharp.IconButton iconButtonSeller;
        private FontAwesome.Sharp.IconButton iconButtonBuyer;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}