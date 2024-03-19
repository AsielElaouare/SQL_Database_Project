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
            orderADrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            pnlOrderADrink = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            listViewDrinkOrder = new System.Windows.Forms.ListView();
            listViewStudentOrder = new System.Windows.Forms.ListView();
            studentId = new System.Windows.Forms.ColumnHeader();
            studentName = new System.Windows.Forms.ColumnHeader();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
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
            pnlOrderADrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, orderADrinkToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
            menuStrip1.Size = new System.Drawing.Size(1786, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(106, 36);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // orderADrinkToolStripMenuItem
            // 
            orderADrinkToolStripMenuItem.Name = "orderADrinkToolStripMenuItem";
            orderADrinkToolStripMenuItem.Size = new System.Drawing.Size(178, 36);
            orderADrinkToolStripMenuItem.Text = "Order a Drink";
            orderADrinkToolStripMenuItem.Click += orderADrinkToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(23, 58);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(24, 27);
            lblDashboard.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(421, 32);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(23, 58);
            pnlStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1742, 994);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1495, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(242, 262);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { studentNumber, studentFirstName, studentLastName, studentClass, studentPhoneNumber });
            listViewStudents.Location = new System.Drawing.Point(29, 90);
            listViewStudents.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1419, 650);
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
            label1.Location = new System.Drawing.Point(24, 14);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 65);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox4);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label4);
            pnlRooms.Location = new System.Drawing.Point(23, 58);
            pnlRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1742, 994);
            pnlRooms.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1495, 0);
            pictureBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(242, 262);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { RoomId, RoomName, Roomtype, RoomSize });
            listViewRooms.Location = new System.Drawing.Point(29, 90);
            listViewRooms.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1419, 650);
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
            label4.Location = new System.Drawing.Point(24, 14);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 65);
            label4.TabIndex = 0;
            label4.Text = "Rooms";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(pictureBox2);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label2);
            pnlLecturers.Location = new System.Drawing.Point(23, 58);
            pnlLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1742, 994);
            pnlLecturers.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1495, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(242, 262);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lecturerId, lecturerFirstName, lecturerLastName, lecturerAge, lecturerPhoneNumber });
            listViewLecturers.Location = new System.Drawing.Point(29, 90);
            listViewLecturers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(1419, 650);
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
            label2.Location = new System.Drawing.Point(24, 14);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(220, 65);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(label3);
            pnlActivities.Location = new System.Drawing.Point(23, 58);
            pnlActivities.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1742, 994);
            pnlActivities.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1495, 0);
            pictureBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(242, 262);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ActivityId, ActivityName, ActivityDay, ActivityBeginTime, ActivityEndTime });
            listViewActivities.Location = new System.Drawing.Point(29, 90);
            listViewActivities.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1419, 650);
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
            label3.Location = new System.Drawing.Point(24, 14);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(217, 65);
            label3.TabIndex = 0;
            label3.Text = "Activities";
            // 
            // pnlOrderADrink
            // 
            pnlOrderADrink.Controls.Add(label6);
            pnlOrderADrink.Controls.Add(listViewDrinkOrder);
            pnlOrderADrink.Controls.Add(listViewStudentOrder);
            pnlOrderADrink.Controls.Add(pictureBox5);
            pnlOrderADrink.Controls.Add(label5);
            pnlOrderADrink.Location = new System.Drawing.Point(23, 58);
            pnlOrderADrink.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pnlOrderADrink.Name = "pnlOrderADrink";
            pnlOrderADrink.Size = new System.Drawing.Size(1742, 994);
            pnlOrderADrink.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(1394, 301);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 65);
            label6.TabIndex = 5;
            label6.Text = "Total";
            // 
            // listViewDrinkOrder
            // 
            listViewDrinkOrder.FullRowSelect = true;
            listViewDrinkOrder.Location = new System.Drawing.Point(38, 119);
            listViewDrinkOrder.Name = "listViewDrinkOrder";
            listViewDrinkOrder.Size = new System.Drawing.Size(668, 805);
            listViewDrinkOrder.TabIndex = 4;
            listViewDrinkOrder.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentOrder
            // 
            listViewStudentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { studentId, studentName });
            listViewStudentOrder.FullRowSelect = true;
            listViewStudentOrder.Location = new System.Drawing.Point(750, 119);
            listViewStudentOrder.MultiSelect = false;
            listViewStudentOrder.Name = "listViewStudentOrder";
            listViewStudentOrder.Size = new System.Drawing.Size(478, 805);
            listViewStudentOrder.TabIndex = 3;
            listViewStudentOrder.UseCompatibleStateImageBehavior = false;
            listViewStudentOrder.View = System.Windows.Forms.View.Details;
            // 
            // studentId
            // 
            studentId.Text = "Student ID";
            studentId.Width = 130;
            // 
            // studentName
            // 
            studentName.Text = "Student Name";
            studentName.Width = 200;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(1495, 0);
            pictureBox5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(242, 262);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(24, 14);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(164, 65);
            label5.TabIndex = 0;
            label5.Text = "Order ";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1786, 1077);
            Controls.Add(menuStrip1);
            Controls.Add(pnlOrderADrink);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlStudents);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlActivities);
            Controls.Add(pnlRooms);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
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
            pnlOrderADrink.ResumeLayout(false);
            pnlOrderADrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem orderADrinkToolStripMenuItem;
        private System.Windows.Forms.Panel pnlOrderADrink;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewDrinkOrder;
        private System.Windows.Forms.ListView listViewStudentOrder;
        private System.Windows.Forms.ColumnHeader studentId;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.Label label6;
    }
}