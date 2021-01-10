using System;

namespace first
{
    class Person : IComparable<Person>
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Height { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string Special { get; set; }
        public string Nationality { get; set; }
        public string BirthdayPlace { get; set; }
        public string BirthdayDay { get; set; }
        public string LastPlace { get; set; }
        public string Language { get; set; }
        public string LastDeal { get; set; }
        public string Measure { get; set; }
        public string Date { get; set; }
        public string Alive { get; set; }
        public int CompareTo(Person p)
        {
            return this.Surname.CompareTo(p.Surname);
        }
    }
}
