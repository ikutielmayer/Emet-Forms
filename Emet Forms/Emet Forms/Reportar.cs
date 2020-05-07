using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emet_Forms
{
    class Reportar
    {
        public int Id { get; set; }
        public string serial { get; set; }
        public string makat { get; set; }
        public string Paka { get; set; }

        public Reportar() { }

        public Reportar(int pId, string pserial, string pmakat, string pPaka)

        {

            this.Id = pId;
            this.serial = pserial;
            this.makat = pmakat;
            this.Paka = pPaka;
            

        }
    }
}
