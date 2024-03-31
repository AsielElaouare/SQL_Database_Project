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

            List<Teacher> teachers = new List<Teacher>();
            TeacherService teacherService = new TeacherService();
            teachers = teacherService.GetTeachers();

            foreach (Teacher teacher in teachers)
            {
                if (teacher.IsDeleted == 1)
                {
                    ListViewItem li = new ListViewItem(teacher.FirstName);
                    li.SubItems.Add(teacher.LastName);
                    li.Tag = teacher;
                    lvNotParticipatingSupervisors.Items.Add(li);
                }
            }
        }

        void PopulateAddSupervisorLv()
        {
            lvParticipatingSupervisors.Items.Clear();

            List<Supervisor> supervisors = new List<Supervisor>();
            List<Teacher> teachers = new List<Teacher>();
            TeacherService teacherService = new TeacherService();
            teachers = teacherService.GetTeachers();
            
            SupervisorService SupervisorService = new SupervisorService();
            supervisors = SupervisorService.GetSupervisors();

            foreach (Supervisor supervisor in supervisors)
            {
                if (supervisor.ActivityId == Activity.Id)
                {
                    foreach (Teacher teacher in teachers)
                    {
                        if (teacher.IsDeleted == 0 && teacher.TeacherId == supervisor.SupervisorId)
                        {
                            ListViewItem li = new ListViewItem(teacher.FirstName);
                            li.SubItems.Add(teacher.LastName);
                            li.Tag = teacher;
                            lvParticipatingSupervisors.Items.Add(li);
                        }
                    }
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
            Teacher teacher  = new Teacher();
            TeacherService teacherService = new TeacherService();

            ListViewItem selectedTeacherItem = lvNotParticipatingSupervisors.SelectedItems[0];
            teacher = (Teacher)selectedTeacherItem.Tag;

            teacherService.UpdateTeacher(0, teacher.TeacherId);
            AddSupervisorToActivity(Activity.Id, teacher.TeacherId);
            PopulatingLvs();
        }

        private void btnRmvSupervisor_Click(object sender, EventArgs e)
        {
            ListViewItem selectedTeacherItem = lvParticipatingSupervisors.SelectedItems[0];
            Teacher teacher = (Teacher)selectedTeacherItem.Tag;

            DialogResult result = MessageBox.Show($"Are you sure you want to remove '{teacher.FirstName} {teacher.LastName}' from this Activity?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (result == DialogResult.OK)
            {
                TeacherService teacherService = new TeacherService();
                teacherService.UpdateTeacher(1, teacher.TeacherId);
                RemoveSupervisorToActivity(teacher.TeacherId);
                PopulatingLvs();
            }
        }
    }
}
