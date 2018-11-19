using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuDataManagementSystem
{
    public class StuInfo
    {
        public int stuID { get; set; }
        public string stuName { get; set; }
        public string stuGender { get; set; }
        public DateTime stuBirthDate { get; set; }
        public string stuPhoneNumber { get; set; }
        public int DelFlag { get; set; }

    }
}
