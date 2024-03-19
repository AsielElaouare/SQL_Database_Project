
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Day { get { return StartTime.Day.ToString(); } }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


    }
}
