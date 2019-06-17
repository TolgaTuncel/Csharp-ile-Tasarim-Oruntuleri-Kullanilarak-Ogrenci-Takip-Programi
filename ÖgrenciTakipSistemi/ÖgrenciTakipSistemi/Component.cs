using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciTakipSistemi
{
    //Component Kullanımı
    public interface IPersonel
    {
      
        string Adı { get; set; }
        string Gorevi { get; set; }
    }

    public class Calisan : IPersonel, IEnumerable<IPersonel>
    {
        private List<IPersonel> _subordinates = new List<IPersonel>();

   
        public string Adı { get; set; }
        public string Gorevi { get; set; }

        public void AddSubordinate(IPersonel subordinate)
        {
            _subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IPersonel subordinate)
        {
            _subordinates.Remove(subordinate);
        }

        public IPersonel GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPersonel> GetEnumerator()
        {
            foreach (IPersonel subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Contractor : IPersonel
    {
    
        public string Adı { get; set; }
        public string Gorevi { get; set; }
    }
}
