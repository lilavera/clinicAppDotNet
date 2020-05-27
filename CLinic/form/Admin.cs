using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CLinic.form
{
    public partial class Admin : Form
    {

        private DataClinicDataContext db ;
    
        public Admin()
        {
           
            InitializeComponent();
            InitializeDataContext();
            SetUserComboBoxes();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetUserDataGrid()
        {
             userDataGridView.DataSource = db.ViewUsers;
           /*  userDataGridView.Columns["UserId"].Visible = false;
             userDataGridView.Columns["Pesel"].ReadOnly = true;
            userDataGridView.Columns["LastName"].ReadOnly = true;
            userDataGridView.Columns["FirstName"].ReadOnly = true;
            userDataGridView.Columns["SpecializationName"].ReadOnly = true;
             userDataGridView.Columns["CategoryName"].ReadOnly = true;
             userDataGridView.Columns["specializationID"].Visible = false;
             userDataGridView.Columns["CategoryID"].Visible = false;*/
            

        }

        private void SetUserComboBoxes()
        {
            userCategoryComboBox.DataSource = from category in db.UserCategories select category;
            userCategoryComboBox.ValueMember = "CategoryID";
            userCategoryComboBox.DisplayMember = "CategoryName";
            userCategoryComboBox.SelectedIndex = -1;

            var specializations = from spec in db.Specializations select spec;

            userSpecializationComboBox.DataSource = specializations;
            userSpecializationComboBox.ValueMember = "SpecializationID";
            userSpecializationComboBox.DisplayMember = "SpecializationName";
            userSpecializationComboBox.SelectedIndex = -1;

            referralSpecializationComboBox.DataSource = specializations;
            referralSpecializationComboBox.ValueMember = "SpecializationID";
            referralSpecializationComboBox.DisplayMember = "SpecializationName";
            referralSpecializationComboBox.SelectedIndex = -1;

            visitSpecializationComboBox.DataSource = specializations;
            visitSpecializationComboBox.ValueMember = "SpecializationID";
            visitSpecializationComboBox.DisplayMember = "SpecializationName";
            visitSpecializationComboBox.SelectedIndex = -1;
        }
       
        public void InitializeDataContext()
        {
        db = new DataClinicDataContext();
        SetUserDataGrid();
        
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zatwierdzić dokonane zmiany?", "Potwierdzenie",
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                db.SubmitChanges();
            }
        }



        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedRow = userDataGridView.Rows[userDataGridView.SelectedCells[0].RowIndex]
               .Cells["UserID"].Value;
            if (selectedRow == null )
            {
                MessageBox.Show("Proszę zaznaczyć prawidłowy wiersz");
                return;
            }

            if (MessageBox.Show("Czy na pewno chcesz usunąć tego użytkownika?", "Potwierdzenie",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var userId = int.Parse(selectedRow.ToString());

                var user = (from u in db.Users
                            where u.UserID.Equals(userId)
                            select u).FirstOrDefault();

                if (user != null && user.UserID == config.CurrentUser.UserId)
                {
                    MessageBox.Show("Nie można usunąć samego siebie. Operacja przerwana.");
                    return;
                }

                var visit = (from v in db.Visits
                             where v.PatientID.Equals(userId) || v.DoctorID.Equals(userId)
                             select v).ToList();

                var referral = (from r in db.Referrals
                                where r.PatientID.Equals(userId) || r.DoctorID.Equals(userId)
                                select r).ToList();

                if (!referral.Any() && !visit.Any())
                {
                    try
                    {
                        db.Users.DeleteOnSubmit(user ?? throw new InvalidOperationException());
                        db.SubmitChanges(); 
                        InitializeDataContext();
                        MessageBox.Show("Użytkownik został usunięty");
                        InitializeDataContext();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message + "\nBłąd wyboru użytkownika. Spróbuj ponownie");
                    }
                }
                else if (MessageBox.Show(
                             "Wskazany użytkownik ma powiązane wizyty i skierowania. Aby kontynuować usuwanie należy powiązanie pomiędzy nimi zostaną usunięte. Czy chcesz to zrobić?",
                             "Potwierdzenie", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                   db.Visits.DeleteAllOnSubmit(visit);

                    var category =
                        (from c in db.UserCategories
                         join u in db.Users on c.CategoryID equals u.CategoryID
                         where u.UserID.Equals(userId)
                         select c.CategoryName).FirstOrDefault();

                    if (category == null || !category.Equals("Doctor"))
                        db.Referrals.DeleteAllOnSubmit(referral);
                    else
                        foreach (var r in referral)
                            r.DoctorID = null;

                    try
                    {
                       db.Users.DeleteOnSubmit(user ?? throw new InvalidOperationException());
                       db.SubmitChanges();
                        MessageBox.Show("Użytkownik został usunięty");
                       
                        


                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message + "\nBłąd wyboru użytkownika. Spróbuj ponownie");
                    }
                }
            }
        }


        private void addUserButton_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            InitializeDataContext();
        }

        private void userPeselTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(userPeselTextBox.Text))
                userDataGridView.DataSource =
                    from u in db.ViewUserWithoutAdmin where u.Pesel.StartsWith(userPeselTextBox.Text) select u;
            else
                SetUserDataGrid();
        }

        private void userSpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userSpecializationComboBox.SelectedIndex > -1 &&
               int.TryParse(userSpecializationComboBox.SelectedValue.ToString(), out var selectedValue))
                userDataGridView.DataSource = from u in db.ViewUserWithoutAdmin
                                              where u.specializationID.Equals(selectedValue)
                                              select u;
            else
                SetUserDataGrid();
        }

        private void userCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userCategoryComboBox.SelectedIndex > -1 &&
               int.TryParse(userCategoryComboBox.SelectedValue.ToString(), out var selectedValue))
                userDataGridView.DataSource = from u in db.ViewUserWithoutAdmin
                                              where u.CategoryID.Equals(selectedValue)
                                              select u;
            else
                SetUserDataGrid();
        }

        private void userResetButton_Click(object sender, EventArgs e)
        {
            userSpecializationComboBox.SelectedIndex = -1;
            userCategoryComboBox.SelectedIndex = -1;
            userPeselTextBox.Text = "";
            SetUserDataGrid();
        }


        private void SetReferralsDataGrid()
        {
            var query = from r in db.Referrals
                        join p in db.Users on r.PatientID equals p.UserID
                        join s in db.Specializations on r.SpecializationId equals s.SpecializationID
                        join d in db.Users on r.DoctorID equals d.UserID into doc
                        from d in doc.DefaultIfEmpty()
                        select new
                        {
                            r.ReferralID,
                            r.CreationDate,
                            r.ReferralNumber,
                            Patient = p.FirstName + " " + p.LastName,
                            Doctor = d == null ? "" : d.FirstName + " " + d.LastName,
                            s.SpecializationName
                        };
            referralsDataGridView.DataSource = query;
            referralsDataGridView.Columns["ReferralID"].Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void referralSpecializationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (referralSpecializationComboBox.SelectedIndex > -1 &&
                int.TryParse(referralSpecializationComboBox.SelectedValue.ToString(), out var selectedValue))
                referralsDataGridView.DataSource = from r in db.Referrals
                                                   join p in db.Users on r.PatientID equals p.UserID
                                                   join d in db.Users on r.DoctorID equals d.UserID
                                                   join s in db.Specializations on r.SpecializationId equals s.SpecializationID
                                                   where r.SpecializationId.Equals(selectedValue)
                                                   select new
                                                   {
                                                       r.ReferralID,
                                                       r.CreationDate,
                                                       r.ReferralNumber,
                                                       Patient = p.FirstName + " " + p.LastName,
                                                       Doctor = d.FirstName + " " + d.LastName,
                                                       s.SpecializationName
                                                   };
            else
                SetReferralsDataGrid();
        }

        private void SetVisitsDataGrid()
        {
            var query = from v in db.Visits
                        join d in db.Users on v.DoctorID equals d.UserID
                        join p in db.Users on v.PatientID equals p.UserID
                        join s in db.Specializations on v.SpecializationID equals s.SpecializationID
                        join r in db.Referrals on v.ReferralID equals r.ReferralID into x
                        from subx in x.DefaultIfEmpty()
                        select new
                        {
                            v.VisitID,
                            v.VisitDateTime,
                            Patient = p.FirstName + " " + p.LastName,
                            Doctor = d.FirstName + " " + d.LastName,
                            s.SpecializationName,
                            subx.ReferralNumber
                        };
            visitsDataGridView.DataSource = query;
            visitsDataGridView.Columns["VisitID"].Visible = false;
        }


        private void referralNumberTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(referralNumberTextBox.Text))
                referralsDataGridView.DataSource =
                    from r in db.Referrals
                    join p in db.Users on r.PatientID equals p.UserID
                    join d in db.Users on r.DoctorID equals d.UserID
                    join s in db.Specializations on r.SpecializationId equals s.SpecializationID
                    where r.ReferralNumber.StartsWith(referralNumberTextBox.Text)
                    select new
                    {
                        r.ReferralID,
                        r.CreationDate,
                        r.ReferralNumber,
                        Patient = p.FirstName + " " + p.LastName,
                        Doctor = d.FirstName + " " + d.LastName,
                        s.SpecializationName
                    };
            else
                SetReferralsDataGrid();
        }

        private void referralResetButton_Click(object sender, EventArgs e)
        {
            referralSpecializationComboBox.SelectedIndex = -1;
            referralNumberTextBox.Text = "";
            SetReferralsDataGrid();
        }

        private void deleteReferralButton_Click_1(object sender, EventArgs e)
        {
            var selectedRow = referralsDataGridView.Rows[referralsDataGridView.SelectedCells[0].RowIndex]
               .Cells["ReferralID"].Value;
            if (selectedRow == null || referralsDataGridView.SelectedCells.Count < 0)
            {
                MessageBox.Show("Proszę zaznaczyć prawidłowy wiersz");
                return;
            }

            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrane skierowanie?", "Potwierdzenie",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var selectedReferralId = int.Parse(selectedRow.ToString());

                var referal = (from r in db.Referrals
                               where r.ReferralID.Equals(selectedReferralId)
                               select r).FirstOrDefault();

                var referredVisit =
                    (from v in db.Visits where v.ReferralID.Equals(selectedReferralId) select v)
                    .FirstOrDefault();
                if (referredVisit == null)
                {
                    try
                    {
                       db.Referrals.DeleteOnSubmit(referal ?? throw new InvalidOperationException());
                        db.SubmitChanges();
                        InitializeDataContext();
                        MessageBox.Show("Skierowanie zostało usunięte");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message + "\nBłąd wyboru skierowania. Spróbuj ponownie");
                    }
                }
                else
                {
                    if (MessageBox.Show(
                            "Wybrane skierowanie jest już przypisane do wizyty. W celu usunięcia skierowania konieczne będzie usunięcie także tej wizyty. Czy chcesz to zrobić?",
                            "Potwierdzenie", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        try
                        {
                            db.Visits.DeleteOnSubmit(referredVisit);
                            db.SubmitChanges();
                            db.Referrals.DeleteOnSubmit(referal ?? throw new InvalidOperationException());
                            db.SubmitChanges();
                            InitializeDataContext();
                            MessageBox.Show("Skierowanie i powiązana z nim wizyta zostały usunięte");
                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message + "\nBłąd wyboru skierowania. Spróbuj ponownie");
                        }
                }
            }
        }

        private void visitSpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visitSpecializationComboBox.SelectedIndex > -1 &&
               int.TryParse(visitSpecializationComboBox.SelectedValue.ToString(), out var selectedValue))
                visitsDataGridView.DataSource = from v in db.Visits
                                                join d in db.Users on v.DoctorID equals d.UserID
                                                join p in db.Users on v.PatientID equals p.UserID
                                                join s in db.Specializations on v.SpecializationID equals s.SpecializationID
                                                join r in db.Referrals on v.ReferralID equals r.ReferralID into x
                                                from subx in x.DefaultIfEmpty()
                                                where v.SpecializationID.Equals(selectedValue)
                                                select new
                                                {
                                                    v.VisitID,
                                                    v.VisitDateTime,
                                                    Patient = p.FirstName + " " + p.LastName,
                                                    Doctor = d.FirstName + " " + d.LastName,
                                                    s.SpecializationName,
                                                    subx.ReferralNumber
                                                };
            else
                SetVisitsDataGrid();
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }


        private void visitReferralNumberTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(visitReferralNumberTextBox.Text))
                visitsDataGridView.DataSource =
                    from v in db.Visits
                    join d in db.Users on v.DoctorID equals d.UserID
                    join p in db.Users on v.PatientID equals p.UserID
                    join s in db.Specializations on v.SpecializationID equals s.SpecializationID
                    join r in db.Referrals on v.ReferralID equals r.ReferralID into x
                    from subx in x.DefaultIfEmpty()
                    where subx.ReferralNumber.StartsWith(visitReferralNumberTextBox.Text)
                    select new
                    {
                        v.VisitID,
                        v.VisitDateTime,
                        Patient = p.FirstName + " " + p.LastName,
                        Doctor = d.FirstName + " " + d.LastName,
                        s.SpecializationName,
                        subx.ReferralNumber
                    };
            else
                SetVisitsDataGrid();
        }

        private void visitResetButton_Click(object sender, EventArgs e)
        {
            visitSpecializationComboBox.SelectedIndex = -1;
            visitReferralNumberTextBox.Text = "";
            SetVisitsDataGrid();
        }

        private void cancelVisitButton_Click(object sender, EventArgs e)
        {
            var selectedRow = visitsDataGridView.Rows[visitsDataGridView.SelectedCells[0].RowIndex]
                .Cells["VisitID"].Value;
            if (selectedRow == null || visitsDataGridView.SelectedCells.Count < 0)
            {
                MessageBox.Show("Proszę zaznaczyć prawidłowy wiersz");
                return;
            }

            if (MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Potwierdzenie",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var selectedvalue = selectedRow.ToString();
                if (int.TryParse(selectedvalue, out var selectedVisitId))
                {
                    selectedVisitId = int.Parse(selectedvalue);
                }
                else
                {
                    MessageBox.Show("Nieprawidłowy wybór");
                    return;
                }

                var query = (from v in db.Visits where v.VisitID.Equals(selectedVisitId) select v)
                    .FirstOrDefault();

                if (query != null)
                {
                    db.Visits.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    MessageBox.Show("Wizyta została usunięta");
                    InitializeDataContext();
                }
            }
        }

        private void userVisitsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }


        private void userDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = userDataGridView.Rows[e.RowIndex];
            var user = row.Cells["CategoryName"].Value.ToString();
            if (user != null && user.Equals("Admin") && row.Cells["IsActive"].Value.Equals(false))
            {
                MessageBox.Show("Nie można dezaktywować administratora");
                row.Cells["IsActive"].Value = true;
            }
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zatwierdzić dokonane zmiany?", "Potwierdzenie",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) db.SubmitChanges();
        }

        private void userDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            userDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

       
    }
}
