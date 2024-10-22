using System.Collections.Generic;
using System;
using System.Linq;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace OOP_ContactLMS
{
    partial class ViewContactsControl : UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewContactsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.totalContacts = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactLMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactLMSDataSet = new OOP_ContactLMS.ContactLMSDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.contactsTableAdapter = new OOP_ContactLMS.ContactLMSDataSetTableAdapters.ContactsTableAdapter();
            this.contactsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopePictureBox2 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopePictureBox3 = new ReaLTaiizor.Controls.HopePictureBox();
            this.foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel3 = new ReaLTaiizor.Controls.FoxLabel();
            this.foxLabel4 = new ReaLTaiizor.Controls.FoxLabel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.foxLabel4);
            this.panel1.Controls.Add(this.foxLabel3);
            this.panel1.Controls.Add(this.foxLabel2);
            this.panel1.Controls.Add(this.hopePictureBox3);
            this.panel1.Controls.Add(this.hopePictureBox2);
            this.panel1.Controls.Add(this.hopePictureBox1);
            this.panel1.Controls.Add(this.foxLabel1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(13, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 183);
            this.panel1.TabIndex = 0;
            // 
            // foxLabel1
            // 
            this.foxLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foxLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel1.Location = new System.Drawing.Point(414, 21);
            this.foxLabel1.Name = "foxLabel1";
            this.foxLabel1.Size = new System.Drawing.Size(237, 19);
            this.foxLabel1.TabIndex = 2;
            this.foxLabel1.Text = "Meet The Project Contributors";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Controls.Add(this.totalContacts);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(37, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 137);
            this.panel5.TabIndex = 1;
            // 
            // totalContacts
            // 
            this.totalContacts.AutoSize = true;
            this.totalContacts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalContacts.ForeColor = System.Drawing.Color.White;
            this.totalContacts.Location = new System.Drawing.Point(161, 69);
            this.totalContacts.Name = "totalContacts";
            this.totalContacts.Size = new System.Drawing.Size(18, 19);
            this.totalContacts.TabIndex = 5;
            this.totalContacts.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Contacts";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 331);
            this.panel2.TabIndex = 1;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(350, 244);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(84, 36);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "REFRESH";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactsBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(705, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // contactIDDataGridViewTextBoxColumn
            // 
            this.contactIDDataGridViewTextBoxColumn.DataPropertyName = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.HeaderText = "ContactID";
            this.contactIDDataGridViewTextBoxColumn.Name = "contactIDDataGridViewTextBoxColumn";
            this.contactIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataMember = "Contacts";
            this.contactsBindingSource.DataSource = this.contactLMSDataSetBindingSource;
            // 
            // contactLMSDataSetBindingSource
            // 
            this.contactLMSDataSetBindingSource.DataSource = this.contactLMSDataSet;
            this.contactLMSDataSetBindingSource.Position = 0;
            // 
            // contactLMSDataSet
            // 
            this.contactLMSDataSet.DataSetName = "ContactLMSDataSet";
            this.contactLMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(346, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact List";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(477, 222);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(78, 36);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.Text = "SEARCH";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bigTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(204, 221);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(244, 41);
            this.bigTextBox1.TabIndex = 5;
            this.bigTextBox1.Text = "Enter Contact No.";
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            this.bigTextBox1.TextChanged += new System.EventHandler(this.bigTextBox1_TextChanged);
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // contactsBindingSource1
            // 
            this.contactsBindingSource1.DataMember = "Contacts";
            this.contactsBindingSource1.DataSource = this.contactLMSDataSetBindingSource;
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(316, 55);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(118, 103);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 3;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox2
            // 
            this.hopePictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox2.Image")));
            this.hopePictureBox2.Location = new System.Drawing.Point(475, 55);
            this.hopePictureBox2.Name = "hopePictureBox2";
            this.hopePictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox2.Size = new System.Drawing.Size(118, 103);
            this.hopePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hopePictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox2.TabIndex = 4;
            this.hopePictureBox2.TabStop = false;
            this.hopePictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopePictureBox3
            // 
            this.hopePictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox3.Image")));
            this.hopePictureBox3.Location = new System.Drawing.Point(640, 55);
            this.hopePictureBox3.Name = "hopePictureBox3";
            this.hopePictureBox3.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox3.Size = new System.Drawing.Size(118, 103);
            this.hopePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hopePictureBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox3.TabIndex = 5;
            this.hopePictureBox3.TabStop = false;
            this.hopePictureBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // foxLabel2
            // 
            this.foxLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel2.Location = new System.Drawing.Point(350, 139);
            this.foxLabel2.Name = "foxLabel2";
            this.foxLabel2.Size = new System.Drawing.Size(52, 19);
            this.foxLabel2.TabIndex = 6;
            this.foxLabel2.Text = "CABICO";
            // 
            // foxLabel3
            // 
            this.foxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel3.Location = new System.Drawing.Point(498, 139);
            this.foxLabel3.Name = "foxLabel3";
            this.foxLabel3.Size = new System.Drawing.Size(65, 19);
            this.foxLabel3.TabIndex = 7;
            this.foxLabel3.Text = "POSADAS";
            // 
            // foxLabel4
            // 
            this.foxLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foxLabel4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.foxLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(100)))));
            this.foxLabel4.Location = new System.Drawing.Point(661, 139);
            this.foxLabel4.Name = "foxLabel4";
            this.foxLabel4.Size = new System.Drawing.Size(70, 19);
            this.foxLabel4.TabIndex = 8;
            this.foxLabel4.Text = "SABUCIDO";
            // 
            // ViewContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bigTextBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewContactsControl";
            this.Size = new System.Drawing.Size(838, 624);
            this.Load += new System.EventHandler(this.ViewContactsControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label totalContacts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;

        // List to hold contacts
        private List<Contact> contacts = new List<Contact>();


        // Add a new contact when the button is clicked
        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Placeholder logic to add a new contact (this could be more complex with input validation)
            string searchText = bigTextBox1.Text;

            // For now, perform search (this can be customized)
            var filteredContacts = contacts.Where(c => c.Phone.Contains(searchText) || c.FirstName.Contains(searchText) || c.LastName.Contains(searchText)).ToList();

            if (filteredContacts.Any())
            {
                // Bind filtered contacts to DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filteredContacts;
            }
            else
            {
                // Optionally display message if no contacts are found
                MessageBox.Show("No contacts found with the given information.");
            }
        }

        // Method to refresh the DataGridView with the updated contact list
        private void RefreshContactGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contacts;

            // Update total contacts label
            totalContacts.Text = contacts.Count.ToString();
        }


        private BindingSource contactLMSDataSetBindingSource;
        private ContactLMSDataSet contactLMSDataSet;
        private DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource contactsBindingSource;
        private ContactLMSDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;
        private BindingSource contactsBindingSource1;
        private MaterialButton materialButton2;
        private FoxLabel foxLabel1;
        private HopePictureBox hopePictureBox3;
        private HopePictureBox hopePictureBox2;
        private HopePictureBox hopePictureBox1;
        private FoxLabel foxLabel4;
        private FoxLabel foxLabel3;
        private FoxLabel foxLabel2;

        // Example contact class to hold the contact information (replace this with your actual data structure)
        public class Contact
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; } // Added address field
            public string CompanyName { get; set; } // Added company name field
        }
    }
}

