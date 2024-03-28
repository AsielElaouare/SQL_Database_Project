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
	}
}
