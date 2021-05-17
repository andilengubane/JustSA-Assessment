using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustSA.DTO
{
    class DataLookUpDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> DataLogId { get; set; }
        public System.DateTime DateLogged { get; set; }
    }
}
