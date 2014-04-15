using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Model
{
    public class NomenclatureBase : IdEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
