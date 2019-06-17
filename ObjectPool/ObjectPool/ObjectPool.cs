using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectPool
{
    class ObjectPool
    {

        private static int _MaksBoyut = 2;
    
        private static readonly Queue objPool = new Queue(_MaksBoyut);
        public Veli GetTren()
        {
            Veli aVeli;
           
            if (Veli.Counter >= _MaksBoyut && objPool.Count > 0)
            {
    
                System.Threading.Thread.Sleep(3000);
                aVeli = RetrieveFromPool();
            }
            else
            {
                aVeli = GetNewVeli();
            }
            return aVeli;
        }
        private Veli GetNewVeli()
        {
       
            Veli t = new Veli();
            objPool.Enqueue(t);
            return t;
        }
        protected Veli RetrieveFromPool()
        {
            Veli t;
     
            if (objPool.Count > 0)
            {
                t = (Veli)objPool.Dequeue();
                Veli.Counter--;
            }
            else
            {
       
                t = new Veli();
            }
            return t;
        }
    }

    public class Veli
    {
        public static int Counter = 0;
        public Veli()
        {
            ++Counter;
        }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }
}
