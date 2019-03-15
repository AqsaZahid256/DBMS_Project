namespace ProjectB
{
	partial class Manage_Rubrics
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
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CloId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Deta = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DataUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Updation = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
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
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CloId,
            this.Details,
            this.Edit,
            this.Delete});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.Location = new System.Drawing.Point(0, 103);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1200, 416);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// CloId
			// 
			this.CloId.HeaderText = "CloId";
			this.CloId.Name = "CloId";
			// 
			// Details
			// 
			this.Details.HeaderText = "Details";
			this.Details.Name = "Details";
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
			// RegistrationNumber
			// 
			this.RegistrationNumber.HeaderText = "Registration_No";
			this.RegistrationNumber.Name = "RegistrationNumber";
			// 
			// Email
			// 
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			// 
			// Contact
			// 
			this.Contact.HeaderText = "Contact";
			this.Contact.Name = "Contact";
			// 
			// LastName
			// 
			this.LastName.HeaderText = "Last Name";
			this.LastName.Name = "LastName";
			// 
			// Status
			// 
			this.Status.HeaderText = "Status";
			this.Status.Name = "Status";
			// 
			// dataGridViewButtonColumn2
			// 
			this.dataGridViewButtonColumn2.HeaderText = "Edit";
			this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
			this.dataGridViewButtonColumn2.UseColumnTextForButtonValue = true;
			// 
			// dataGridViewButtonColumn1
			// 
			this.dataGridViewButtonColumn1.HeaderText = "Delete";
			this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
			this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
			// 
			// FirstName
			// 
			this.FirstName.HeaderText = "First Name";
			this.FirstName.Name = "FirstName";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(88, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "CloId";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(88, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Details";
			// 
			// Deta
			// 
			this.Deta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Deta.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.Deta.Location = new System.Drawing.Point(14, 110);
			this.Deta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Deta.Name = "Deta";
			this.Deta.Size = new System.Drawing.Size(217, 22);
			this.Deta.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "9"});
			this.comboBox1.Location = new System.Drawing.Point(14, 44);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(217, 23);
			this.comboBox1.TabIndex = 9;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(14, 154);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(105, 27);
			this.button2.TabIndex = 20;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(134, 154);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 27);
			this.button1.TabIndex = 19;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridViewButtonColumn3
			// 
			this.dataGridViewButtonColumn3.HeaderText = "Delete";
			this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
			// 
			// dataGridViewButtonColumn4
			// 
			this.dataGridViewButtonColumn4.HeaderText = "Edit";
			this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
			// 
			// DataUpdated
			// 
			this.DataUpdated.HeaderText = "DataUpdated";
			this.DataUpdated.Name = "DataUpdated";
			// 
			// DataCreated
			// 
			this.DataCreated.HeaderText = "Data Created";
			this.DataCreated.Name = "DataCreated";
			// 
			// Name
			// 
			this.Name.HeaderText = "Name";
			this.Name.Name = "Name";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(1, 195);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(258, 291);
			this.panel1.TabIndex = 4;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.comboBox1);
			this.panel4.Controls.Add(this.button1);
			this.panel4.Controls.Add(this.button2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.Deta);
			this.panel4.Location = new System.Drawing.Point(7, 68);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(244, 223);
			this.panel4.TabIndex = 25;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Teal;
			this.panel3.Controls.Add(this.Updation);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(258, 55);
			this.panel3.TabIndex = 24;
			// 
			// Updation
			// 
			this.Updation.AutoSize = true;
			this.Updation.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Updation.ForeColor = System.Drawing.Color.White;
			this.Updation.Location = new System.Drawing.Point(4, 15);
			this.Updation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Updation.Name = "Updation";
			this.Updation.Size = new System.Drawing.Size(254, 21);
			this.Updation.TabIndex = 21;
			this.Updation.Text = "UPDATION OF RUBRICS";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(1, 10);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(282, 31);
			this.label3.TabIndex = 22;
			this.label3.Text = "MANAGE RUBRICS";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1200, 55);
			this.panel2.TabIndex = 23;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label8.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(290, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 31);
			this.label8.TabIndex = 25;
			this.label8.Text = "HOME";
			this.label8.Click += new System.EventHandler(this.label8_Click);
			// 
			// Manage_Rubrics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(1200, 519);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			
			this.Text = "Manage_Rubrics";
			this.Load += new System.EventHandler(this.Manage_Rubrics_Load);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Deta;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
		private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataUpdated;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataCreated;
		private System.Windows.Forms.DataGridViewTextBoxColumn Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label Updation;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CloId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Details;
		private System.Windows.Forms.DataGridViewButtonColumn Edit;
		private System.Windows.Forms.DataGridViewButtonColumn Delete;
	}
}