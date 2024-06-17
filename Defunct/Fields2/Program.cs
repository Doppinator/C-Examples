
using System.Net.Http.Headers;

namespace Fields
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate) 
        { 
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
         var person = new Person();
            person.SetBirthDate(new DateTime(1989,1,1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
