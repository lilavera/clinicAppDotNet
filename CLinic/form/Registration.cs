using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CLinic.form
{
    public partial class Registration : Form
    {
      
        private readonly DataClinicDataContext db = new DataClinicDataContext();
        public Registration()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            userCategory.SelectedIndex = -1;
            specializationComboBox.SelectedIndex = -1;


            if (config.CurrentUser.UserCategory == "Admin")
            {
                userCategory.DataSource = from category in db.UserCategories where category.CategoryID!=2 select category ;
                userCategory.DisplayMember = "CategoryName";
                userCategory.ValueMember = "CategoryID";
                specializationComboBox.DataSource = from specialization in db.Specializations select specialization;
                specializationComboBox.DisplayMember = "SpecializationName";
                specializationComboBox.ValueMember = "SpecializationId";
                specializationComboBox.SelectedIndex = 0;
            }
            else
            {
                userCategory.DataSource = from category in db.UserCategories where category.CategoryName.Equals("Patient") select category;
                userCategory.DisplayMember = "CategoryName";
                userCategory.ValueMember = "CategoryID";
                specializationComboBox.Visible = false;
                specializationLabel.Visible = false;
            }
        }

        private bool ifUserExists(String pesel)
        {
            var pesels = (from user in db.Users where user.Pesel.Equals(pesel) select user).Count();
            return pesels != 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool activeUser = config.CurrentUser.UserCategory != null;

            if (!Regex.IsMatch(nameTextBox.Text, @"^\p{L}+$") || string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Pole \"Imię\" nie może być puste ani zawierać znaków innych niż litery");
            }
            else if (!Regex.IsMatch(lastnameTextBox.Text, @"^\p{L}+$") ||
                     string.IsNullOrWhiteSpace(lastnameTextBox.Text))
            {
                MessageBox.Show("Pole \"nazwisko\" nie może być puste ani zawierać znaków innych niż litery");
            }
            else if (!Regex.IsMatch(peselTextBox.Text, @"^[0-9]{11}") || peselTextBox.Text.Length != 11)
            {
                MessageBox.Show("Pesel musi składać się z dokładnie 11 cyfr.");
            }
            else if (ifUserExists(peselTextBox.Text))
            {
                MessageBox.Show("Użytkownik o podanym peselu już istnieje");
            }
            else
            {
                var user = new Users
                {
                    Pesel = peselTextBox.Text,
                    FirstName = nameTextBox.Text,
                    LastName = lastnameTextBox.Text,
                    Password = config.PasswordVerification.GetSecurePassword(passwordTextBox.Text),
                    CategoryID= int.Parse(userCategory.SelectedValue.ToString()),
                    specializationID = specializationComboBox.SelectedIndex > -1
                        ? int.Parse(specializationComboBox.SelectedValue.ToString())
                        : (int?)null,
                    IsActive = activeUser
                };

                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
                MessageBox.Show("Użytkownik dodany");
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            nameTextBox.Text = "";
            lastnameTextBox.Text = "";
            peselTextBox.Text = "";
            passwordTextBox.Text = "";
            specializationComboBox.SelectedIndex = -1;
            specializationComboBox.Enabled = false;
            userCategory.SelectedIndex = -1;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            lastnameTextBox.Text = "";
            peselTextBox.Text = "";
            passwordTextBox.Text = "";
            userCategory.SelectedIndex = -1;
            specializationComboBox.SelectedIndex = -1;

        }

        private void userCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            var result = userCategory.Text.Equals("Doctor");
            specializationComboBox.Enabled = result;
            specializationLabel.Enabled = result;
            if (!result) specializationComboBox.SelectedIndex = -1;

        }
    }
}
