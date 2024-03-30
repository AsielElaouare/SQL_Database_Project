using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            this.Activity = activity;
            PopulateListViews();
        }

        private void PopulateListViews()
        {
            List<Teacher> teachers = new List<Teacher>();
            TeacherService teacherService = new TeacherService();
            teachers = teacherService.GetTeachers();

            foreach (Teacher teacher in teachers)
            {
                ListViewItem li = new ListViewItem(teacher.FirstName);
                li.SubItems.Add(teacher.LastName);
                li.Tag = teacher;
                lvNotParticipatingSupervisors.Items.Add(li); 
            }
        }


        private void btnAddSupervisor_Click(object sender, EventArgs e)
        {
            if (lvParticipatingSupervisors.CheckedItems.Count != 0)
            {
                Teacher teacher = (Teacher)lvParticipatingSupervisors.SelectedItems[0].Tag;
            }
        }

        private void btnRmvSupervisor_Click(object sender, EventArgs e)
        {

        }
    }
}
