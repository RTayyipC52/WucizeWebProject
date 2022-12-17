using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TrCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string TrCategoryName { get; set; }

        public string CategoryImage { get; set; }

        public int ContentType { get; set; }

        public int Order { get; set; }

        public bool Status { get; set; }

        public List<TrProduct> TrProducts { get; set; }
    }
}
