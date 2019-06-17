using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class BildirimManagerFactory
    {
        private IBildirimFactory _bildirimFactory;

        public BildirimManagerFactory(IBildirimFactory bildirimFactory)
        {
            _bildirimFactory = bildirimFactory;
        }

        public void Save()
        {
            IBildirim bildirim = _bildirimFactory.BildirimOlustur();
            bildirim.Log();
        }
    }

    public class LoggerFactory1 : IBildirimFactory
    {
        public IBildirim BildirimOlustur()
        {
           
            return new MailBildirim();
        }
    }

    public class LoggerFactory2 : IBildirimFactory
    {
        public IBildirim BildirimOlustur()
        {
           
            return new SmsBildirim();
        }
    }

    public interface IBildirimFactory
    {
        IBildirim BildirimOlustur();
    }

    public interface IBildirim
    {
        void Log();
    }

    public class MailBildirim : IBildirim
    {
        public void Log()
        {
            Console.WriteLine("Mail Gönderme İşlemi Başarılı");
        }
    }

    public class SmsBildirim : IBildirim
    {
        public void Log()
        {
            Console.WriteLine("SMS Gönderme İşlemi Başarılı");
        }
    }
}
