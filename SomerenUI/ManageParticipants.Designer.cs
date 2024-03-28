namespace SomerenUI
{
	partial class ManageParticipants
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
			lvParticipating = new System.Windows.Forms.ListView();
			lvParticipatingStudentNumber = new System.Windows.Forms.ColumnHeader();
			lvParticipatingStudentName = new System.Windows.Forms.ColumnHeader();
			btnAddParticipant = new System.Windows.Forms.Button();
			btnRmvParticipant = new System.Windows.Forms.Button();
			lvNotParticipating = new System.Windows.Forms.ListView();
			lvNotParticipatingStudentNumber = new System.Windows.Forms.ColumnHeader();
			lvNotParticipatingStudentName = new System.Windows.Forms.ColumnHeader();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			SuspendLayout();
			// 
			// lvParticipating
			// 
			lvParticipating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvParticipatingStudentNumber, lvParticipatingStudentName });
			lvParticipating.Location = new System.Drawing.Point(12, 32);
			lvParticipating.Name = "lvParticipating";
			lvParticipating.Size = new System.Drawing.Size(335, 406);
			lvParticipating.TabIndex = 0;
			lvParticipating.UseCompatibleStateImageBehavior = false;
			lvParticipating.View = System.Windows.Forms.View.Details;
			// 
			// lvParticipatingStudentNumber
			// 
			lvParticipatingStudentNumber.Text = "Student Number";
			lvParticipatingStudentNumber.Width = 125;
			// 
			// lvParticipatingStudentName
			// 
			lvParticipatingStudentName.Text = "Student Name";
			lvParticipatingStudentName.Width = 110;
			// 
			// btnAddParticipant
			// 
			btnAddParticipant.Location = new System.Drawing.Point(353, 374);
			btnAddParticipant.Name = "btnAddParticipant";
			btnAddParticipant.Size = new System.Drawing.Size(94, 29);
			btnAddParticipant.TabIndex = 2;
			btnAddParticipant.Text = "< ADD";
			btnAddParticipant.UseVisualStyleBackColor = true;
			// 
			// btnRmvParticipant
			// 
			btnRmvParticipant.Location = new System.Drawing.Point(353, 409);
			btnRmvParticipant.Name = "btnRmvParticipant";
			btnRmvParticipant.Size = new System.Drawing.Size(94, 29);
			btnRmvParticipant.TabIndex = 3;
			btnRmvParticipant.Text = "REMOVE >";
			btnRmvParticipant.UseVisualStyleBackColor = true;
			// 
			// lvNotParticipating
			// 
			lvNotParticipating.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvNotParticipatingStudentNumber, lvNotParticipatingStudentName });
			lvNotParticipating.Location = new System.Drawing.Point(453, 32);
			lvNotParticipating.Name = "lvNotParticipating";
			lvNotParticipating.Size = new System.Drawing.Size(335, 406);
			lvNotParticipating.TabIndex = 4;
			lvNotParticipating.UseCompatibleStateImageBehavior = false;
			lvNotParticipating.View = System.Windows.Forms.View.Details;
			// 
			// lvNotParticipatingStudentNumber
			// 
			lvNotParticipatingStudentNumber.Text = "Student Number";
			lvNotParticipatingStudentNumber.Width = 125;
			// 
			// lvNotParticipatingStudentName
			// 
			lvNotParticipatingStudentName.Text = "Student Name";
			lvNotParticipatingStudentName.Width = 110;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(12, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(153, 20);
			label1.TabIndex = 5;
			label1.Text = "Participating Students";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(453, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(182, 20);
			label2.TabIndex = 5;
			label2.Text = "Not Participating Students";
			// 
			// ManageParticipants
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(lvNotParticipating);
			Controls.Add(btnAddParticipant);
			Controls.Add(btnRmvParticipant);
			Controls.Add(lvParticipating);
			Name = "ManageParticipants";
			Text = "Manage Participants";
			Load += ManageParticipants_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ListView lvParticipating;
		private System.Windows.Forms.Button btnAddParticipant;
		private System.Windows.Forms.Button btnRmvParticipant;
		private System.Windows.Forms.ColumnHeader lvParticipatingStudentNumber;
		private System.Windows.Forms.ColumnHeader lvParticipatingStudentName;
		private System.Windows.Forms.ListView lvNotParticipating;
		private System.Windows.Forms.ColumnHeader lvNotParticipatingStudentNumber;
		private System.Windows.Forms.ColumnHeader lvNotParticipatingStudentName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}