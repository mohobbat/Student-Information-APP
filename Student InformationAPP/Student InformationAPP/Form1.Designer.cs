namespace Student_InformationAPP
{
    partial class StudentAPPUI
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
            this.sInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.reNoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.retriveButton = new System.Windows.Forms.Button();
            this.sInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sInformationGroupBox
            // 
            this.sInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.sInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.sInformationGroupBox.Controls.Add(this.reNoTextBox);
            this.sInformationGroupBox.Controls.Add(this.label3);
            this.sInformationGroupBox.Controls.Add(this.label2);
            this.sInformationGroupBox.Controls.Add(this.label1);
            this.sInformationGroupBox.Location = new System.Drawing.Point(9, 15);
            this.sInformationGroupBox.Name = "sInformationGroupBox";
            this.sInformationGroupBox.Size = new System.Drawing.Size(337, 207);
            this.sInformationGroupBox.TabIndex = 0;
            this.sInformationGroupBox.TabStop = false;
            this.sInformationGroupBox.Text = "Student Information";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lastNameTextBox.Location = new System.Drawing.Point(101, 129);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(101, 85);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // reNoTextBox
            // 
            this.reNoTextBox.Location = new System.Drawing.Point(101, 33);
            this.reNoTextBox.Name = "reNoTextBox";
            this.reNoTextBox.Size = new System.Drawing.Size(189, 20);
            this.reNoTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(27, 258);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // retriveButton
            // 
            this.retriveButton.Location = new System.Drawing.Point(149, 258);
            this.retriveButton.Name = "retriveButton";
            this.retriveButton.Size = new System.Drawing.Size(75, 23);
            this.retriveButton.TabIndex = 2;
            this.retriveButton.Text = "Retrive";
            this.retriveButton.UseVisualStyleBackColor = true;
            this.retriveButton.Click += new System.EventHandler(this.retriveButton_Click);
            // 
            // StudentAPPUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 285);
            this.Controls.Add(this.retriveButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.sInformationGroupBox);
            this.Name = "StudentAPPUI";
            this.Text = "StudentApp";
            this.sInformationGroupBox.ResumeLayout(false);
            this.sInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sInformationGroupBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox reNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button retriveButton;
    }
}

