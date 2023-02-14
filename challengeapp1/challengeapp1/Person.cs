
namespace challengeapp1
{
    public abstract class Person
    {                               
        public Person(string name, string surname, char sex, int age)            
        {
            this.Name = name;
            this.Surname = surname;            
            this.Sex = sex;
            this.Age = age;
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public Person()
        {
            this.Name = "NA";
            this.Surname = "NA";
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public char Sex { get; private set; }

        public int Age { get; private set; }
    }
}
