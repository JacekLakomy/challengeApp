namespace challengeapp1
{
    public class Employee
    {
        public List<int> rating = new List<int>();

        public int Age { get; private set; }

        public Employee(string name, string surname)//konstruktor (jest wywoływany automatycznie podczas tworzenia jakiegoś usera)
        {
            this.Name = name;//parametry konstruktora
            this.Surname = surname;
        }

        public string Name { get; private set; } // pola property (hermetyzacja)

        public string Surname { get; private set; }

        public int Result
        {
            get
            {
                return this.rating.Sum();
            }
        }

        public void AddRating(int number)
        {
            this.rating.Add(number);
        }
    }
}
