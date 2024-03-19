using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
	public partial class SomerenUI : Form
	{
		public SomerenUI()
		{
			InitializeComponent();
		}

		private void HideAllPanel()
		{
			pnlDashboard.Hide();
			pnlStudents.Hide();
			pnlLecturers.Hide();
			pnlActivities.Hide();
			pnlRooms.Hide();
		}

		private void ShowDashboardPanel()
		{
			// hide all other panels
			HideAllPanel();

			// show dashboard
			pnlDashboard.Show();
		}

		private void ShowStudentsPanel()
		{
			// hide all other panels
			HideAllPanel();

			// show students
			pnlStudents.Show();

			try
			{
				// get and display all students
				List<Student> students = GetStudents();
				DisplayStudents(students);
			}
			catch (Exception e)
			{
				MessageBox.Show("Something went wrong while loading the students: " + e.Message);
			}
		}

		private void ShowLecturersPanel()
		{
			// hide all other panels
			HideAllPanel();

			// show lecturers
			pnlLecturers.Show();
		}

		private void ShowActivitiesPanel()
		{
			pnlDashboard.Hide();
			pnlStudents.Hide();

			/*            pnlActivities.Show();
			*/
			try
			{
				List<Activity> activities = GetActivities();
				DisplayActivities(activities);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Something went wrong while loading the activities: " + ex.Message);
			}
		}

		private void ShowRoomsPanel()
		{
			// hide all other panels
			HideAllPanel();

			// show rooms
			pnlRooms.Show();
		}

		private void DisplayStudents(List<Student> students)
		{
			// clear the listview before filling it
			listViewStudents.Items.Clear();

			foreach (Student student in students)
			{
				ListViewItem li = new ListViewItem(student.studentId.ToString());
				li.SubItems.Add(student.studentNumber.ToString());
				li.SubItems.Add(student.firstName);
				li.SubItems.Add(student.lastName);
				li.SubItems.Add(student.studentClass);
				li.SubItems.Add(student.phoneNumber.ToString());
				//li.SubItems.Add(student.roomId.ToString());
				li.Tag = student;   // link student object to listview item
				listViewStudents.Items.Add(li);
			}
		}

		private void DisplayActivities(List<Activity> activities)
		{
			/*            listViewActivities.Clear();
			*/
			foreach (Activity activity in activities)
			{
				ListViewItem li = new ListViewItem(activity.Name);
				li.SubItems.Add(activity.Date);
				li.SubItems.Add(activity.StartTime);
				li.SubItems.Add(activity.EndTime);
				li.Tag = activity;
				/*                listViewActivities.Items.Add(li);
				*/
			}
		}

		private List<Student> GetStudents()
		{
			StudentService studentService = new StudentService();
			List<Student> students = studentService.GetStudents();
			return students;
		}

		private List<Activity> GetActivities()
		{
			ActivityService activityService = new ActivityService();
			List<Activity> activities = activityService.GetActivities();
			return activities;
		}

		private void SomerenUI_Load(object sender, EventArgs e)
		{
			HideAllPanel();
			pnlDashboard.Show();
		}

		private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowDashboardPanel();
		}

		private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowStudentsPanel();
		}

		private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowLecturersPanel();
		}

		private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowActivitiesPanel();
		}

		private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowRoomsPanel();
		}
	}
}