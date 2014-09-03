using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcTOM.Models
{
    interface IQueryTask
    {
        List<Tasks> Show();
    }
}
