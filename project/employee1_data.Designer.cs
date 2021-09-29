
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
            this.Employee_record = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Update1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Employee_record)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Employee_record
            // 
            this.Employee_record.AllowUserToAddRows = false;
            this.Employee_record.AllowUserToDeleteRows = false;
            this.Employee_record.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.Employee_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employee_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Employee_Id,
            this.First_name,
            this.Last_name,
            this.Address,
            this.Contact_no,
            this.Gender,
            this.Type,
            this.Shift,
            this.Salary,
            this.Action});
            this.Employee_record.Location = new System.Drawing.Point(263, 80);
            this.Employee_record.Name = "Employee_record";
            this.Employee_record.ReadOnly = true;
            this.Employee_record.Size = new System.Drawing.Size(873, 422);
            this.Employee_record.TabIndex = 86;
            this.Employee_record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Employee_record_CellClick);
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
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 60;
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
            // Action
            // 
            this.Action.HeaderText = "  Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 70;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.comboBox2.Location = new System.Drawing.Point(130, 340);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 21);
            this.comboBox2.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 16);
            this.label9.TabIndex = 84;
            this.label9.Text = "Shift";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chef",
            "Waiter",
            "Cashier",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(3, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 82;
            this.label1.Text = "Employee Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Last_name";
            // 
            // Update1
            // 
            this.Update1.BackColor = System.Drawing.Color.Gold;
            this.Update1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update1.ForeColor = System.Drawing.SystemColors.Window;
            this.Update1.Location = new System.Drawing.Point(177, 431);
            this.Update1.Name = "Update1";
            this.Update1.Size = new System.Drawing.Size(76, 44);
            this.Update1.TabIndex = 79;
            this.Update1.Text = "Update";
            this.Update1.UseVisualStyleBackColor = false;
            this.Update1.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 66;
            // 
            // Remove1
            // 
            this.Remove1.BackColor = System.Drawing.Color.Red;
            this.Remove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove1.ForeColor = System.Drawing.SystemColors.Window;
            this.Remove1.Location = new System.Drawing.Point(82, 431);
            this.Remove1.Name = "Remove1";
            this.Remove1.Size = new System.Drawing.Size(87, 44);
            this.Remove1.TabIndex = 78;
            this.Remove1.Text = "Remove";
            this.Remove1.UseVisualStyleBackColor = false;
            this.Remove1.Click += new System.EventHandler(this.button6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 81;
            this.label8.Text = "Employee Id";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(5, 80);
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
            this.Save1.Location = new System.Drawing.Point(6, 431);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(71, 44);
            this.Save1.TabIndex = 77;
            this.Save1.Text = "Save";
            this.Save1.UseVisualStyleBackColor = false;
            this.Save1.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 76;
            this.label7.Text = "Salary";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(5, 391);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(248, 22);
            this.textBox6.TabIndex = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male_select);
            this.groupBox1.Controls.Add(this.custom_select);
            this.groupBox1.Controls.Add(this.female_select);
            this.groupBox1.Location = new System.Drawing.Point(5, 263);
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
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Contact No";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(5, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(248, 22);
            this.textBox4.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(5, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(248, 22);
            this.textBox3.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "First_name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(546, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 37);
            this.label10.TabIndex = 87;
            this.label10.Text = "Employee Record";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // employee1_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Employee_record);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Update1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Remove1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "employee1_data";
            this.Size = new System.Drawing.Size(1156, 520);
            this.Load += new System.EventHandler(this.employee1_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_record)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Employee_record;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}
