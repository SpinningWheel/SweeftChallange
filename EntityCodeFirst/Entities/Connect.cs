using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entities {
    public class Connect {
        [Key]
        public int id { get; set; }
        public int teach_id { get; set; }
        public int stud_id { get; set; }
    }
}
