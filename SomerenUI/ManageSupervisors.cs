using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
	public partial class ManageSupervisors : Form
	{
		private Activity Activity;
		public ManageSupervisors(Activity activity)
		{
			InitializeComponent();

			Activity = activity;
		}

		private void ManageSupervisors_Load(object sender, EventArgs e)
		{
			lvParticipatingSupervisors.Items.Clear();
			lvNotParticipatingSupervisors.Items.Clear();

			SupervisorService supervisorService = new SupervisorService();
			List<Teacher> participatingSupervisors = supervisorService.GetParticipatingSupervisors(Activity.Id);
			List<Teacher> notParticipatingSupervisors = supervisorService.GetNotParticipatingSupervisors(Activity.Id);

			foreach (Teacher teacher in participatingSupervisors)
			{
				ListViewItem item = new ListViewItem(teacher.FirstName);
				item.SubItems.Add(teacher.LastName);
				item.Tag = teacher;

				lvParticipatingSupervisors.Items.Add(item);
			}

			foreach (Teacher teacher in notParticipatingSupervisors)
			{
				ListViewItem item = new ListViewItem(teacher.FirstName);
				item.SubItems.Add(teacher.LastName);
				item.Tag = teacher;

				lvNotParticipatingSupervisors.Items.Add(item);
			}
		}

		private void btnAddSupervisor_Click(object sender, EventArgs e)
		{
			if (lvNotParticipatingSupervisors.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select a lecturer to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			Teacher teacher = (Teacher)lvNotParticipatingSupervisors.SelectedItems[0].Tag;

			SupervisorService supervisorService = new SupervisorService();
			supervisorService.AddSupervisor(teacher.TeacherId, Activity.Id);

			ListViewItem item = new ListViewItem(teacher.FirstName);
			item.SubItems.Add(teacher.LastName);
			item.Tag = teacher;

			lvParticipatingSupervisors.Items.Add(item);
			lvNotParticipatingSupervisors.Items.Remove(lvNotParticipatingSupervisors.SelectedItems[0]);
		}

		private void btnRmvSupervisor_Click(object sender, EventArgs e)
		{
			if (lvParticipatingSupervisors.SelectedItems.Count == 0)
			{
				MessageBox.Show("Select a lecturer to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (MessageBox.Show("Are you sure you wish to remove this lecturer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			Teacher teacher = (Teacher)lvParticipatingSupervisors.SelectedItems[0].Tag;

			SupervisorService supervisorService = new SupervisorService();
			supervisorService.RemoveSupervisor(teacher.TeacherId, Activity.Id);

			ListViewItem item = new ListViewItem(teacher.FirstName);
			item.SubItems.Add(teacher.LastName);
			item.Tag = teacher;

			lvNotParticipatingSupervisors.Items.Add(item);
			lvParticipatingSupervisors.Items.Remove(lvParticipatingSupervisors.SelectedItems[0]);
		}
	}
}
