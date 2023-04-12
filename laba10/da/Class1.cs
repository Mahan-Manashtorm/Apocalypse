using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace da
{
    public interface IBankConsultant
    {
        string GetAdvice(string question);
    }

    public class RealSubject : IBankConsultant
    {
        public string GetAdvice(string question)
        {
            return "Наразi ми не можемо вiдповiсти на ваше питання " + question;
        }
    }
    public class Proxy : IBankConsultant
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            this._realSubject = realSubject;
        }

        private List<string> _allowedQuestions = new List<string> { "Запитання 1", "Запитання 2", "Запитання 3" };

        public string GetAdvice(string question)
        {
            if (_allowedQuestions.Contains(question))
            {
                return _realSubject.GetAdvice(question);
            }
            else
            {
                return "Консультант не может вiдповiсти на запитання";
            }
        }
    }
    public class Client
    {
        public void ClientCode(IBankConsultant subject)
        {
            string question = Console.ReadLine();

            Console.WriteLine(subject.GetAdvice(question));
        }
    }
}
