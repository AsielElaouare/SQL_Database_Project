﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class SupervisorService
    {
        private SupervisorDao supervisorDb;
        public SupervisorService()
        {
            supervisorDb = new SupervisorDao();
        }
        public List<Supervisor> GetSupervisors()
        {
            List<Supervisor> supervisors = supervisorDb.GetAllSupervisors();
            return supervisors;
        }

        public void AddSupervisor(int activityId, int supervisorId)
        {
            supervisorDb.AddSupervisorToTable(activityId, supervisorId);
        }
        public void RemoveSupervisor(int supervisorId)
        {
            supervisorDb.RemoveSupervisorToTable(supervisorId);
        }
    }
}