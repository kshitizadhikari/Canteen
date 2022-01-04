
namespace project
{
    partial class bakery_information
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
            this.label10 = new System.Windows.Forms.Label();
            this.bakery_data = new System.Windows.Forms.DataGridView();
            this.save_bakery = new System.Windows.Forms.Button();
            this.delete_bakery = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Change_bakery = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bakery_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bakery_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bakery_data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(656, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 37);
            this.label10.TabIndex = 99;
            this.label10.Text = "Bakery Record";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // bakery_data
            // 
            this.bakery_data.AllowUserToAddRows = false;
            this.bakery_data.AllowUserToDeleteRows = false;
            this.bakery_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bakery_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Bakery_id,
            this.Bakery_Name,
            this.Type,
            this.Quantity,
            this.Price,
            this.Action});
            this.bakery_data.Location = new System.Drawing.Point(396, 86);
            this.bakery_data.Name = "bakery_data";
            this.bakery_data.ReadOnly = true;
            this.bakery_data.Size = new System.Drawing.Size(723, 335);
            this.bakery_data.TabIndex = 98;
            this.bakery_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bakery_data_CellClick);
            // 
            // save_bakery
            // 
            this.save_bakery.BackColor = System.Drawing.Color.DarkGreen;
            this.save_bakery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bakery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_bakery.ForeColor = System.Drawing.SystemColors.Window;
            this.save_bakery.Location = new System.Drawing.Point(62, 439);
            this.save_bakery.Name = "save_bakery";
            this.save_bakery.Size = new System.Drawing.Size(91, 49);
            this.save_bakery.TabIndex = 121;
            this.save_bakery.Text = "Save";
            this.save_bakery.UseVisualStyleBackColor = false;
            this.save_bakery.Click += new System.EventHandler(this.save_food_Click);
            // 
            // delete_bakery
            // 
            this.delete_bakery.BackColor = System.Drawing.Color.Red;
            this.delete_bakery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bakery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bakery.ForeColor = System.Drawing.SystemColors.Window;
            this.delete_bakery.Location = new System.Drawing.Point(168, 439);
            this.delete_bakery.Name = "delete_bakery";
            this.delete_bakery.Size = new System.Drawing.Size(94, 49);
            this.delete_bakery.TabIndex = 120;
            this.delete_bakery.Text = "Delete";
            this.delete_bakery.UseVisualStyleBackColor = false;
            this.delete_bakery.Click += new System.EventHandler(this.delete_bakery_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(25, 60);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(256, 26);
            this.textBox5.TabIndex = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 118;
            this.label5.Text = "Bakery Id";
            // 
            // Change_bakery
            // 
            this.Change_bakery.BackColor = System.Drawing.Color.OrangeRed;
            this.Change_bakery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_bakery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_bakery.ForeColor = System.Drawing.SystemColors.Window;
            this.Change_bakery.Location = new System.Drawing.Point(282, 439);
            this.Change_bakery.Name = "Change_bakery";
            this.Change_bakery.Size = new System.Drawing.Size(92, 49);
            this.Change_bakery.TabIndex = 117;
            this.Change_bakery.Text = "Change";
            this.Change_bakery.UseVisualStyleBackColor = false;
            this.Change_bakery.Click += new System.EventHandler(this.Change_bakery_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(26, 277);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(255, 26);
            this.textBox6.TabIndex = 116;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(26, 226);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(255, 26);
            this.textBox7.TabIndex = 115;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(25, 164);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(256, 26);
            this.textBox8.TabIndex = 114;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(25, 112);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(256, 26);
            this.textBox9.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 112;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 111;
            this.label7.Text = " Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Bakery Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 109;
            this.label9.Text = "Bakery Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(62, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 335);
            this.panel1.TabIndex = 122;
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 30;
            // 
            // Bakery_id
            // 
            this.Bakery_id.HeaderText = "Bakery_id";
            this.Bakery_id.Name = "Bakery_id";
            this.Bakery_id.ReadOnly = true;
            // 
            // Bakery_Name
            // 
            this.Bakery_Name.HeaderText = "Bakery_Name";
            this.Bakery_Name.Name = "Bakery_Name";
            this.Bakery_Name.ReadOnly = true;
            this.Bakery_Name.Width = 150;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 50;
            // 
            // bakery_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_bakery);
            this.Controls.Add(this.delete_bakery);
            this.Controls.Add(this.Change_bakery);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bakery_data);
            this.Name = "bakery_information";
            this.Size = new System.Drawing.Size(1156, 520);
            this.Load += new System.EventHandler(this.bakery_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakery_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView bakery_data;
        private System.Windows.Forms.Button save_bakery;
        private System.Windows.Forms.Button delete_bakery;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Change_bakery;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakery_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bakery_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}
