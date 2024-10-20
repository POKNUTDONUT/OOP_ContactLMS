using System.Windows.Forms;

namespace OOP_ContactLMS
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.parrotFormEllipse1 = new ReaLTaiizor.Controls.ParrotFormEllipse();
            this.parrotFormHandle1 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.parrotFormHandle2 = new ReaLTaiizor.Controls.ParrotFormHandle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.radioButton1 = new ReaLTaiizor.Controls.RadioButton();
            this.dreamButton1 = new ReaLTaiizor.Controls.DreamButton();
            this.skyButton1 = new ReaLTaiizor.Controls.SkyButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).BeginInit();
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
            this.panel1.Controls.Add(this.headerLabel1);
            this.panel1.Controls.Add(this.hopePictureBox2);
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 37);
            this.panel1.TabIndex = 0;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel1.ForeColor = System.Drawing.Color.Black;
            this.headerLabel1.Location = new System.Drawing.Point(45, 9);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(253, 18);
            this.headerLabel1.TabIndex = 29;
            this.headerLabel1.Text = "Contact List Management Studio";
            // 
            // hopePictureBox2
            // 
            this.hopePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox2.Image")));
            this.hopePictureBox2.Location = new System.Drawing.Point(12, 4);
            this.hopePictureBox2.Name = "hopePictureBox2";
            this.hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox2.Size = new System.Drawing.Size(27, 28);
            this.hopePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox2.TabIndex = 7;
            this.hopePictureBox2.TabStop = false;
            this.hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            this.nightControlBox1.Location = new System.Drawing.Point(950, 0);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.dreamButton1);
            this.panel2.Controls.Add(this.skyButton1);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.hopePictureBox1);
            this.panel2.Controls.Add(this.bigLabel1);
            this.panel2.Controls.Add(this.hopeTextBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 681);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(25, 629);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(201, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "LOGOUT";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = false;
            this.radioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.radioButton1.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.radioButton1.Location = new System.Drawing.Point(-15, -15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 17);
            this.radioButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.radioButton1.TabIndex = 27;
            this.radioButton1.Text = "radioButton1";
            // 
            // dreamButton1
            // 
            this.dreamButton1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dreamButton1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.dreamButton1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dreamButton1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dreamButton1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dreamButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dreamButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.dreamButton1.Location = new System.Drawing.Point(-15, -15);
            this.dreamButton1.Name = "dreamButton1";
            this.dreamButton1.Size = new System.Drawing.Size(120, 40);
            this.dreamButton1.TabIndex = 26;
            this.dreamButton1.Text = "dreamButton1";
            this.dreamButton1.UseVisualStyleBackColor = true;
            // 
            // skyButton1
            // 
            this.skyButton1.BackColor = System.Drawing.Color.Transparent;
            this.skyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skyButton1.DownBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.skyButton1.DownBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.skyButton1.DownBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.skyButton1.DownBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.skyButton1.DownBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.skyButton1.DownBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.skyButton1.DownForeColor = System.Drawing.Color.White;
            this.skyButton1.DownShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold);
            this.skyButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyButton1.HoverBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(153)))), ((int)(((byte)(205)))));
            this.skyButton1.HoverBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(124)))), ((int)(((byte)(170)))));
            this.skyButton1.HoverBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(168)))), ((int)(((byte)(221)))));
            this.skyButton1.HoverBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(149)))), ((int)(((byte)(194)))));
            this.skyButton1.HoverBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(93)))), ((int)(((byte)(131)))));
            this.skyButton1.HoverBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(25)))), ((int)(((byte)(73)))), ((int)(((byte)(109)))));
            this.skyButton1.HoverForeColor = System.Drawing.Color.White;
            this.skyButton1.HoverShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.skyButton1.Location = new System.Drawing.Point(-15, -15);
            this.skyButton1.Name = "skyButton1";
            this.skyButton1.NormalBGColorA = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.skyButton1.NormalBGColorB = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.skyButton1.NormalBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.skyButton1.NormalBorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.skyButton1.NormalBorderColorC = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.skyButton1.NormalBorderColorD = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.skyButton1.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(137)))));
            this.skyButton1.NormalShadowForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skyButton1.Size = new System.Drawing.Size(75, 23);
            this.skyButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.skyButton1.TabIndex = 25;
            this.skyButton1.Text = "skyButton1";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(25, 397);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(201, 42);
            this.materialButton2.TabIndex = 24;
            this.materialButton2.Text = "MODIFY CONTACTS";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(25, 332);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(201, 40);
            this.materialButton1.TabIndex = 23;
            this.materialButton1.Text = "VIEW CONTACTS";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(25, 43);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(208, 156);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 22;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.bigLabel1.Location = new System.Drawing.Point(78, 202);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(109, 45);
            this.bigLabel1.TabIndex = 21;
            this.bigLabel1.Text = "CLMS";
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
            this.hopeTextBox2.Location = new System.Drawing.Point(76, 417);
            this.hopeTextBox2.MaxLength = 128;
            this.hopeTextBox2.Multiline = false;
            this.hopeTextBox2.Name = "hopeTextBox2";
            this.hopeTextBox2.PasswordChar = '\0';
            this.hopeTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox2.SelectedText = "";
            this.hopeTextBox2.SelectionLength = 0;
            this.hopeTextBox2.SelectionStart = 0;
            this.hopeTextBox2.Size = new System.Drawing.Size(0, 38);
            this.hopeTextBox2.TabIndex = 8;
            this.hopeTextBox2.TabStop = false;
            this.hopeTextBox2.Text = "Contact Number";
            this.hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 1;
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(261, 43);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(814, 626);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1087, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).EndInit();
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
        private ReaLTaiizor.Controls.ParrotFormHandle parrotFormHandle2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private ReaLTaiizor.Controls.RadioButton radioButton1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox2;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
    }
}