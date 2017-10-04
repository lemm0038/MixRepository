using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MixRepository.Common.Model
{
    public class Mix
    {
        public int MixId { get; set; }
        [StringLength(10, ErrorMessage ="Mix Name too long")]
        public string MixName { get; set; }
        public double SVO { get; set; }
        public double CFx { get; set; }
        public string Ratio { get; set; }

    }
}
