
namespace SimCardRegistration
{
    partial class Form2
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.mTB1 = new System.Windows.Forms.MaskedTextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.bDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fName2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(533, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(126, 114);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // mTB1
            // 
            this.mTB1.Location = new System.Drawing.Point(154, 181);
            this.mTB1.Name = "mTB1";
            this.mTB1.Size = new System.Drawing.Size(168, 22);
            this.mTB1.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(491, 227);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(168, 22);
            this.lName.TabIndex = 3;
            // 
            // locationBox
            // 
            this.locationBox.Location = new System.Drawing.Point(154, 382);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(359, 22);
            this.locationBox.TabIndex = 3;
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(154, 281);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(59, 21);
            this.rBtnMale.TabIndex = 4;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(247, 281);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rBtnFemale.TabIndex = 4;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // bDay
            // 
            this.bDay.Location = new System.Drawing.Point(154, 323);
            this.bDay.Name = "bDay";
            this.bDay.Size = new System.Drawing.Size(168, 22);
            this.bDay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Location";
            // 
            // fName2
            // 
            this.fName2.Location = new System.Drawing.Point(154, 229);
            this.fName2.Name = "fName2";
            this.fName2.Size = new System.Drawing.Size(168, 22);
            this.fName2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Firstname";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Annulled",
            "Widowed",
            "Separated"});
            this.cmbStatus.Location = new System.Drawing.Point(491, 280);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(168, 24);
            this.cmbStatus.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDay);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.fName2);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.mTB1);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form2";
            this.Text = "SIM CARD Registration Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MaskedTextBox mTB1;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.DateTimePicker bDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fName2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
    }
}