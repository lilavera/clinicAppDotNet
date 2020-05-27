using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;

namespace CLinic.form
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(peselTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Proszę uzupełnić oba pola");
            }

            else
            {
                DataClinicDataContext db;
                Users user;
                try {
                    db = new DataClinicDataContext();
                    user =
                        (from u in db.Users where u.Pesel.Equals(peselTextBox.Text) select u).FirstOrDefault();
                }
              
            
                catch (SqlException ex)
            {
                MessageBox.Show("Wystąpił problem z połączeniem do bazy danych. " + ex.Message);
                return; ;
            }

                if (user != null)
                {
                    config.CurrentUser.UserId = user.UserID;
                    config.CurrentUser.UserCategory = (from category in db.UserCategories
                                                       where category.CategoryID.Equals(user.CategoryID)
                                                       select new { category.CategoryName }).FirstOrDefault()
                        ?.CategoryName;

                    if (config.PasswordVerification.IsPasswordValid(passwordTextBox.Text, user.Password))
                    {
                        if (config.CurrentUser.UserCategory != null)
                        {
                            if (config.CurrentUser.UserCategory.Equals("Admin"))
                            {
                                Hide();
                                new AdminView().ShowDialog();
                                Close();
                            }
                        }
                    }
                }

        }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            new Registration().Show();
        }
    }
}
