using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi
{
    class GoGoMemento
    {
        public string Sinif { get; set; }
    }

    class GoGoCareTaker
    {
        public GoGoMemento Memento { get; set; }
    }

    class GoGo
    {

        public string Sinif { get; set; }

        public override string ToString()
        {
            return $" Hoca {Sinif} 'te.";
        }

        
        public GoGoMemento Kaydet()
        {
            return new GoGoMemento
            {
                Sinif = this.Sinif,
              
            };
        }

        public void OncekiniYukle(GoGoMemento Memento)
        {
            this.Sinif = Memento.Sinif;
          
        }
    }
}
