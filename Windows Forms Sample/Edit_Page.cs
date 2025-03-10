using System;
using System.Linq;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Edit_Page : Form
    {
        private TextBox txtName, txtAge, txtAddress, txtContactNumber, txtEmail, txtGuardianName, txtGuardianContact, txtHobbies, txtNickname;
        private ComboBox cmbCourse, cmbYear;
        private Button btnSave;

        public Edit_Page()
        {

            InitializeEditPage();
        }

        private void InitializeEditPage()
        {
            this.Text = "Edit Student Details";
            this.Size = new System.Drawing.Size(400, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            int labelStartY = 20;
            int labelSpacing = 40;

            txtName = CreateTextBox("Name", labelStartY);
            txtAge = CreateTextBox("Age", labelStartY + labelSpacing);
            txtAddress = CreateTextBox("Address", labelStartY + 2 * labelSpacing);
            txtContactNumber = CreateTextBox("Contact Number", labelStartY + 3 * labelSpacing);
            txtEmail = CreateTextBox("Email", labelStartY + 4 * labelSpacing);
            txtGuardianName = CreateTextBox("Guardian/Parent", labelStartY + 5 * labelSpacing);
            txtGuardianContact = CreateTextBox("Guardian Contact", labelStartY + 6 * labelSpacing);
            txtHobbies = CreateTextBox("Hobbies", labelStartY + 7 * labelSpacing);
            txtNickname = CreateTextBox("Nickname", labelStartY + 8 * labelSpacing);

            Label lblCourse = new Label { Text = "Course:", Location = new System.Drawing.Point(30, labelStartY + 9 * labelSpacing), AutoSize = true };
            this.Controls.Add(lblCourse);

            cmbCourse = new ComboBox { Location = new System.Drawing.Point(150, labelStartY + 9 * labelSpacing), Width = 200 };
            cmbCourse.Items.AddRange(new string[] { "ABEL", "BSBA", "BSIT", "BPA" });
            this.Controls.Add(cmbCourse);

            Label lblYear = new Label { Text = "Year:", Location = new System.Drawing.Point(30, labelStartY + 10 * labelSpacing), AutoSize = true };
            this.Controls.Add(lblYear);

            cmbYear = new ComboBox { Location = new System.Drawing.Point(150, labelStartY + 10 * labelSpacing), Width = 200 };
            cmbYear.Items.AddRange(new string[] { "First", "Second", "Third", "Fourth" });
            this.Controls.Add(cmbYear);

            btnSave = new Button { Text = "Save", Location = new System.Drawing.Point(150, labelStartY + 11 * labelSpacing), Width = 100 };
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);
        }

        private TextBox CreateTextBox(string placeholder, int y)
        {
            Label label = new Label { Text = placeholder + ":", Location = new System.Drawing.Point(30, y), AutoSize = true };
            this.Controls.Add(label);

            TextBox textBox = new TextBox { Location = new System.Drawing.Point(150, y), Width = 200 };
            this.Controls.Add(textBox);
            return textBox;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtGuardianName.Text) ||
                string.IsNullOrWhiteSpace(txtGuardianContact.Text) ||
                cmbCourse.SelectedIndex == -1 ||
                cmbYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtAge.Text.All(char.IsDigit) || !txtContactNumber.Text.All(char.IsDigit) || !txtGuardianContact.Text.All(char.IsDigit))
            {
                MessageBox.Show("Age and contact numbers must be numeric.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Profile successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
