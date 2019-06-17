using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ÖgrenciTakipSistemi
{
    class Observerr
    {
        List<Observer> observers = new List<Observer>();

        public void ProgramGüncelle()
        {
            Console.WriteLine("Program Güncellendi");
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        private void Notify()
        {
            foreach (var o in observers)
            {
                o.Update();
            }
        }
    }

    abstract class Observer
    {
        public abstract void Update();
    }

    class IlkAsamaObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("İlk Aşama Güncellendi");
        }
    }

    class IkinciAsamaObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("İkinci Aşama Güncellendi");
        }
    }

    class TamObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Son Aşama Güncellendi");
        }
    }
}
