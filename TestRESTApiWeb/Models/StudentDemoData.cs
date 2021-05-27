using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRESTApiWeb.Models
{
    public class StudentDemoData
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

    }

    public class StudentDataList 
    {
        public List<StudentDemoData> studentDemoDatas { get; set; } = null;
        public StudentDataList()
        {
            studentDemoDatas = new List<StudentDemoData>();
            StudentDemoData sd = new StudentDemoData();
            sd.RollNum = 1001;
            sd.Name = "Mustafa";
            sd.Course = "MCA";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1002;
            sd.Name = "Ali";
            sd.Course = "MDA";
            studentDemoDatas.Add(sd);

            sd = new StudentDemoData();
            sd.RollNum = 1003;
            sd.Name = "Emre";
            sd.Course = "BAL";
            studentDemoDatas.Add(sd);

        }

    }


}