using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Form2 : Form
    {
        private Label lblName, lblAge, lblAddress, lblContactNumber, lblEmail, lblCourseYear, lblGuardianName, lblGuardianContact, lblHobbies, lblNickname;
        private PictureBox studentPictureBox;
        private Button btnAddImage, btnChangeImage, btnEditUpdate;

        public Form2()
        {
            InitializeStudentPage();
            LoadStudentDetails();


            this.FormClosing += Student_Page_FormClosing;
        }

        private void InitializeStudentPage()
        {
            this.Text = "Student Page";
            this.Size = new System.Drawing.Size(400, 650);
            this.Hide();

            studentPictureBox = new PictureBox
            {
                Size = new System.Drawing.Size(120, 120),
                Location = new System.Drawing.Point((this.ClientSize.Width - 120) / 2, 10),
                BorderStyle = BorderStyle.FixedSingle,
                Image = Image.FromFile(@"C:\Users\eronb\source\repos\cloned\Picture.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(studentPictureBox);

            int labelStartY = 180;
            int labelSpacing = 30;

            lblName = CreateLabel("Name: ", labelStartY);
            lblAge = CreateLabel("Age: ", labelStartY + labelSpacing);
            lblAddress = CreateLabel("Address: ", labelStartY + 2 * labelSpacing);
            lblContactNumber = CreateLabel("Contact Number: ", labelStartY + 3 * labelSpacing);
            lblEmail = CreateLabel("Email: ", labelStartY + 4 * labelSpacing);
            lblCourseYear = CreateLabel("Course and Year: ", labelStartY + 5 * labelSpacing);
            lblGuardianName = CreateLabel("Parent/Guardian: ", labelStartY + 6 * labelSpacing);
            lblGuardianContact = CreateLabel("Guardian Contact: ", labelStartY + 7 * labelSpacing);
            lblHobbies = CreateMultiLineLabel("Hobbies: ", labelStartY + 8 * labelSpacing);
            lblNickname = CreateLabel("Nickname: ", labelStartY + 9 * labelSpacing);

            btnEditUpdate = new Button
            {
                Text = "Edit/Update",
                Size = new System.Drawing.Size(150, 30),
                Location = new System.Drawing.Point((this.ClientSize.Width - 100) / 2, labelStartY + 13 * labelSpacing)
            };
            btnEditUpdate.Click += BtnEditUpdate_Click;
            this.Controls.Add(btnEditUpdate);
        }

        private Label CreateLabel(string text, int y)
        {
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, y)
            };
            this.Controls.Add(label);
            return label;
        }

        private Label CreateMultiLineLabel(string text, int y)
        {
            Label label = new Label
            {
                Text = text + "Playing Games",
                AutoSize = true,
                Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, y)
            };
            this.Controls.Add(label);
            return label;
        }

        private void LoadStudentDetails()
        {
            lblName.Text += "Von Andrie M. Macaraeg";
            lblAge.Text += "22";
            lblAddress.Text += "Nalasian Norte Bayambang Pangasinan";
            lblContactNumber.Text += "09958621062";
            lblEmail.Text += "vmacaraeg65@gmail.com";
            lblCourseYear.Text += "BSIT DA 3-1";
            lblGuardianName.Text += "Josephine Macaraeg";
            lblGuardianContact.Text += "09556835824";
            lblNickname.Text += "Princess Sarah, Bon, Andong";
        }

        private void BtnEditUpdate_Click(object sender, EventArgs e)
        {
            Edit_Page editPage = new Edit_Page();
            editPage.Show();
        }


        private void Student_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
