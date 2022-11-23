using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcsFileServer
{
    [Table("ftpuser")]
    public class ftpuser
    {
        public int id { get; set; }
        public string userid { get; set; }
        public string email { get; set; }
        public string passwd { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string role { get; set; }
        public string homedir { get; set; }
    }
}
