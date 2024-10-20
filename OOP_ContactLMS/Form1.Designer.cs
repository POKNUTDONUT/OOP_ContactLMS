using System.Windows.Forms;

namespace OOP_ContactLMS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            this.parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotFormEllipse1
            // 
            this.parrotFormEllipse1.CornerRadius = 10;
            this.parrotFormEllipse1.EffectedForm = this;
            // 
            // parrotFormHandle1
            // 
            this.parrotFormHandle1.DockAtTop = true;
            this.parrotFormHandle1.HandleControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 37);
            this.panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = false;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(390, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 6;
            // 
            // parrotFormHandle2
            // 
            this.parrotFormHandle2.DockAtTop = true;
            this.parrotFormHandle2.HandleControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.bigLabel1);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.hopeTextBox2);
            this.panel2.Controls.Add(this.hopePictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 524);
            this.panel2.TabIndex = 1;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bigLabel1.Location = new System.Drawing.Point(212, 265);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(109, 45);
            this.bigLabel1.TabIndex = 21;
            this.bigLabel1.Text = "CLMS";
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(199, 436);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(108, 36);
            this.materialButton1.TabIndex = 20;
            this.materialButton1.Text = "Sign In";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // hopeTextBox2
            // 
            this.hopeTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            this.hopeTextBox2.BaseColor = System.Drawing.Color.Transparent;
            this.hopeTextBox2.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.hopeTextBox2.BorderColorB = System.Drawing.Color.DarkGray;
            this.hopeTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.hopeTextBox2.Hint = "";
            this.hopeTextBox2.Location = new System.Drawing.Point(76, 341);
            this.hopeTextBox2.MaxLength = 128;
            this.hopeTextBox2.Multiline = false;
            this.hopeTextBox2.Name = "hopeTextBox2";
            this.hopeTextBox2.PasswordChar = '\0';
            this.hopeTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox2.SelectedText = "";
            this.hopeTextBox2.SelectionLength = 0;
            this.hopeTextBox2.SelectionStart = 0;
            this.hopeTextBox2.Size = new System.Drawing.Size(370, 38);
            this.hopeTextBox2.TabIndex = 8;
            this.hopeTextBox2.TabStop = false;
            this.hopeTextBox2.Text = "Contact Number";
            this.hopeTextBox2.UseSystemPasswordChar = false;
            this.hopeTextBox2.Click += new System.EventHandler(this.hopeTextBox2_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hopePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hopePictureBox1.Enabled = false;
            this.hopePictureBox1.ErrorImage = null;
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.InitialImage = null;
            this.hopePictureBox1.Location = new System.Drawing.Point(111, 43);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(314, 219);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 0;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(529, 524);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.ParrotFormEllipse parrotFormEllipse1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}