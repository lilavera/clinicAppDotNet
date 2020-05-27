namespace CLinic.form
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.viewUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new CLinic.ClinicDataSet();
            this.viewUserWithoutAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet2 = new CLinic.ClinicDataSet2();
            this.viewUsersTableAdapter = new CLinic.ClinicDataSetTableAdapters.ViewUsersTableAdapter();
            this.clinicDataSet1 = new CLinic.ClinicDataSet1();
            this.viewUsersWithoutAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewUsersWithoutAdminTableAdapter = new CLinic.ClinicDataSet1TableAdapters.ViewUsersWithoutAdminTableAdapter();
            this.viewUserWithoutAdminTableAdapter = new CLinic.ClinicDataSet2TableAdapters.ViewUserWithoutAdminTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.userResetChangesButton = new System.Windows.Forms.Button();
            this.userResetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userPeselTextBox = new System.Windows.Forms.TextBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userSpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.userCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.addUserButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.referralResetButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.referralNumberTextBox = new System.Windows.Forms.TextBox();
            this.referralSpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.deleteReferralButton = new System.Windows.Forms.Button();
            this.referralsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.visitResetButton = new System.Windows.Forms.Button();
            this.visitReferralNumberTextBox = new System.Windows.Forms.TextBox();
            this.visitSpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.cancelVisitButton = new System.Windows.Forms.Button();
            this.visitsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.specializationPictureBox = new System.Windows.Forms.PictureBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.deleteSpecializationButton = new System.Windows.Forms.Button();
            this.specializationsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chartResetButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.chartMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.chartDoctorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chartSpecializationComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserWithoutAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersWithoutAdminBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referralsDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsDataGridView)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewUsersBindingSource
            // 
            this.viewUsersBindingSource.DataMember = "ViewUsers";
            this.viewUsersBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "ClinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUserWithoutAdminBindingSource
            // 
            this.viewUserWithoutAdminBindingSource.DataMember = "ViewUserWithoutAdmin";
            this.viewUserWithoutAdminBindingSource.DataSource = this.clinicDataSet2;
            // 
            // clinicDataSet2
            // 
            this.clinicDataSet2.DataSetName = "ClinicDataSet2";
            this.clinicDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUsersTableAdapter
            // 
            this.viewUsersTableAdapter.ClearBeforeFill = true;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "ClinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewUsersWithoutAdminBindingSource
            // 
            this.viewUsersWithoutAdminBindingSource.DataMember = "ViewUsersWithoutAdmin";
            this.viewUsersWithoutAdminBindingSource.DataSource = this.clinicDataSet1;
            // 
            // viewUsersWithoutAdminTableAdapter
            // 
            this.viewUsersWithoutAdminTableAdapter.ClearBeforeFill = true;
            // 
            // viewUserWithoutAdminTableAdapter
            // 
            this.viewUserWithoutAdminTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(48, -145);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 938);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.userResetChangesButton);
            this.tabPage1.Controls.Add(this.userResetButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.userPeselTextBox);
            this.tabPage1.Controls.Add(this.changePasswordButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.userSpecializationComboBox);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.userCategoryComboBox);
            this.tabPage1.Controls.Add(this.userDataGridView);
            this.tabPage1.Controls.Add(this.addUserButton);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 912);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Użytkownicy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // userResetChangesButton
            // 
            this.userResetChangesButton.Location = new System.Drawing.Point(132, 408);
            this.userResetChangesButton.Name = "userResetChangesButton";
            this.userResetChangesButton.Size = new System.Drawing.Size(109, 47);
            this.userResetChangesButton.TabIndex = 12;
            this.userResetChangesButton.Text = "Resetuj wszystkie niezatwierdzone zmiany";
            this.userResetChangesButton.UseVisualStyleBackColor = true;
            // 
            // userResetButton
            // 
            this.userResetButton.Location = new System.Drawing.Point(588, 507);
            this.userResetButton.Name = "userResetButton";
            this.userResetButton.Size = new System.Drawing.Size(116, 34);
            this.userResetButton.TabIndex = 11;
            this.userResetButton.Text = "Resetuj filtrowanie";
            this.userResetButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wyszukaj po numerze pesel:";
            // 
            // userPeselTextBox
            // 
            this.userPeselTextBox.Location = new System.Drawing.Point(574, 435);
            this.userPeselTextBox.Name = "userPeselTextBox";
            this.userPeselTextBox.Size = new System.Drawing.Size(153, 20);
            this.userPeselTextBox.TabIndex = 9;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(132, 508);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(109, 47);
            this.changePasswordButton.TabIndex = 8;
            this.changePasswordButton.Text = "Resetuj hasło zaznaczonemu użytkownikowi";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rodzaj użytkownika:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Specjalizacja:";
            // 
            // userSpecializationComboBox
            // 
            this.userSpecializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userSpecializationComboBox.FormattingEnabled = true;
            this.userSpecializationComboBox.Location = new System.Drawing.Point(384, 434);
            this.userSpecializationComboBox.Name = "userSpecializationComboBox";
            this.userSpecializationComboBox.Size = new System.Drawing.Size(164, 21);
            this.userSpecializationComboBox.TabIndex = 5;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 507);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(109, 48);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Usuń zaznaczonego użytkownika";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // userCategoryComboBox
            // 
            this.userCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCategoryComboBox.FormattingEnabled = true;
            this.userCategoryComboBox.Location = new System.Drawing.Point(384, 522);
            this.userCategoryComboBox.Name = "userCategoryComboBox";
            this.userCategoryComboBox.Size = new System.Drawing.Size(164, 21);
            this.userCategoryComboBox.TabIndex = 4;
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Location = new System.Drawing.Point(17, 188);
            this.userDataGridView.MultiSelect = false;
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.Size = new System.Drawing.Size(736, 198);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick_1);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(256, 508);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(109, 47);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Dodaj nowego użytkownika";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 408);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(109, 47);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Zatwierdź wszystkie zmiany";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.referralResetButton);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.referralNumberTextBox);
            this.tabPage2.Controls.Add(this.referralSpecializationComboBox);
            this.tabPage2.Controls.Add(this.deleteReferralButton);
            this.tabPage2.Controls.Add(this.referralsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 912);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Skierowania";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // referralResetButton
            // 
            this.referralResetButton.Location = new System.Drawing.Point(31, 481);
            this.referralResetButton.Name = "referralResetButton";
            this.referralResetButton.Size = new System.Drawing.Size(107, 36);
            this.referralResetButton.TabIndex = 6;
            this.referralResetButton.Text = "Resetuj filtrowanie";
            this.referralResetButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Wyszukaj skierownie po numerze";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Rodzaj specjalisty";
            // 
            // referralNumberTextBox
            // 
            this.referralNumberTextBox.Location = new System.Drawing.Point(31, 426);
            this.referralNumberTextBox.Name = "referralNumberTextBox";
            this.referralNumberTextBox.Size = new System.Drawing.Size(160, 20);
            this.referralNumberTextBox.TabIndex = 3;
            // 
            // referralSpecializationComboBox
            // 
            this.referralSpecializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.referralSpecializationComboBox.FormattingEnabled = true;
            this.referralSpecializationComboBox.Location = new System.Drawing.Point(31, 336);
            this.referralSpecializationComboBox.Name = "referralSpecializationComboBox";
            this.referralSpecializationComboBox.Size = new System.Drawing.Size(160, 21);
            this.referralSpecializationComboBox.TabIndex = 2;
            // 
            // deleteReferralButton
            // 
            this.deleteReferralButton.Location = new System.Drawing.Point(616, 321);
            this.deleteReferralButton.Name = "deleteReferralButton";
            this.deleteReferralButton.Size = new System.Drawing.Size(131, 56);
            this.deleteReferralButton.TabIndex = 1;
            this.deleteReferralButton.Text = "Usuń zaznaczone skierowanie";
            this.deleteReferralButton.UseVisualStyleBackColor = true;
            // 
            // referralsDataGridView
            // 
            this.referralsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.referralsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referralsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.referralsDataGridView.MultiSelect = false;
            this.referralsDataGridView.Name = "referralsDataGridView";
            this.referralsDataGridView.Size = new System.Drawing.Size(759, 313);
            this.referralsDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.visitResetButton);
            this.tabPage3.Controls.Add(this.visitReferralNumberTextBox);
            this.tabPage3.Controls.Add(this.visitSpecializationComboBox);
            this.tabPage3.Controls.Add(this.cancelVisitButton);
            this.tabPage3.Controls.Add(this.visitsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 912);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wizyty";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Wyszukaj wizytę po numerze skierowania:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rodzaj specjalisty";
            // 
            // visitResetButton
            // 
            this.visitResetButton.Location = new System.Drawing.Point(6, 492);
            this.visitResetButton.Name = "visitResetButton";
            this.visitResetButton.Size = new System.Drawing.Size(107, 36);
            this.visitResetButton.TabIndex = 7;
            this.visitResetButton.Text = "Resetuj filtrowanie";
            this.visitResetButton.UseVisualStyleBackColor = true;
            // 
            // visitReferralNumberTextBox
            // 
            this.visitReferralNumberTextBox.Location = new System.Drawing.Point(6, 439);
            this.visitReferralNumberTextBox.Name = "visitReferralNumberTextBox";
            this.visitReferralNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.visitReferralNumberTextBox.TabIndex = 4;
            // 
            // visitSpecializationComboBox
            // 
            this.visitSpecializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visitSpecializationComboBox.FormattingEnabled = true;
            this.visitSpecializationComboBox.Location = new System.Drawing.Point(6, 370);
            this.visitSpecializationComboBox.Name = "visitSpecializationComboBox";
            this.visitSpecializationComboBox.Size = new System.Drawing.Size(160, 21);
            this.visitSpecializationComboBox.TabIndex = 3;
            // 
            // cancelVisitButton
            // 
            this.cancelVisitButton.Location = new System.Drawing.Point(618, 356);
            this.cancelVisitButton.Name = "cancelVisitButton";
            this.cancelVisitButton.Size = new System.Drawing.Size(129, 59);
            this.cancelVisitButton.TabIndex = 2;
            this.cancelVisitButton.Text = "Usuń zaznaczoną wizytę";
            this.cancelVisitButton.UseVisualStyleBackColor = true;
            // 
            // visitsDataGridView
            // 
            this.visitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.visitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.visitsDataGridView.MultiSelect = false;
            this.visitsDataGridView.Name = "visitsDataGridView";
            this.visitsDataGridView.Size = new System.Drawing.Size(759, 350);
            this.visitsDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(759, 912);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Zarządzanie bazą";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(505, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 99);
            this.button5.TabIndex = 1;
            this.button5.Text = "Usuń historię wizyt i skierowań";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(38, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 99);
            this.button4.TabIndex = 0;
            this.button4.Text = "Resetuj bazę danych";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.specializationPictureBox);
            this.tabPage5.Controls.Add(this.submitButton);
            this.tabPage5.Controls.Add(this.deleteSpecializationButton);
            this.tabPage5.Controls.Add(this.specializationsDataGridView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(759, 912);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Specjalizacje";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // specializationPictureBox
            // 
            this.specializationPictureBox.Location = new System.Drawing.Point(457, 47);
            this.specializationPictureBox.Name = "specializationPictureBox";
            this.specializationPictureBox.Size = new System.Drawing.Size(256, 256);
            this.specializationPictureBox.TabIndex = 3;
            this.specializationPictureBox.TabStop = false;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(513, 410);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(143, 59);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Zatwierdź zmiany";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // deleteSpecializationButton
            // 
            this.deleteSpecializationButton.Location = new System.Drawing.Point(513, 328);
            this.deleteSpecializationButton.Name = "deleteSpecializationButton";
            this.deleteSpecializationButton.Size = new System.Drawing.Size(143, 59);
            this.deleteSpecializationButton.TabIndex = 1;
            this.deleteSpecializationButton.Text = "Usuń wybraną specjalizację";
            this.deleteSpecializationButton.UseVisualStyleBackColor = true;
            // 
            // specializationsDataGridView
            // 
            this.specializationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.specializationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specializationsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.specializationsDataGridView.MultiSelect = false;
            this.specializationsDataGridView.Name = "specializationsDataGridView";
            this.specializationsDataGridView.Size = new System.Drawing.Size(412, 512);
            this.specializationsDataGridView.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chartResetButton);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.chartMonthCalendar);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.chartDoctorComboBox);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.chartSpecializationComboBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(759, 912);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Wykres wizyt";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chartResetButton
            // 
            this.chartResetButton.Location = new System.Drawing.Point(218, 454);
            this.chartResetButton.Name = "chartResetButton";
            this.chartResetButton.Size = new System.Drawing.Size(130, 41);
            this.chartResetButton.TabIndex = 9;
            this.chartResetButton.Text = "Resetuj filtrowanie";
            this.chartResetButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Wybierz okres z którego chcesz otrzymać dane:\r\n";
            // 
            // chartMonthCalendar
            // 
            this.chartMonthCalendar.Location = new System.Drawing.Point(444, 333);
            this.chartMonthCalendar.MaxSelectionCount = 15;
            this.chartMonthCalendar.Name = "chartMonthCalendar";
            this.chartMonthCalendar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lekarz";
            // 
            // chartDoctorComboBox
            // 
            this.chartDoctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chartDoctorComboBox.FormattingEnabled = true;
            this.chartDoctorComboBox.Location = new System.Drawing.Point(196, 323);
            this.chartDoctorComboBox.Name = "chartDoctorComboBox";
            this.chartDoctorComboBox.Size = new System.Drawing.Size(152, 21);
            this.chartDoctorComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Specjalizacja:";
            // 
            // chartSpecializationComboBox
            // 
            this.chartSpecializationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chartSpecializationComboBox.FormattingEnabled = true;
            this.chartSpecializationComboBox.Location = new System.Drawing.Point(11, 323);
            this.chartSpecializationComboBox.Name = "chartSpecializationComboBox";
            this.chartSpecializationComboBox.Size = new System.Drawing.Size(152, 21);
            this.chartSpecializationComboBox.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(862, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUserWithoutAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersWithoutAdminBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referralsDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.specializationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specializationsDataGridView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ClinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource viewUsersBindingSource;
        private ClinicDataSetTableAdapters.ViewUsersTableAdapter viewUsersTableAdapter;
        private ClinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.BindingSource viewUsersWithoutAdminBindingSource;
        private ClinicDataSet1TableAdapters.ViewUsersWithoutAdminTableAdapter viewUsersWithoutAdminTableAdapter;
        private ClinicDataSet2 clinicDataSet2;
        private System.Windows.Forms.BindingSource viewUserWithoutAdminBindingSource;
        private ClinicDataSet2TableAdapters.ViewUserWithoutAdminTableAdapter viewUserWithoutAdminTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button userResetChangesButton;
        private System.Windows.Forms.Button userResetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPeselTextBox;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userSpecializationComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox userCategoryComboBox;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button referralResetButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox referralNumberTextBox;
        private System.Windows.Forms.ComboBox referralSpecializationComboBox;
        private System.Windows.Forms.Button deleteReferralButton;
        private System.Windows.Forms.DataGridView referralsDataGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button visitResetButton;
        private System.Windows.Forms.TextBox visitReferralNumberTextBox;
        private System.Windows.Forms.ComboBox visitSpecializationComboBox;
        private System.Windows.Forms.Button cancelVisitButton;
        private System.Windows.Forms.DataGridView visitsDataGridView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox specializationPictureBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button deleteSpecializationButton;
        private System.Windows.Forms.DataGridView specializationsDataGridView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button chartResetButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MonthCalendar chartMonthCalendar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chartDoctorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chartSpecializationComboBox;
    }
}