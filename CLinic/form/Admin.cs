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
        private DataClinicDataContext db;
        public Admin()
        {
            InitializeComponent();
            InitAll();
        }


        private void InitAll()
        {
           db = new DataClinicDataContext();


            SetUserDataGrid();

        }
        private void SetUserDataGrid()
        {
            dataGridView1.DataSource = db.ViewUsers;
            dataGridView2.DataSource = db.ViewUsers;

        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView1.Rows[e.RowIndex];
            var user = row.Cells["CategoryName"].Value.ToString();
            if (user != null && user.Equals("Admin") && row.Cells["IsActive"].Value.Equals(false))
            {
                MessageBox.Show("Nie można dezaktywować administratora");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit);
          
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            var row = dataGridView1.Rows[e.RowIndex];
            var user = row.Cells["CategoryName"].Value.ToString();
            if (user != null && user.Equals("Admin") && row.Cells["IsActive"].Value.Equals(false))
            {
                MessageBox.Show("Nie można dezaktywować administratora");
                row.Cells["IsActive"].Value = true;
            }
        }
    }
}
