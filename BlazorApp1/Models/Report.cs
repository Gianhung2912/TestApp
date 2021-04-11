using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class Report:BaseModel
    {
        public string ReportName { get; set; }
        public string FileName { get; set; }
        public string ProjectID { get; set; }
        public string ScreenID { get; set; }

    }
}
