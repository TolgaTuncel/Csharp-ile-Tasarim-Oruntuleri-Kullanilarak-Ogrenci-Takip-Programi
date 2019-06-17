using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ÖgrenciTakipSistemi
{
    class OgrenciAbstracFactory
    {
        private AbstractFactoryManager _abstractFactoryManager;
        private Logging _logging;
        private Caching _caching;

        public OgrenciAbstracFactory(AbstractFactoryManager abstractFactoryManager)
        {
            _abstractFactoryManager = abstractFactoryManager;
            _logging = _abstractFactoryManager.CreateLogging();
            _caching = _abstractFactoryManager.CreateCaching();
        }

        public void GetAll()
        {
            _logging.Log("Logged");
            _caching.Cache("Cached");
        }
    }

    public abstract class AbstractFactoryManager
    {
        public abstract Logging CreateLogging();
        public abstract Caching CreateCaching();
    }

    class Fabricate1 : AbstractFactoryManager
    {
        public override Caching CreateCaching()
        {
            return new MemCache();
        }

        public override Logging CreateLogging()
        {
            return new NLogger();
        }
    }

    class Fabricate2 : AbstractFactoryManager
    {
        public override Caching CreateCaching()
        {
            return new RedisCache();
        }

        public override Logging CreateLogging()
        {
            return new Log4NetLogger();
        }
    }

    public abstract class Caching
    {
        public abstract void Cache(string data);
    }

    public class MemCache : Caching
    {
        public override void Cache(string data)
        {

            Console.WriteLine("Cache işlemi tamamlandı");
        }
    }

    public class RedisCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cache işlemi tamamlandı");
        }
    }

    public abstract class Logging
    {
        public abstract void Log(string mesaj);
    }

    public class Log4NetLogger : Logging
    {
        public override void Log(string mesaj)
        {
            Console.WriteLine("Loglama işlemi tamamlandı");
        }
    }

    public class NLogger : Logging
    {
        public override void Log(string mesaj)
        {
            Console.WriteLine("Loglama işlemi tamamlandı");
        }
    }
}
