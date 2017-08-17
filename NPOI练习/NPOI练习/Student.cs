using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPOI练习
{
    public class Student
    {
        public string SName { get; set; } = "张三";
        public string SId { get; set; } = Guid.NewGuid().ToString();
        public string SSex { get; set; } = "男";
        public string SDate { get; set; } =DateTime.Now.ToString();
        public string SAge { get; set; } = "19";
    }
}
