namespace BookStore
{
    partial class Give_Review
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Give_Review));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnback = new FontAwesome.Sharp.IconButton();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.Textboxcomments = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxuid = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUID = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnback);
            this.bunifuGradientPanel1.Controls.Add(this.btnsubmit);
            this.bunifuGradientPanel1.Controls.Add(this.Textboxcomments);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.textboxname);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.textboxuid);
            this.bunifuGradientPanel1.Controls.Add(this.labelUID);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.OrangeRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(759, 721);
            this.bunifuGradientPanel1.TabIndex = 48;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.SlateGray;
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.IconChar = FontAwesome.Sharp.IconChar.CircleChevronLeft;
            this.btnback.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnback.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnback.IconSize = 40;
            this.btnback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnback.Location = new System.Drawing.Point(52, 590);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(106, 75);
            this.btnback.TabIndex = 49;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsubmit.Image = global::BookStore.Properties.Resources.upload;
            this.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubmit.Location = new System.Drawing.Point(407, 591);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(304, 75);
            this.btnsubmit.TabIndex = 10;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // Textboxcomments
            // 
            this.Textboxcomments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textboxcomments.DefaultText = "";
            this.Textboxcomments.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Textboxcomments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Textboxcomments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textboxcomments.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Textboxcomments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textboxcomments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Textboxcomments.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Textboxcomments.Location = new System.Drawing.Point(249, 212);
            this.Textboxcomments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Textboxcomments.Name = "Textboxcomments";
            this.Textboxcomments.PasswordChar = '\0';
            this.Textboxcomments.PlaceholderText = "";
            this.Textboxcomments.SelectedText = "";
            this.Textboxcomments.Size = new System.Drawing.Size(462, 313);
            this.Textboxcomments.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comments";
            // 
            // textboxname
            // 
            this.textboxname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxname.DefaultText = "";
            this.textboxname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxname.Location = new System.Drawing.Point(249, 120);
            this.textboxname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxname.Name = "textboxname";
            this.textboxname.PasswordChar = '\0';
            this.textboxname.PlaceholderText = "";
            this.textboxname.SelectedText = "";
            this.textboxname.Size = new System.Drawing.Size(211, 38);
            this.textboxname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // textboxuid
            // 
            this.textboxuid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxuid.DefaultText = "";
            this.textboxuid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textboxuid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textboxuid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxuid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textboxuid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxuid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textboxuid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textboxuid.Location = new System.Drawing.Point(249, 50);
            this.textboxuid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxuid.Name = "textboxuid";
            this.textboxuid.PasswordChar = '\0';
            this.textboxuid.PlaceholderText = "";
            this.textboxuid.SelectedText = "";
            this.textboxuid.Size = new System.Drawing.Size(211, 38);
            this.textboxuid.TabIndex = 5;
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.BackColor = System.Drawing.Color.Transparent;
            this.labelUID.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUID.Location = new System.Drawing.Point(64, 41);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(123, 38);
            this.labelUID.TabIndex = 4;
            this.labelUID.Text = "UserID";
            this.labelUID.Click += new System.EventHandler(this.labelUID_Click);
            // 
            // Give_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 721);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "Give_Review";
            this.Text = "Give_Review";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textboxuid;
        private System.Windows.Forms.Label labelUID;
        private System.Windows.Forms.Button btnsubmit;
        private Guna.UI2.WinForms.Guna2TextBox Textboxcomments;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textboxname;
        private FontAwesome.Sharp.IconButton btnback;
    }
}