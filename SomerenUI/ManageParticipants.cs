using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
	public partial class ManageParticipants : Form
	{
		private Activity Activity;
		public ManageParticipants(Activity activity)
		{
			InitializeComponent();

			Activity = activity;
		}

		private void ManageParticipants_Load(object sender, EventArgs e)
		{
			lvParticipating.Items.Clear();
			lvNotParticipating.Items.Clear();

			StudentService studentService = new StudentService();
			List<Student> participatingStudents = studentService.GetParticipatingStudents(Activity.Id);
			List<Student> notParticipatingStudents = studentService.GetNotParticipatingStudents(Activity.Id);

			foreach (Student student in participatingStudents)
			{
				ListViewItem item = new ListViewItem(student.studentNumber.ToString());
				item.SubItems.Add($"{student.firstName} {student.lastName}");
				item.Tag = student;

				lvParticipating.Items.Add(item);
			}

			foreach (Student student in notParticipatingStudents)
			{
				ListViewItem item = new ListViewItem(student.studentNumber.ToString());
				item.SubItems.Add($"{student.firstName} {student.lastName}");
				item.Tag = student;

				lvNotParticipating.Items.Add(item);
			}
		}

		private void btnAddParticipant_Click(object sender, EventArgs e)
		{
			if (lvNotParticipating.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select a student to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Student student = (Student)lvNotParticipating.SelectedItems[0].Tag;

			StudentService studentService = new StudentService();
			studentService.AddParticipant(Activity.Id, student.studentId);

			ListViewItem item = new ListViewItem(student.studentNumber.ToString());
			item.SubItems.Add($"{student.firstName} {student.lastName}");
			item.Tag = student;

			lvParticipating.Items.Add(item);
			lvNotParticipating.Items.Remove(lvNotParticipating.SelectedItems[0]);
		}

		private void btnRmvParticipant_Click(object sender, EventArgs e)
		{
			if (lvParticipating.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select a student to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("Are you sure you wish to remove this participant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			Student student = (Student)lvParticipating.SelectedItems[0].Tag;

			StudentService studentService = new StudentService();
			studentService.RemoveParticipant(Activity.Id, student.studentId);

			ListViewItem item = new ListViewItem(student.studentNumber.ToString());
			item.SubItems.Add($"{student.firstName} {student.lastName}");
			item.Tag = student;

			lvNotParticipating.Items.Add(item);
			lvParticipating.Items.Remove(lvParticipating.SelectedItems[0]);
		}
	}
}
