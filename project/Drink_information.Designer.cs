
namespace project
{
    partial class Drink_information
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
            this.drink_data = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drink_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drink_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.save_drink = new System.Windows.Forms.Button();
            this.delete_drink = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Change_drink = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.drink_data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.OrangeRed;
            this.label10.Location = new System.Drawing.Point(652, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 37);
            this.label10.TabIndex = 99;
            this.label10.Text = "Drinks Record";
            // 
            // drink_data
            // 
            this.drink_data.AllowUserToAddRows = false;
            this.drink_data.AllowUserToDeleteRows = false;
            this.drink_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drink_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Drink_id,
            this.Drink_Name,
            this.Type,
            this.Quantity,
            this.Price,
            this.Action});
            this.drink_data.Location = new System.Drawing.Point(416, 86);
            this.drink_data.Name = "drink_data";
            this.drink_data.ReadOnly = true;
            this.drink_data.Size = new System.Drawing.Size(713, 335);
            this.drink_data.TabIndex = 98;
            this.drink_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drink_data_CellClick);
            this.drink_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drink_data_CellContentClick);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            // 
            // Drink_id
            // 
            this.Drink_id.HeaderText = "Drink_id";
            this.Drink_id.Name = "Drink_id";
            this.Drink_id.ReadOnly = true;
            // 
            // Drink_Name
            // 
            this.Drink_Name.HeaderText = "Drink_Name";
            this.Drink_Name.Name = "Drink_Name";
            this.Drink_Name.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
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
            // 
            // save_drink
            // 
            this.save_drink.BackColor = System.Drawing.Color.DarkGreen;
            this.save_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_drink.ForeColor = System.Drawing.SystemColors.Window;
            this.save_drink.Location = new System.Drawing.Point(484, 271);
            this.save_drink.Name = "save_drink";
            this.save_drink.Size = new System.Drawing.Size(93, 49);
            this.save_drink.TabIndex = 133;
            this.save_drink.Text = "Save";
            this.save_drink.UseVisualStyleBackColor = false;
            this.save_drink.Click += new System.EventHandler(this.save_bakery_Click);
            // 
            // delete_drink
            // 
            this.delete_drink.BackColor = System.Drawing.Color.Red;
            this.delete_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_drink.ForeColor = System.Drawing.SystemColors.Window;
            this.delete_drink.Location = new System.Drawing.Point(484, 328);
            this.delete_drink.Name = "delete_drink";
            this.delete_drink.Size = new System.Drawing.Size(93, 49);
            this.delete_drink.TabIndex = 132;
            this.delete_drink.Text = "Delete";
            this.delete_drink.UseVisualStyleBackColor = false;
            this.delete_drink.Click += new System.EventHandler(this.delete_drink_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(17, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(256, 26);
            this.textBox5.TabIndex = 131;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 130;
            this.label5.Text = "Drink Id";
            // 
            // Change_drink
            // 
            this.Change_drink.BackColor = System.Drawing.Color.OrangeRed;
            this.Change_drink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_drink.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_drink.ForeColor = System.Drawing.SystemColors.Window;
            this.Change_drink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Change_drink.Location = new System.Drawing.Point(62, 436);
            this.Change_drink.Name = "Change_drink";
            this.Change_drink.Size = new System.Drawing.Size(295, 49);
            this.Change_drink.TabIndex = 129;
            this.Change_drink.Text = "Change";
            this.Change_drink.UseVisualStyleBackColor = false;
            this.Change_drink.Click += new System.EventHandler(this.Change_drink_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(18, 278);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(255, 26);
            this.textBox6.TabIndex = 128;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(18, 222);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(255, 26);
            this.textBox7.TabIndex = 127;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(17, 160);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(256, 26);
            this.textBox8.TabIndex = 126;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(17, 108);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(256, 26);
            this.textBox9.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = " Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 123;
            this.label8.Text = "Drink Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 122;
            this.label9.Text = "Drink Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 134;
            this.label6.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(62, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 335);
            this.panel1.TabIndex = 135;
            // 
            // Drink_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Change_drink);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.drink_data);
            this.Controls.Add(this.delete_drink);
            this.Controls.Add(this.save_drink);
            this.Name = "Drink_information";
            this.Size = new System.Drawing.Size(1156, 520);
            this.Load += new System.EventHandler(this.Drink_information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drink_data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView drink_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drink_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drink_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.Button save_drink;
        private System.Windows.Forms.Button delete_drink;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Change_drink;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
