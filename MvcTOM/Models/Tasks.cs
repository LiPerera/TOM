using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTOM.Models
{
    public class Tasks
    {
        public int TASK_ID { set; get; }
        public string TASK_NAME { set; get; }
        public string DESCRIPTION { set; get; }
        public string TASK_STATUS { set; get; }
    }
}