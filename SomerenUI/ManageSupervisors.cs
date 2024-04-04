using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenDAL;
using SomerenModel;
using SomerenService;


namespace SomerenUI
{
    public partial class ManageSupervisors : Form
    {
        private Activity Activity;
        public ManageSupervisors(Activity activity)
        {
            this.Activity = activity;
            InitializeComponent();
            PopulatingLvs();
        }

        private void PopulatingLvs()
        {
            PopulateRemovedSupervisorLv();
            PopulateAddSupervisorLv();
        }
        private void PopulateRemovedSupervisorLv()
        {
            lvNotParticipatingSupervisors.Items.Clear();

            List<Teacher> supervisors = new List<Teacher>();
            SupervisorService supervisorService = new SupervisorService();
            supervisors = supervisorService.GetRmvSupervisors(Activity.Id);

            foreach (Teacher supervisor in supervisors)
            {
                ListViewItem li = new ListViewItem(supervisor.FirstName);
                li.SubItems.Add(supervisor.LastName);
                li.Tag = supervisor;
                lvNotParticipatingSupervisors.Items.Add(li);
            }
        }

        void PopulateAddSupervisorLv()
        {
            lvParticipatingSupervisors.Items.Clear();

            List<Teacher> supervisors = new List<Teacher>();
            SupervisorService SupervisorService = new SupervisorService();
            supervisors = SupervisorService.GetSupervisors();

            foreach (Teacher supervisor in supervisors)
            {
                if (supervisor.ActivityId == Activity.Id)
                {
                    if (supervisor.FirstName != null) { }
                    ListViewItem li = new ListViewItem(supervisor.FirstName);
                    li.SubItems.Add(supervisor.LastName);
                    li.Tag = supervisor;
                    lvParticipatingSupervisors.Items.Add(li);
                }
            }
        }
        public void AddSupervisorToActivity(int activityId, int supervisorId)
        {
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.AddSupervisor(activityId, supervisorId);
        }

        public void RemoveSupervisorToActivity(int supervisorId)
        {
            SupervisorService supervisorService = new SupervisorService();
            supervisorService.RemoveSupervisor(supervisorId);
        }

        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            if (lvNotParticipatingSupervisors.SelectedItems.Count != 0)
            {
                ListViewItem selectedTeacherItem = lvNotParticipatingSupervisors.SelectedItems[0];
                Teacher teacher = (Teacher)selectedTeacherItem.Tag;

                AddSupervisorToActivity(Activity.Id, teacher.TeacherId);
                PopulatingLvs();
            }
            else
            {
               MessageBox.Show($"Please select a supervisor before continuing", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRmvSupervisor_Click(object sender, EventArgs e)
        {
            if (lvParticipatingSupervisors.SelectedItems.Count != 0)
            {
                ListViewItem selectedTeacherItem = lvParticipatingSupervisors.SelectedItems[0];
                Teacher teacher = (Teacher)selectedTeacherItem.Tag;

                DialogResult result = MessageBox.Show($"Are you sure you want to remove '{teacher.FirstName} {teacher.LastName}' from this Activity?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    RemoveSupervisorToActivity(teacher.TeacherId);
                    PopulatingLvs();
                }
            }
            else
            {
                MessageBox.Show($"Please select a supervisor before continuing", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
