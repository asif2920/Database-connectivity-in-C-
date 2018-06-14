namespace EmployeeManagement
{
    partial class InsertEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxEmployeeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(127, 30);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(127, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(127, 113);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sex";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBoxSex.Location = new System.Drawing.Point(127, 150);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSex.TabIndex = 8;
            // 
            // comboBoxEmployeeType
            // 
            this.comboBoxEmployeeType.FormattingEnabled = true;
            this.comboBoxEmployeeType.Items.AddRange(new object[] {
            "Regular",
            "Part Time"});
            this.comboBoxEmployeeType.Location = new System.Drawing.Point(127, 195);
            this.comboBoxEmployeeType.Name = "comboBoxEmployeeType";
            this.comboBoxEmployeeType.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEmployeeType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rank";
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "Staff",
            "Management Trainee",
            "Senior Executive",
            "Assistant Manager",
            "Manager",
            "Senior Manager",
            "Deputy General Manager",
            "General Manager",
            "Executive Director"});
            this.comboBoxRank.Location = new System.Drawing.Point(468, 70);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRank.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Department";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "IT",
            "Transport",
            "Shipping Line",
            "Media",
            "Beverage",
            "Hotel",
            "Food",
            "Finance",
            "Marketing",
            "Logistics"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(468, 27);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDepartment.TabIndex = 14;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(263, 267);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(75, 23);
            this.buttonadd.TabIndex = 16;
            this.buttonadd.Text = "Add";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(373, 267);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // InsertEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxRank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEmployeeType);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "InsertEmployee";
            this.Text = "InsertEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxEmployeeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonBack;
    }
}