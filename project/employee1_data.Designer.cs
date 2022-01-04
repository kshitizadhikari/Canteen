
namespace project
{
    partial class employee1_data
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee1_data));
            this.Employee_record = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update1 = new System.Windows.Forms.Button();
            this.Remove1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Save1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.male_select = new System.Windows.Forms.RadioButton();
            this.custom_select = new System.Windows.Forms.RadioButton();
            this.female_select = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.employee_photo2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.employee_photo1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_record)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_photo2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_photo1)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_record
            // 
            this.Employee_record.AllowUserToAddRows = false;
            this.Employee_record.AllowUserToDeleteRows = false;
            this.Employee_record.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Employee_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Employee_Id,
            this.First_name,
            this.Last_name,
            this.Gender,
            this.Action,
            this.Address,
            this.Contact_no,
            this.Type,
            this.Shift,
            this.Salary,
            this.Employee_photo});
            this.Employee_record.Location = new System.Drawing.Point(359, 86);
            this.Employee_record.Name = "Employee_record";
            this.Employee_record.ReadOnly = true;
            this.Employee_record.Size = new System.Drawing.Size(468, 493);
            this.Employee_record.TabIndex = 86;
            this.Employee_record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_record_CellClick);
            this.Employee_record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_record_CellContentClick);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 30;
            // 
            // Employee_Id
            // 
            this.Employee_Id.HeaderText = "Employee_Id";
            this.Employee_Id.Name = "Employee_Id";
            this.Employee_Id.ReadOnly = true;
            this.Employee_Id.Width = 70;
            // 
            // First_name
            // 
            this.First_name.HeaderText = "   First_name";
            this.First_name.Name = "First_name";
            this.First_name.ReadOnly = true;
            // 
            // Last_name
            // 
            this.Last_name.HeaderText = "   Last_name";
            this.Last_name.Name = "Last_name";
            this.Last_name.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 60;
            // 
            // Action
            // 
            this.Action.HeaderText = "  Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 70;
            // 
            // Address
            // 
            this.Address.HeaderText = "   Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Contact_no
            // 
            this.Contact_no.HeaderText = "   Contact_no";
            this.Contact_no.Name = "Contact_no";
            this.Contact_no.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 50;
            // 
            // Shift
            // 
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            this.Shift.Width = 50;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "    Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Employee_photo
            // 
            this.Employee_photo.HeaderText = "Employee_photo";
            this.Employee_photo.Name = "Employee_photo";
            this.Employee_photo.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chef",
            "Waiter",
            "Cashier",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(12, 436);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Employee Type";
            // 
            // Update1
            // 
            this.Update1.BackColor = System.Drawing.Color.Gold;
            this.Update1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update1.ForeColor = System.Drawing.SystemColors.Window;
            this.Update1.Location = new System.Drawing.Point(248, 612);
            this.Update1.Name = "Update1";
            this.Update1.Size = new System.Drawing.Size(90, 44);
            this.Update1.TabIndex = 79;
            this.Update1.Text = "Update";
            this.Update1.UseVisualStyleBackColor = false;
            this.Update1.Click += new System.EventHandler(this.button7_Click);
            // 
            // Remove1
            // 
            this.Remove1.BackColor = System.Drawing.Color.Red;
            this.Remove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove1.ForeColor = System.Drawing.SystemColors.Window;
            this.Remove1.Location = new System.Drawing.Point(152, 612);
            this.Remove1.Name = "Remove1";
            this.Remove1.Size = new System.Drawing.Size(90, 44);
            this.Remove1.TabIndex = 78;
            this.Remove1.Text = "Remove";
            this.Remove1.UseVisualStyleBackColor = false;
            this.Remove1.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Employee Id";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(14, 38);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(248, 22);
            this.textBox7.TabIndex = 80;
            // 
            // Save1
            // 
            this.Save1.BackColor = System.Drawing.Color.ForestGreen;
            this.Save1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save1.ForeColor = System.Drawing.SystemColors.Window;
            this.Save1.Location = new System.Drawing.Point(64, 612);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(84, 44);
            this.Save1.TabIndex = 77;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = false;
            this.Save1.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Salary";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(15, 488);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 22);
            this.textBox6.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male_select);
            this.groupBox1.Controls.Add(this.custom_select);
            this.groupBox1.Controls.Add(this.female_select);
            this.groupBox1.Location = new System.Drawing.Point(15, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 46);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // male_select
            // 
            this.male_select.AutoSize = true;
            this.male_select.Location = new System.Drawing.Point(6, 18);
            this.male_select.Name = "male_select";
            this.male_select.Size = new System.Drawing.Size(48, 17);
            this.male_select.TabIndex = 9;
            this.male_select.TabStop = true;
            this.male_select.Text = "Male";
            this.male_select.UseVisualStyleBackColor = true;
            // 
            // custom_select
            // 
            this.custom_select.AutoSize = true;
            this.custom_select.Location = new System.Drawing.Point(172, 18);
            this.custom_select.Name = "custom_select";
            this.custom_select.Size = new System.Drawing.Size(60, 17);
            this.custom_select.TabIndex = 10;
            this.custom_select.TabStop = true;
            this.custom_select.Text = "Custom";
            this.custom_select.UseVisualStyleBackColor = true;
            // 
            // female_select
            // 
            this.female_select.AutoSize = true;
            this.female_select.Location = new System.Drawing.Point(82, 19);
            this.female_select.Name = "female_select";
            this.female_select.Size = new System.Drawing.Size(59, 17);
            this.female_select.TabIndex = 8;
            this.female_select.TabStop = true;
            this.female_select.Text = "Female";
            this.female_select.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Contact No";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 172);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 22);
            this.textBox4.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 128);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "First_name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 64;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(690, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 37);
            this.label10.TabIndex = 87;
            this.label10.Text = "Employee Record";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.textBox10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.employee_photo2);
            this.panel1.Location = new System.Drawing.Point(827, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 493);
            this.panel1.TabIndex = 88;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(120, 451);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(157, 22);
            this.textBox5.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(56, 451);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 20);
            this.label18.TabIndex = 17;
            this.label18.Text = "Salary";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(67, 415);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Shift";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(120, 413);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(157, 22);
            this.textBox14.TabIndex = 14;
            // 
            // textBox13
            // 
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(120, 380);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(157, 22);
            this.textBox13.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(66, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Type";
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(120, 345);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(157, 22);
            this.textBox12.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(46, 347);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 9;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(120, 306);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(157, 22);
            this.textBox11.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Contact";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(120, 270);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(157, 22);
            this.textBox10.TabIndex = 6;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Address";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(120, 237);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(157, 22);
            this.textBox9.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Employee Id";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(120, 203);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(157, 22);
            this.textBox8.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(58, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Name";
            // 
            // employee_photo2
            // 
            this.employee_photo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_photo2.Location = new System.Drawing.Point(93, 48);
            this.employee_photo2.Name = "employee_photo2";
            this.employee_photo2.Size = new System.Drawing.Size(123, 131);
            this.employee_photo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employee_photo2.TabIndex = 0;
            this.employee_photo2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(139, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Last_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Shift";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox2.Location = new System.Drawing.Point(139, 436);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 21);
            this.comboBox2.TabIndex = 85;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.employee_photo1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(62, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 520);
            this.panel2.TabIndex = 89;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(69, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 28);
            this.button1.TabIndex = 91;
            this.button1.Text = "Insert  Photo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employee_photo1
            // 
            this.employee_photo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_photo1.Image = ((System.Drawing.Image)(resources.GetObject("employee_photo1.Image")));
            this.employee_photo1.Location = new System.Drawing.Point(69, 251);
            this.employee_photo1.Name = "employee_photo1";
            this.employee_photo1.Size = new System.Drawing.Size(111, 110);
            this.employee_photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.employee_photo1.TabIndex = 90;
            this.employee_photo1.TabStop = false;
            // 
            // employee1_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Employee_record);
            this.Controls.Add(this.Update1);
            this.Controls.Add(this.Remove1);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.panel2);
            this.Name = "employee1_data";
            this.Size = new System.Drawing.Size(1249, 668);
            this.Load += new System.EventHandler(this.employee1_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_record)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_photo2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employee_photo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employee_record;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update1;
        private System.Windows.Forms.Button Remove1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton male_select;
        private System.Windows.Forms.RadioButton custom_select;
        private System.Windows.Forms.RadioButton female_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox employee_photo2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox employee_photo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_photo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label18;
    }
}
