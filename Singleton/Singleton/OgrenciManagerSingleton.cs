using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class OgrenciManagerSingleton
    {
        private static OgrenciManagerSingleton _ogrManager;
    
        static object _lockObject = new object();

        private OgrenciManagerSingleton() { }

        public static OgrenciManagerSingleton CreateSingleton()
        {
       

            lock (_lockObject)
            {
                if (_ogrManager == null)
                {
                    _ogrManager = new OgrenciManagerSingleton();
                }
            }

            return _ogrManager;
        }

       
        public void Save()
        {
            
        }
    }
}
