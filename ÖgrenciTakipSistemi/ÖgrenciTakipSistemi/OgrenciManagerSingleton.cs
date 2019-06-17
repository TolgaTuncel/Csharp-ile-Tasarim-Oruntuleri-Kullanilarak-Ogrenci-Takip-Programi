using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ÖgrenciTakipSistemi
{
    class OgrenciManagerSingleton
    {
        private static OgrenciManagerSingleton _ogrManager;
        //Lock işlemi için gerekli olan bir kilit objesi oluşturuyoruz
        static object _lockObject = new object();

        private OgrenciManagerSingleton() { }

        public static OgrenciManagerSingleton CreateSingleton()
        {
            //if(_customerManager == null)
            //{
            //    _customerManager = new CustomerManager();
            //}

            lock (_lockObject)
            {
                if (_ogrManager == null)
                {
                    _ogrManager = new OgrenciManagerSingleton();
                }
            }

            return _ogrManager;
        }

        //Ornek İslem
        public void Save()
        {
            //Save İşlemleri Gerçekleştiriyor
        }
    }
}
