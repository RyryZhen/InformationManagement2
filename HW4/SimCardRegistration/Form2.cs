using System;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class Form2 : Form
    {
        public static Form2 instance2;
        public PictureBox picBox;
        public MaskedTextBox mobile;
        public TextBox firstname;
        public TextBox lastname;
        public RadioButton sex;
        public ComboBox status;
        public DateTimePicker birthdate;
        public TextBox location;
           

        public Form2()
        {
            InitializeComponent();
            instance2 = this;
            picBox = pictureBox;
            mobile = mTB1;
            firstname = fName2;
            lastname = lName;
            sex = rBtnMale.Checked ? rBtnMale : rBtnMale;
            status = cmbStatus;
            birthdate = bDay;
            location = locationBox;




        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            //picBox.Image = Form1.instance1.browse.Image;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            instance2 = this;
            picBox = pictureBox;
            mobile.ReadOnly = true;
            firstname.ReadOnly = true;
            lastname.ReadOnly = true;
            sex.AutoCheck = false;
            status.Enabled = false;
            birthdate.Enabled = false;
            location.ReadOnly = true;
        }
    }
}
