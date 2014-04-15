using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    public class TemporalNomBase : NomenclatureBase
    {
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
