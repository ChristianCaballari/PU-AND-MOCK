namespace PersonWeb.Model
{
    public class Person
    {

        private int id;
        private string Name;
        private int Age;
        private string Email;
        private string Phone;
        private string City;

        public Person(string Name, int Age, string Email,
            string Phone, string City)
        {
            //this.id = id;
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
            this.Phone = Phone;
            this.City = City;

        }

        public Person()
        {
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public string getPhone()
        {
            return this.Phone;
        }
        public string getCity()
        {
            return this.City;
        }
    }
}
