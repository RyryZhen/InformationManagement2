
namespace SimCardRegistration
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
            this.mTB1 = new System.Windows.Forms.MaskedTextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.rBtnMale = new System.Windows.Forms.RadioButton();
            this.rBtnFemale = new System.Windows.Forms.RadioButton();
            this.comBoxStatus = new System.Windows.Forms.ComboBox();
            this.bDay = new System.Windows.Forms.DateTimePicker();
            this.submitBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.browseBtn = new System.Windows.Forms.Button();
            this.locBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mTB1
            // 
            this.mTB1.Location = new System.Drawing.Point(119, 125);
            this.mTB1.Mask = "0000-000-000";
            this.mTB1.Name = "mTB1";
            this.mTB1.Size = new System.Drawing.Size(162, 22);
            this.mTB1.TabIndex = 0;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(119, 170);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(162, 22);
            this.fName.TabIndex = 1;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(427, 170);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(162, 22);
            this.lName.TabIndex = 2;
            this.lName.TextChanged += new System.EventHandler(this.lName_TextChanged);
            // 
            // rBtnMale
            // 
            this.rBtnMale.AutoSize = true;
            this.rBtnMale.Location = new System.Drawing.Point(98, 219);
            this.rBtnMale.Name = "rBtnMale";
            this.rBtnMale.Size = new System.Drawing.Size(59, 21);
            this.rBtnMale.TabIndex = 3;
            this.rBtnMale.TabStop = true;
            this.rBtnMale.Text = "Male";
            this.rBtnMale.UseVisualStyleBackColor = true;
            this.rBtnMale.CheckedChanged += new System.EventHandler(this.rBtnMale_CheckedChanged);
            // 
            // rBtnFemale
            // 
            this.rBtnFemale.AutoSize = true;
            this.rBtnFemale.Location = new System.Drawing.Point(185, 219);
            this.rBtnFemale.Name = "rBtnFemale";
            this.rBtnFemale.Size = new System.Drawing.Size(75, 21);
            this.rBtnFemale.TabIndex = 4;
            this.rBtnFemale.TabStop = true;
            this.rBtnFemale.Text = "Female";
            this.rBtnFemale.UseVisualStyleBackColor = true;
            // 
            // comBoxStatus
            // 
            this.comBoxStatus.FormattingEnabled = true;
            this.comBoxStatus.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Divorced",
            "Annulled",
            "Widowed",
            "Separated"});
            this.comBoxStatus.Location = new System.Drawing.Point(427, 219);
            this.comBoxStatus.Name = "comBoxStatus";
            this.comBoxStatus.Size = new System.Drawing.Size(162, 24);
            this.comBoxStatus.TabIndex = 5;
            // 
            // bDay
            // 
            this.bDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bDay.Location = new System.Drawing.Point(119, 266);
            this.bDay.Name = "bDay";
            this.bDay.Size = new System.Drawing.Size(200, 22);
            this.bDay.TabIndex = 6;
            this.bDay.ValueChanged += new System.EventHandler(this.bDay_ValueChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(119, 350);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(169, 48);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Submit Registration";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click_1);
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(468, 121);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(121, 31);
            this.browseBtn.TabIndex = 9;
            this.browseBtn.Text = "Browse\r\n";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // locBox
            // 
            this.locBox.Location = new System.Drawing.Point(119, 322);
            this.locBox.Name = "locBox";
            this.locBox.Size = new System.Drawing.Size(470, 22);
            this.locBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lastname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Location";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(468, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 77);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "SIM CARD Registration";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 760);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.locBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.bDay);
            this.Controls.Add(this.comBoxStatus);
            this.Controls.Add(this.rBtnFemale);
            this.Controls.Add(this.rBtnMale);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.mTB1);
            this.Name = "Form1";
            this.Text = "SIM CARD Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTB1;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.RadioButton rBtnMale;
        private System.Windows.Forms.RadioButton rBtnFemale;
        private System.Windows.Forms.ComboBox comBoxStatus;
        private System.Windows.Forms.DateTimePicker bDay;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox locBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}

