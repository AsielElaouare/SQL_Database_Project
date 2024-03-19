namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			pnlDashboard = new System.Windows.Forms.Panel();
			lblDashboard = new System.Windows.Forms.Label();
			pnlStudents = new System.Windows.Forms.Panel();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			listViewStudents = new System.Windows.Forms.ListView();
			studentNumber = new System.Windows.Forms.ColumnHeader();
			studentFirstName = new System.Windows.Forms.ColumnHeader();
			studentLastName = new System.Windows.Forms.ColumnHeader();
			studentClass = new System.Windows.Forms.ColumnHeader();
			studentPhoneNumber = new System.Windows.Forms.ColumnHeader();
			label1 = new System.Windows.Forms.Label();
			pnlRooms = new System.Windows.Forms.Panel();
			pictureBox4 = new System.Windows.Forms.PictureBox();
			listViewRooms = new System.Windows.Forms.ListView();
			RoomId = new System.Windows.Forms.ColumnHeader();
			RoomName = new System.Windows.Forms.ColumnHeader();
			Roomtype = new System.Windows.Forms.ColumnHeader();
			RoomSize = new System.Windows.Forms.ColumnHeader();
			label4 = new System.Windows.Forms.Label();
			pnlLecturers = new System.Windows.Forms.Panel();
			pictureBox2 = new System.Windows.Forms.PictureBox();
			listViewLecturers = new System.Windows.Forms.ListView();
			lecturerId = new System.Windows.Forms.ColumnHeader();
			lecturerFirstName = new System.Windows.Forms.ColumnHeader();
			lecturerLastName = new System.Windows.Forms.ColumnHeader();
			lecturerAge = new System.Windows.Forms.ColumnHeader();
			lecturerPhoneNumber = new System.Windows.Forms.ColumnHeader();
			label2 = new System.Windows.Forms.Label();
			pnlActivities = new System.Windows.Forms.Panel();
			pictureBox3 = new System.Windows.Forms.PictureBox();
			listViewActivities = new System.Windows.Forms.ListView();
			ActivityId = new System.Windows.Forms.ColumnHeader();
			ActivityName = new System.Windows.Forms.ColumnHeader();
			ActivityDay = new System.Windows.Forms.ColumnHeader();
			ActivityBeginTime = new System.Windows.Forms.ColumnHeader();
			ActivityEndTime = new System.Windows.Forms.ColumnHeader();
			label3 = new System.Windows.Forms.Label();
			menuStrip1.SuspendLayout();
			pnlDashboard.SuspendLayout();
			pnlStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			pnlRooms.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			pnlLecturers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			pnlActivities.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			menuStrip1.Size = new System.Drawing.Size(1099, 30);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// dashboardToolStripMenuItem
			// 
			dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
			dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
			dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
			dashboardToolStripMenuItem.Text = "Application";
			// 
			// dashboardToolStripMenuItem1
			// 
			dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
			dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
			dashboardToolStripMenuItem1.Text = "Dashboard";
			dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// studentsToolStripMenuItem
			// 
			studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
			studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
			studentsToolStripMenuItem.Text = "Students";
			studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
			// 
			// lecturersToolStripMenuItem
			// 
			lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
			lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
			lecturersToolStripMenuItem.Text = "Lecturers";
			lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
			// 
			// activitiesToolStripMenuItem
			// 
			activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
			activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
			activitiesToolStripMenuItem.Text = "Activities";
			activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
			// 
			// roomsToolStripMenuItem
			// 
			roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
			roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
			roomsToolStripMenuItem.Text = "Rooms";
			roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
			// 
			// pnlDashboard
			// 
			pnlDashboard.Controls.Add(lblDashboard);
			pnlDashboard.Location = new System.Drawing.Point(14, 36);
			pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pnlDashboard.Name = "pnlDashboard";
			pnlDashboard.Size = new System.Drawing.Size(1072, 621);
			pnlDashboard.TabIndex = 1;
			// 
			// lblDashboard
			// 
			lblDashboard.AutoSize = true;
			lblDashboard.Location = new System.Drawing.Point(15, 17);
			lblDashboard.Name = "lblDashboard";
			lblDashboard.Size = new System.Drawing.Size(262, 20);
			lblDashboard.TabIndex = 0;
			lblDashboard.Text = "Welcome to the Someren Application!";
			// 
			// pnlStudents
			// 
			pnlStudents.Controls.Add(pictureBox1);
			pnlStudents.Controls.Add(listViewStudents);
			pnlStudents.Controls.Add(label1);
			pnlStudents.Location = new System.Drawing.Point(14, 36);
			pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pnlStudents.Name = "pnlStudents";
			pnlStudents.Size = new System.Drawing.Size(1072, 621);
			pnlStudents.TabIndex = 2;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(920, 0);
			pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(149, 164);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// listViewStudents
			// 
			listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { studentNumber, studentFirstName, studentLastName, studentClass, studentPhoneNumber });
			listViewStudents.Location = new System.Drawing.Point(18, 56);
			listViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listViewStudents.Name = "listViewStudents";
			listViewStudents.Size = new System.Drawing.Size(875, 408);
			listViewStudents.TabIndex = 1;
			listViewStudents.UseCompatibleStateImageBehavior = false;
			listViewStudents.View = System.Windows.Forms.View.Details;
			// 
			// studentNumber
			// 
			studentNumber.Text = "Student Number";
			// 
			// studentFirstName
			// 
			studentFirstName.Text = "First Name";
			studentFirstName.Width = 150;
			// 
			// studentLastName
			// 
			studentLastName.Text = "Last Name";
			studentLastName.Width = 150;
			// 
			// studentClass
			// 
			studentClass.Text = "Class";
			studentClass.Width = 150;
			// 
			// studentPhoneNumber
			// 
			studentPhoneNumber.Text = "Phone Number";
			studentPhoneNumber.Width = 150;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label1.Location = new System.Drawing.Point(15, 9);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(134, 41);
			label1.TabIndex = 0;
			label1.Text = "Students";
			// 
			// pnlRooms
			// 
			pnlRooms.Controls.Add(pictureBox4);
			pnlRooms.Controls.Add(listViewRooms);
			pnlRooms.Controls.Add(label4);
			pnlRooms.Location = new System.Drawing.Point(14, 36);
			pnlRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pnlRooms.Name = "pnlRooms";
			pnlRooms.Size = new System.Drawing.Size(1072, 621);
			pnlRooms.TabIndex = 5;
			// 
			// pictureBox4
			// 
			pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
			pictureBox4.Location = new System.Drawing.Point(920, 0);
			pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new System.Drawing.Size(149, 164);
			pictureBox4.TabIndex = 2;
			pictureBox4.TabStop = false;
			// 
			// listViewRooms
			// 
			listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { RoomId, RoomName, Roomtype, RoomSize });
			listViewRooms.Location = new System.Drawing.Point(18, 56);
			listViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listViewRooms.Name = "listViewRooms";
			listViewRooms.Size = new System.Drawing.Size(875, 408);
			listViewRooms.TabIndex = 1;
			listViewRooms.UseCompatibleStateImageBehavior = false;
			listViewRooms.View = System.Windows.Forms.View.Details;
			// 
			// RoomId
			// 
			RoomId.Text = "ID";
			// 
			// RoomName
			// 
			RoomName.Text = "Name";
			RoomName.Width = 150;
			// 
			// Roomtype
			// 
			Roomtype.Text = "Room Type";
			Roomtype.Width = 150;
			// 
			// RoomSize
			// 
			RoomSize.Text = "Size";
			RoomSize.Width = 150;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label4.Location = new System.Drawing.Point(15, 9);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(110, 41);
			label4.TabIndex = 0;
			label4.Text = "Rooms";
			// 
			// pnlLecturers
			// 
			pnlLecturers.Controls.Add(pictureBox2);
			pnlLecturers.Controls.Add(listViewLecturers);
			pnlLecturers.Controls.Add(label2);
			pnlLecturers.Location = new System.Drawing.Point(14, 36);
			pnlLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pnlLecturers.Name = "pnlLecturers";
			pnlLecturers.Size = new System.Drawing.Size(1072, 621);
			pnlLecturers.TabIndex = 3;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new System.Drawing.Point(920, 0);
			pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new System.Drawing.Size(149, 164);
			pictureBox2.TabIndex = 2;
			pictureBox2.TabStop = false;
			// 
			// listViewLecturers
			// 
			listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lecturerId, lecturerFirstName, lecturerLastName, lecturerAge, lecturerPhoneNumber });
			listViewLecturers.Location = new System.Drawing.Point(18, 56);
			listViewLecturers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listViewLecturers.Name = "listViewLecturers";
			listViewLecturers.Size = new System.Drawing.Size(875, 408);
			listViewLecturers.TabIndex = 1;
			listViewLecturers.UseCompatibleStateImageBehavior = false;
			listViewLecturers.View = System.Windows.Forms.View.Details;
			// 
			// lecturerId
			// 
			lecturerId.Tag = "";
			lecturerId.Text = "ID";
			// 
			// lecturerFirstName
			// 
			lecturerFirstName.Text = "First Name";
			lecturerFirstName.Width = 150;
			// 
			// lecturerLastName
			// 
			lecturerLastName.Text = "Last Name";
			lecturerLastName.Width = 150;
			// 
			// lecturerAge
			// 
			lecturerAge.DisplayIndex = 4;
			lecturerAge.Text = "Age";
			lecturerAge.Width = 150;
			// 
			// lecturerPhoneNumber
			// 
			lecturerPhoneNumber.DisplayIndex = 3;
			lecturerPhoneNumber.Text = "Phone Number";
			lecturerPhoneNumber.Width = 150;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label2.Location = new System.Drawing.Point(15, 9);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(138, 41);
			label2.TabIndex = 0;
			label2.Text = "Lecturers";
			// 
			// pnlActivities
			// 
			pnlActivities.Controls.Add(pictureBox3);
			pnlActivities.Controls.Add(listViewActivities);
			pnlActivities.Controls.Add(label3);
			pnlActivities.Location = new System.Drawing.Point(14, 36);
			pnlActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pnlActivities.Name = "pnlActivities";
			pnlActivities.Size = new System.Drawing.Size(1072, 621);
			pnlActivities.TabIndex = 4;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new System.Drawing.Point(920, 0);
			pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new System.Drawing.Size(149, 164);
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			// 
			// listViewActivities
			// 
			listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ActivityId, ActivityName, ActivityDay, ActivityBeginTime, ActivityEndTime });
			listViewActivities.Location = new System.Drawing.Point(18, 56);
			listViewActivities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			listViewActivities.Name = "listViewActivities";
			listViewActivities.Size = new System.Drawing.Size(875, 408);
			listViewActivities.TabIndex = 1;
			listViewActivities.UseCompatibleStateImageBehavior = false;
			listViewActivities.View = System.Windows.Forms.View.Details;
			// 
			// ActivityId
			// 
			ActivityId.Text = "ID";
			// 
			// ActivityName
			// 
			ActivityName.Text = "Name";
			ActivityName.Width = 150;
			// 
			// ActivityDay
			// 
			ActivityDay.Text = "Day";
			ActivityDay.Width = 150;
			// 
			// ActivityBeginTime
			// 
			ActivityBeginTime.Text = "Begin Time";
			ActivityBeginTime.Width = 200;
			// 
			// ActivityEndTime
			// 
			ActivityEndTime.Text = "End Time";
			ActivityEndTime.Width = 200;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			label3.Location = new System.Drawing.Point(15, 9);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(135, 41);
			label3.TabIndex = 0;
			label3.Text = "Activities";
			// 
			// SomerenUI
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1099, 673);
			Controls.Add(menuStrip1);
			Controls.Add(pnlDashboard);
			Controls.Add(pnlStudents);
			Controls.Add(pnlLecturers);
			Controls.Add(pnlActivities);
			Controls.Add(pnlRooms);
			MainMenuStrip = menuStrip1;
			Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			Name = "SomerenUI";
			Text = "SomerenApp";
			Load += SomerenUI_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			pnlDashboard.ResumeLayout(false);
			pnlDashboard.PerformLayout();
			pnlStudents.ResumeLayout(false);
			pnlStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			pnlRooms.ResumeLayout(false);
			pnlRooms.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			pnlLecturers.ResumeLayout(false);
			pnlLecturers.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			pnlActivities.ResumeLayout(false);
			pnlActivities.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlRooms;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ListView listViewRooms;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnlLecturers;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ListView listViewLecturers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnlActivities;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.ListView listViewActivities;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader studentFirstName;
		private System.Windows.Forms.ColumnHeader studentLastName;
		private System.Windows.Forms.ColumnHeader studentNumber;
		private System.Windows.Forms.ColumnHeader studentClass;
		private System.Windows.Forms.ColumnHeader studentPhoneNumber;
		private System.Windows.Forms.ColumnHeader lecturerId;
		private System.Windows.Forms.ColumnHeader lecturerFirstName;
		private System.Windows.Forms.ColumnHeader lecturerLastName;
		private System.Windows.Forms.ColumnHeader lecturerPhoneNumber;
		private System.Windows.Forms.ColumnHeader lecturerAge;
		private System.Windows.Forms.ColumnHeader RoomId;
		private System.Windows.Forms.ColumnHeader RoomName;
		private System.Windows.Forms.ColumnHeader Roomtype;
		private System.Windows.Forms.ColumnHeader RoomSize;
		private System.Windows.Forms.ColumnHeader ActivityId;
		private System.Windows.Forms.ColumnHeader ActivityName;
		private System.Windows.Forms.ColumnHeader ActivityDay;
		private System.Windows.Forms.ColumnHeader ActivityBeginTime;
		private System.Windows.Forms.ColumnHeader ActivityEndTime;
	}
}