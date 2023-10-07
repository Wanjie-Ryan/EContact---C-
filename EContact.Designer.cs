namespace EContact
{
    partial class EContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EContact));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.txtboxContactID = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtBoxContactNumber = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(481, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(145, 61);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.Transparent;
            this.lblContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.Location = new System.Drawing.Point(73, 121);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(86, 20);
            this.lblContactID.TabIndex = 1;
            this.lblContactID.Text = "Contact ID";
            // 
            // txtboxContactID
            // 
            this.txtboxContactID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxContactID.Location = new System.Drawing.Point(188, 121);
            this.txtboxContactID.Name = "txtboxContactID";
            this.txtboxContactID.Size = new System.Drawing.Size(161, 26);
            this.txtboxContactID.TabIndex = 2;
            this.txtboxContactID.TextChanged += new System.EventHandler(this.txtboxcontactID_TextChanged);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(188, 238);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(161, 26);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(73, 238);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(86, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(188, 176);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(161, 26);
            this.txtBoxFirstName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(73, 176);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name";
            // 
            // txtBoxContactNumber
            // 
            this.txtBoxContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContactNumber.Location = new System.Drawing.Point(188, 298);
            this.txtBoxContactNumber.Name = "txtBoxContactNumber";
            this.txtBoxContactNumber.Size = new System.Drawing.Size(161, 26);
            this.txtBoxContactNumber.TabIndex = 8;
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(73, 298);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(93, 20);
            this.lblContactNumber.TabIndex = 7;
            this.lblContactNumber.Text = "Contact No.";
            this.lblContactNumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // EContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 502);
            this.Controls.Add(this.txtBoxContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtboxContactID);
            this.Controls.Add(this.lblContactID);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EContact";
            this.Text = "E-Contact";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.TextBox txtboxContactID;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtBoxContactNumber;
        private System.Windows.Forms.Label lblContactNumber;
    }
}

