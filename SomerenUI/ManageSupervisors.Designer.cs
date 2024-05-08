namespace SomerenUI
{
	partial class ManageSupervisors
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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
			lvParticipatingSupervisors = new System.Windows.Forms.ListView();
			lvParticipatingSupervisorName = new System.Windows.Forms.ColumnHeader();
			lvParticipatingSupervisorLastName = new System.Windows.Forms.ColumnHeader();
			btnAddSupervisor = new System.Windows.Forms.Button();
			btnRmvSupervisor = new System.Windows.Forms.Button();
			lvNotParticipatingSupervisors = new System.Windows.Forms.ListView();
			lvNotParticipatingSupervisorName = new System.Windows.Forms.ColumnHeader();
			lvNotParticipatingSupervisorLastName = new System.Windows.Forms.ColumnHeader();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// lvParticipatingSupervisors
			// 
			lvParticipatingSupervisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvParticipatingSupervisorName, lvParticipatingSupervisorLastName });
			lvParticipatingSupervisors.FullRowSelect = true;
            lvParticipatingSupervisors.Location = new System.Drawing.Point(12, 25);
            lvParticipatingSupervisors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			lvParticipatingSupervisors.Name = "lvParticipatingSupervisors";
            lvParticipatingSupervisors.Size = new System.Drawing.Size(294, 306);
			lvParticipatingSupervisors.TabIndex = 1;
			lvParticipatingSupervisors.UseCompatibleStateImageBehavior = false;
			lvParticipatingSupervisors.View = System.Windows.Forms.View.Details;
			// 
			// lvParticipatingSupervisorName
			// 
			lvParticipatingSupervisorName.Text = "Name";
			lvParticipatingSupervisorName.Width = 125;
			// 
			// lvParticipatingSupervisorLastName
			// 
			lvParticipatingSupervisorLastName.Text = "Last Name";
			lvParticipatingSupervisorLastName.Width = 120;
			// 
			// btnAddSupervisor
			// 
            btnAddSupervisor.Location = new System.Drawing.Point(312, 282);
            btnAddSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btnAddSupervisor.Name = "btnAddSupervisor";
            btnAddSupervisor.Size = new System.Drawing.Size(82, 22);
			btnAddSupervisor.TabIndex = 3;
			btnAddSupervisor.Text = "< ADD";
			btnAddSupervisor.UseVisualStyleBackColor = true;
			btnAddSupervisor.Click += btnAddSupervisor_Click;
			// 
			// btnRmvSupervisor
			// 
            btnRmvSupervisor.Location = new System.Drawing.Point(312, 308);
            btnRmvSupervisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			btnRmvSupervisor.Name = "btnRmvSupervisor";
            btnRmvSupervisor.Size = new System.Drawing.Size(82, 22);
			btnRmvSupervisor.TabIndex = 4;
			btnRmvSupervisor.Text = "REMOVE >";
			btnRmvSupervisor.UseVisualStyleBackColor = true;
			btnRmvSupervisor.Click += btnRmvSupervisor_Click;
			// 
			// lvNotParticipatingSupervisors
			// 
			lvNotParticipatingSupervisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvNotParticipatingSupervisorName, lvNotParticipatingSupervisorLastName });
			lvNotParticipatingSupervisors.FullRowSelect = true;
			lvNotParticipatingSupervisors.Items.AddRange(new System.Windows.Forms.ListViewItem[] { listViewItem1 });
            lvNotParticipatingSupervisors.Location = new System.Drawing.Point(400, 26);
            lvNotParticipatingSupervisors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			lvNotParticipatingSupervisors.Name = "lvNotParticipatingSupervisors";
            lvNotParticipatingSupervisors.Size = new System.Drawing.Size(294, 306);
			lvNotParticipatingSupervisors.TabIndex = 5;
			lvNotParticipatingSupervisors.UseCompatibleStateImageBehavior = false;
			lvNotParticipatingSupervisors.View = System.Windows.Forms.View.Details;
			// 
			// lvNotParticipatingSupervisorName
			// 
			lvNotParticipatingSupervisorName.Text = "Name";
			lvNotParticipatingSupervisorName.Width = 125;
			// 
			// lvNotParticipatingSupervisorLastName
			// 
			lvNotParticipatingSupervisorLastName.Text = "Last Name";
			lvNotParticipatingSupervisorLastName.Width = 120;
			// 
			// label1
			// 
			label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 8);
			label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 15);
			label1.TabIndex = 6;
			label1.Text = "Participating Supervisors";
			// 
			// label2
			// 
			label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(400, 9);
			label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 15);
			label2.TabIndex = 7;
			label2.Text = "Not Participating Supervisors";
			// 
			// ManageSupervisors
			// 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(710, 346);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lvNotParticipatingSupervisors);
			Controls.Add(btnRmvSupervisor);
			Controls.Add(btnAddSupervisor);
			Controls.Add(lvParticipatingSupervisors);
			Name = "ManageSupervisors";
			Text = "Form1";
			Load += ManageSupervisors_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListView lvParticipatingSupervisors;
		private System.Windows.Forms.ColumnHeader lvParticipatingSupervisorName;
		private System.Windows.Forms.ColumnHeader lvParticipatingStudentName;
		private System.Windows.Forms.Button btnAddSupervisor;
		private System.Windows.Forms.Button btnRmvSupervisor;
		private System.Windows.Forms.ListView lvNotParticipatingSupervisors;
		private System.Windows.Forms.ColumnHeader lvNotParticipatingSupervisorName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader lvParticipatingSupervisorLastName;
		private System.Windows.Forms.ColumnHeader lvNotParticipatingSupervisorLastName;
	}
}