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
			List<Supervisor> participatingSupervisors = supervisorService.GetParticipatingSupervisors(Activity.Id);
			List<Supervisor> notParticipatingSupervisors = supervisorService.GetNotParticipatingSupervisors(Activity.Id);

			foreach (Supervisor supervisor in participatingSupervisors)
			{
				ListViewItem item = new ListViewItem(supervisor.FirstName);
				item.SubItems.Add(supervisor.LastName);
				item.Tag = supervisor;

				lvParticipatingSupervisors.Items.Add(item);
			}

			foreach (Supervisor supervisor in notParticipatingSupervisors)
			{
				ListViewItem item = new ListViewItem(supervisor.FirstName);
				item.SubItems.Add(supervisor.LastName);
				item.Tag = supervisor;

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

			Supervisor supervisor = (Supervisor)lvNotParticipatingSupervisors.SelectedItems[0].Tag;

			SupervisorService supervisorService = new SupervisorService();
			supervisorService.AddSupervisor(supervisor.SupervisorId, Activity.Id);

			ListViewItem item = new ListViewItem(supervisor.FirstName);
			item.SubItems.Add(supervisor.LastName);
			item.Tag = supervisor;

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

			Supervisor supervisor = (Supervisor)lvParticipatingSupervisors.SelectedItems[0].Tag;

			SupervisorService supervisorService = new SupervisorService();
			supervisorService.RemoveSupervisor(supervisor.SupervisorId, Activity.Id);

			ListViewItem item = new ListViewItem(supervisor.FirstName);
			item.SubItems.Add(supervisor.LastName);
			item.Tag = supervisor;

			lvNotParticipatingSupervisors.Items.Add(item);
			lvParticipatingSupervisors.Items.Remove(lvParticipatingSupervisors.SelectedItems[0]);
		}
	}
}
