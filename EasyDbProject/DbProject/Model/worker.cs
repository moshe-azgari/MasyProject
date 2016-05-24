using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProject.Model
{
    public class worker
    {
        public int idNumber { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        public DateTime dob { set; get; }
        public string age { get { int me = DateTime.Now.Year - dob.Year; return me.ToString();} }

        public int jobId { set; get; }
        public virtual job job { set; get; }
    }
}
