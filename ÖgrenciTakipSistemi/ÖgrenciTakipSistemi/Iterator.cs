using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciTakipSistemi
{
   struct Iterator
   {
        public int Id { get; set; }
        public string DersAdi { get; set; }
        public string DersSaati { get; set; }
   }

    interface IAggregate
    {
        IIterator CreateIterator();
    }

    interface IIterator
    {
        //Derse bak
        bool HasItem();
        //Dersi al
        Iterator NextItem();
        //Dersi getir.
        Iterator CurrentItem();
    }

    class PersonelAggregate : IAggregate
    {
        List<Iterator> PersonelListesi = new List<Iterator>();
        public void Add(Iterator Model) => PersonelListesi.Add(Model);
        public Iterator GetItem(int index) => PersonelListesi[index];
        public int Count { get => PersonelListesi.Count; }
        public IIterator CreateIterator() => new PersonelIterator(this);
    }

    class PersonelIterator : IIterator
    {
        PersonelAggregate aggregate;
        int currentindex;
        public PersonelIterator(PersonelAggregate aggregate) => this.aggregate = aggregate;
        public Iterator CurrentItem() => aggregate.GetItem(currentindex);
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public Iterator NextItem()
        {
            if (HasItem())
                return aggregate.GetItem(currentindex++);
            return new Iterator();
        }
    }
}
