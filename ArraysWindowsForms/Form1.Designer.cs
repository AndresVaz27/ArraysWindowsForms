namespace ArraysWindowsForms
{
    partial class Form1
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
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.buttonViewContact = new System.Windows.Forms.Button();
            this.buttonRemoveContact = new System.Windows.Forms.Button();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.labelContactCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(414, 24);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(193, 23);
            this.buttonAddContact.TabIndex = 0;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(31, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(283, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Nombre";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(31, 84);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(283, 22);
            this.textBoxPhoneNumber.TabIndex = 2;
            this.textBoxPhoneNumber.Text = "Telefono";
            // 
            // buttonViewContact
            // 
            this.buttonViewContact.Location = new System.Drawing.Point(414, 83);
            this.buttonViewContact.Name = "buttonViewContact";
            this.buttonViewContact.Size = new System.Drawing.Size(193, 23);
            this.buttonViewContact.TabIndex = 3;
            this.buttonViewContact.Text = "View Contact";
            this.buttonViewContact.UseVisualStyleBackColor = true;
            this.buttonViewContact.Click += new System.EventHandler(this.buttonViewContact_Click);
            // 
            // buttonRemoveContact
            // 
            this.buttonRemoveContact.Location = new System.Drawing.Point(414, 54);
            this.buttonRemoveContact.Name = "buttonRemoveContact";
            this.buttonRemoveContact.Size = new System.Drawing.Size(193, 23);
            this.buttonRemoveContact.TabIndex = 4;
            this.buttonRemoveContact.Text = "Remove Contact";
            this.buttonRemoveContact.UseVisualStyleBackColor = true;
            this.buttonRemoveContact.Click += new System.EventHandler(this.buttonRemoveContact_Click);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.ItemHeight = 16;
            this.listBoxContacts.Location = new System.Drawing.Point(31, 131);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(576, 180);
            this.listBoxContacts.TabIndex = 5;
            // 
            // labelContactCount
            // 
            this.labelContactCount.AutoSize = true;
            this.labelContactCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactCount.Location = new System.Drawing.Point(238, 314);
            this.labelContactCount.Name = "labelContactCount";
            this.labelContactCount.Size = new System.Drawing.Size(0, 20);
            this.labelContactCount.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 355);
            this.Controls.Add(this.labelContactCount);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.buttonRemoveContact);
            this.Controls.Add(this.buttonViewContact);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddContact);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Button buttonViewContact;
        private System.Windows.Forms.Button buttonRemoveContact;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Label labelContactCount;
    }
}

