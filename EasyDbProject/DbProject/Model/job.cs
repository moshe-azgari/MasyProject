using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.Model
{
    public class job
    {
        public int jobId { set; get; }
        public string jobDescription { set; get; }
        public virtual List<worker> workers { set; get; }
    }
}
