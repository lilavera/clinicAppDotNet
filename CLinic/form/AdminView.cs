using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CLinic.form
{
    public partial class AdminView : Form
    {
        private DataClinicDataContext db;
        public AdminView()
        {
            InitializeComponent();
            SetUserDataGrid();
        }


        private void SetUserDataGrid()
        {
            db = new DataClinicDataContext();
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
    }
    }
