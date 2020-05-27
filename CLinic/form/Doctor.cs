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
    public partial class Doctor : Form
    {
        private readonly DataClinicDataContext db = new DataClinicDataContext();
        public Doctor()
        {
            InitializeComponent();
            ShowFutureVisits();
        }

        private void ShowFutureVisits()
        {
            var query = from v in db.Visits
                        join p in db.Users on v.PatientID equals p.UserID
                        where v.DoctorID.Equals(config.CurrentUser.UserId) &&
                              v.VisitDateTime >= DateTime.Now
                        select new { v.VisitDateTime, Patient = p.FirstName + " " + p.LastName };

            visitsDataGridView.DataSource = query;
        }
    }
}
