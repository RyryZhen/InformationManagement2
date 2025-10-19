using System;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class Form1 : Form
    {
        public static Form1 instance1;
        public Button browse;
        public MaskedTextBox mobile1;
        public TextBox firstname;
        public TextBox lastname;
        public RadioButton sex;
        public ComboBox status;
        public DateTimePicker birthdate;
        public TextBox location;
        public Form1()
        {
            InitializeComponent();
            instance1 = this;
            browse = browseBtn;
            mobile1 = mTB1;
            firstname = fName;
            lastname = lName;
            sex = rBtnMale.Checked ? rBtnMale : rBtnMale;
            status = comBoxStatus;
            birthdate = bDay;
            location = locBox;
        }

        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            Form2.instance2.picBox.Image = browse.Image;
            Form2.instance2.picBox.SizeMode = PictureBoxSizeMode.Zoom;
            Form2.instance2.mobile.Text = mobile1.Text;
            Form2.instance2.firstname.Text = firstname.Text;
            Form2.instance2.lastname.Text = lastname.Text;
            if (sex.Text == "Male")
            {
                Form2.instance2.sex.Checked = true;
            }
            else
            {
                Form2.instance2.sex.Checked = true;
            }

            Form2.instance2.status.Text = status.Text;
            Form2.instance2.birthdate.Text = birthdate.Text;
            Form2.instance2.location.Text = location.Text;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog.FileName;

                // Load the image into the button (your 'browse' variable)
                browse.Image = new System.Drawing.Bitmap(filePath);

                pictureBox1.Image = browse.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rBtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    
