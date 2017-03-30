namespace ExitExamApp
{
    partial class DeleteUserForm
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
            this.mNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.mNumberBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.getUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.verifyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mNumberLabel
            // 
            this.mNumberLabel.AutoSize = true;
            this.mNumberLabel.Location = new System.Drawing.Point(61, 28);
            this.mNumberLabel.Name = "mNumberLabel";
            this.mNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.mNumberLabel.TabIndex = 19;
            this.mNumberLabel.Text = "Mustang ID";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(61, 165);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(60, 13);
            this.userNameLabel.TabIndex = 17;
            this.userNameLabel.Text = "User Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(61, 122);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(58, 79);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "First Name";
            // 
            // mNumberBox
            // 
            this.mNumberBox.Location = new System.Drawing.Point(61, 44);
            this.mNumberBox.Name = "mNumberBox";
            this.mNumberBox.Size = new System.Drawing.Size(203, 20);
            this.mNumberBox.TabIndex = 14;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(61, 138);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(203, 20);
            this.lastNameBox.TabIndex = 11;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(61, 95);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(203, 20);
            this.firstNameBox.TabIndex = 10;
            // 
            // getUserButton
            // 
            this.getUserButton.Location = new System.Drawing.Point(22, 288);
            this.getUserButton.Name = "getUserButton";
            this.getUserButton.Size = new System.Drawing.Size(75, 23);
            this.getUserButton.TabIndex = 20;
            this.getUserButton.Text = "Get User ";
            this.getUserButton.UseVisualStyleBackColor = true;
            this.getUserButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(121, 288);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.deleteUserButton.TabIndex = 21;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(215, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // verifyBox
            // 
            this.verifyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyBox.Location = new System.Drawing.Point(22, 190);
            this.verifyBox.Multiline = true;
            this.verifyBox.Name = "verifyBox";
            this.verifyBox.Size = new System.Drawing.Size(268, 83);
            this.verifyBox.TabIndex = 23;
            this.verifyBox.Text = "If this is the user  to delete, \r\nclick  the \"Delete User\" button.\r\nOtherwise, \r\n" +
    "click the \"Cancel\" button.\r\n";
            this.verifyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(323, 366);
            this.Controls.Add(this.verifyBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.getUserButton);
            this.Controls.Add(this.mNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.mNumberBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Name = "DeleteUserForm";
            this.Text = "Delete User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mNumberLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox mNumberBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Button getUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox verifyBox;
    }
}