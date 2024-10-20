namespace OOP_ContactLMS
{
    partial class AddContactsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialButton4 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton3 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton2 = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.companyName = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contact_dataGrid = new System.Windows.Forms.DataGridView();
            this.contactIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactLMSDataSet = new OOP_ContactLMS.ContactLMSDataSet();
            this.contactsTableAdapter = new OOP_ContactLMS.ContactLMSDataSetTableAdapters.ContactsTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.materialButton4);
            this.panel2.Controls.Add(this.materialButton3);
            this.panel2.Controls.Add(this.materialButton2);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.labelFirstName);
            this.panel2.Controls.Add(this.firstName);
            this.panel2.Controls.Add(this.labelLastName);
            this.panel2.Controls.Add(this.lastName);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.phoneNumber);
            this.panel2.Controls.Add(this.companyName);
            this.panel2.Controls.Add(this.labelAddress);
            this.panel2.Controls.Add(this.address);
            this.panel2.Controls.Add(this.labelPhoneNumber);
            this.panel2.Controls.Add(this.labelCompanyName);
            this.panel2.Location = new System.Drawing.Point(12, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 233);
            this.panel2.TabIndex = 3;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton4.Location = new System.Drawing.Point(546, 179);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(73, 36);
            this.materialButton4.TabIndex = 21;
            this.materialButton4.Text = "DELETE";
            this.materialButton4.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton3.Location = new System.Drawing.Point(425, 179);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(66, 36);
            this.materialButton3.TabIndex = 20;
            this.materialButton3.Text = "CLEAR";
            this.materialButton3.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton2.Location = new System.Drawing.Point(293, 179);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(77, 36);
            this.materialButton2.TabIndex = 19;
            this.materialButton2.Text = "UPDATE";
            this.materialButton2.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(181, 179);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 18;
            this.materialButton1.Text = "ADD";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(45, 17);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(122, 17);
            this.firstName.Multiline = true;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(200, 25);
            this.firstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(422, 20);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(504, 17);
            this.lastName.Multiline = true;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(200, 25);
            this.lastName.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(70, 60);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(122, 57);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 25);
            this.email.TabIndex = 5;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(504, 57);
            this.phoneNumber.Multiline = true;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(200, 25);
            this.phoneNumber.TabIndex = 7;
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(122, 97);
            this.companyName.Multiline = true;
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(200, 25);
            this.companyName.TabIndex = 9;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(435, 109);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(504, 97);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 60);
            this.address.TabIndex = 11;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.labelPhoneNumber.Location = new System.Drawing.Point(402, 60);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 6;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.ForeColor = System.Drawing.Color.Black;
            this.labelCompanyName.Location = new System.Drawing.Point(20, 100);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 8;
            this.labelCompanyName.Text = "Company Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.contact_dataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 310);
            this.panel1.TabIndex = 2;
            // 
            // contact_dataGrid
            // 
            this.contact_dataGrid.AllowUserToAddRows = false;
            this.contact_dataGrid.AllowUserToDeleteRows = false;
            this.contact_dataGrid.AllowUserToResizeColumns = false;
            this.contact_dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.contact_dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.contact_dataGrid.AutoGenerateColumns = false;
            this.contact_dataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contact_dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.contact_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contact_dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.contact_dataGrid.DataSource = this.contactsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.contact_dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.contact_dataGrid.Location = new System.Drawing.Point(39, 16);
            this.contact_dataGrid.Name = "contact_dataGrid";
            this.contact_dataGrid.ReadOnly = true;
            this.contact_dataGrid.RowHeadersVisible = false;
            this.contact_dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.contact_dataGrid.Size = new System.Drawing.Size(704, 275);
            this.contact_dataGrid.TabIndex = 1;
            this.contact_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contact_dataGrid_CellContentClick);
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
            this.contactsBindingSource.DataSource = this.contactLMSDataSet;
            // 
            // contactLMSDataSet
            // 
            this.contactLMSDataSet.DataSetName = "ContactLMSDataSet";
            this.contactLMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactsTableAdapter
            // 
            this.contactsTableAdapter.ClearBeforeFill = true;
            // 
            // AddContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddContactsControl";
            this.Size = new System.Drawing.Size(817, 635);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contact_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactLMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView contact_dataGrid;
        private ReaLTaiizor.Controls.MaterialButton materialButton4;
        private ReaLTaiizor.Controls.MaterialButton materialButton3;
        private ReaLTaiizor.Controls.MaterialButton materialButton2;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private ContactLMSDataSet contactLMSDataSet;
        private ContactLMSDataSetTableAdapters.ContactsTableAdapter contactsTableAdapter;

    }
}
