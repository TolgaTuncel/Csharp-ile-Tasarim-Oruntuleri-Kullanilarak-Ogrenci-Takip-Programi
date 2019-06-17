using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class MediatorPattern
    {
        
    }
   abstract class KursUyesi
         {

        protected Mediatorr Mediator;

        protected KursUyesi (Mediatorr mediator)
        {
            Mediator = mediator;
        }
    }

    class Hoca : KursUyesi
    {
        private new Mediatorr Mediator;

        public string Name { get; internal set; }

        public void SendNewImageUrl(string url)
        {
            
            Mediator.UpdateImage(url);

        }

        public void AnswerQuestion(string answer, Ogrenci ogrenci)
        {
            
        }
        public Hoca(Mediatorr mediator) : base(mediator)
        {
          

        }
        internal void RecieveQuestion(string question, Ogrenci ogrenci)
        {
            throw new NotImplementedException();
        }

        internal void RecieveQuestion(string question, object ogrenci)
        {
            throw new NotImplementedException();
        }
    }

    class Ogrenci : KursUyesi
    {
        private static Mediatorr mediator;

        public Ogrenci(Mediatorr mediator) : base(mediator)
        {

        }

        public Ogrenci() : base(Mediator1)
        {
        }

        public void RecieveImage(string url)
        {
           
        }

        public void RecieveAnswer()
        {
           
        }

        public string isim { get; set; }
        public string Name { get; internal set; }
        internal static Mediatorr Mediator1 { get => mediator; set => mediator = value; }
    }

    class Mediatorr
    {
        public Hoca Hoca { get; set;}
        public List<Ogrenci> Ogrenciler { get; set; }

        public void UpdateImage(string url)
        {
            foreach (var ogrenci in Ogrenciler)
            {
                ogrenci.RecieveImage(url);

            }

        }

        public void SendQuestion(string question, Ogrenci ogrenci)
        {

            Hoca.RecieveQuestion(question, ogrenci);
        }

        public void SendAnswer(string answer, Ogrenci ogrenci)
        {

            ogrenci.RecieveAnswer();
        }
    }


}
