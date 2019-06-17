using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ÖgrenciTakipSistemi
{
    [Serializable]
    public abstract class IPrototype<T>
    {
        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }

    }

    [Serializable]
    public class Adres
    {
        public string adres { get; set; }
    }

    [Serializable]
    public class Etkinlik : IPrototype<Etkinlik>
    {
        public string Adi { get; set; }
        public string DersAdi { get; set; }
        public Adres Adres { get; set; }

    }
}
