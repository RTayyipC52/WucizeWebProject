using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TrProduct
    {
        [Key]
        public int ProductId { get; set; }

        public string TrProductName { get; set; }

        public string TrProductDescription { get; set; }
    }
}
