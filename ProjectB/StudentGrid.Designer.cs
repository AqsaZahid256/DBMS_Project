namespace ProjectB
{
	partial class StudentGrid
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Contact,
            this.Email,
            this.RegistrationNumber,
            this.Status,
            this.Edit,
            this.Delete});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.GridColor = System.Drawing.Color.Teal;
			this.dataGridView1.Location = new System.Drawing.Point(0, 74);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Size = new System.Drawing.Size(1200, 528);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(1, 121);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(318, 449);
			this.panel1.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.textBox1);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.textBox2);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.textBox3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.textBox4);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.textBox5);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Location = new System.Drawing.Point(3, 56);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(315, 381);
			this.panel4.TabIndex = 27;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "InActive"});
			this.comboBox1.Location = new System.Drawing.Point(24, 307);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(263, 23);
			this.comboBox1.TabIndex = 12;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Silver;
			this.button2.Location = new System.Drawing.Point(36, 351);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 27);
			this.button2.TabIndex = 20;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.Location = new System.Drawing.Point(175, 351);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 27);
			this.button1.TabIndex = 19;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox1.Location = new System.Drawing.Point(24, 257);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(263, 22);
			this.textBox1.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(132, 285);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 15);
			this.label6.TabIndex = 11;
			this.label6.Text = "Status";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox2.Location = new System.Drawing.Point(24, 204);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(263, 22);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(127, 134);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Contact";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox3.Location = new System.Drawing.Point(24, 152);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(263, 22);
			this.textBox3.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(120, 81);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "LastName";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox4.Location = new System.Drawing.Point(24, 99);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(263, 22);
			this.textBox4.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(132, 183);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Email";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBox5.Location = new System.Drawing.Point(24, 45);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(263, 22);
			this.textBox5.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(82, 235);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 15);
			this.label5.TabIndex = 10;
			this.label5.Text = "RegistrationNumber";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(117, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "FirstName";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Teal;
			this.panel3.Controls.Add(this.label7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(318, 55);
			this.panel3.TabIndex = 24;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(37, 16);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(258, 21);
			this.label7.TabIndex = 21;
			this.label7.Text = "UPDATION OF STUDENT";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(4, 12);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(291, 31);
			this.label8.TabIndex = 22;
			this.label8.Text = "MANAGE STUDENT";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1200, 55);
			this.panel2.TabIndex = 23;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label9.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(302, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 31);
			this.label9.TabIndex = 28;
			this.label9.Text = "HOME";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			// 
			// Contact
			// 
			this.Contact.HeaderText = "Contact";
			this.Contact.Name = "Contact";
			// 
			// Email
			// 
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			// 
			// RegistrationNumber
			// 
			this.RegistrationNumber.HeaderText = "Registration_No";
			this.RegistrationNumber.Name = "RegistrationNumber";
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			// 
			// Edit
			// 
			this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Edit.HeaderText = "Update";
			this.Edit.Name = "Edit";
			this.Edit.Text = "Update";
			this.Edit.UseColumnTextForButtonValue = true;
			// 
			// Delete
			// 
			this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Delete.HeaderText = "Delete";
			this.Delete.Name = "Delete";
			this.Delete.Text = "Delete";
			this.Delete.UseColumnTextForButtonValue = true;
			// 
			// StudentGrid
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1200, 602);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "StudentGrid";
			this.Text = "StudentGrid";
			this.Load += new System.EventHandler(this.StudentGrid_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}