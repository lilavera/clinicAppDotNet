namespace CLinic.form
{
    partial class Doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visitsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.referralsDataGridView = new System.Windows.Forms.DataGridView();
            this.addReferral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referralsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // visitsDataGridView
            // 
            this.visitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDataGridView.Location = new System.Drawing.Point(22, 62);
            this.visitsDataGridView.Name = "visitsDataGridView";
            this.visitsDataGridView.Size = new System.Drawing.Size(405, 225);
            this.visitsDataGridView.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(92, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.visitsDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wizyty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addReferral);
            this.tabPage2.Controls.Add(this.referralsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skierowania";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // referralsDataGridView
            // 
            this.referralsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referralsDataGridView.Location = new System.Drawing.Point(27, 42);
            this.referralsDataGridView.Name = "referralsDataGridView";
            this.referralsDataGridView.Size = new System.Drawing.Size(382, 299);
            this.referralsDataGridView.TabIndex = 0;
            // 
            // addReferral
            // 
            this.addReferral.Location = new System.Drawing.Point(474, 151);
            this.addReferral.Name = "addReferral";
            this.addReferral.Size = new System.Drawing.Size(115, 51);
            this.addReferral.TabIndex = 1;
            this.addReferral.Text = "Dodaj skierowanie";
            this.addReferral.UseVisualStyleBackColor = true;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.referralsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addReferral;
        private System.Windows.Forms.DataGridView referralsDataGridView;
    }
}