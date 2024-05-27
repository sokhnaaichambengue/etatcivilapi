namespace EtatCivilAPI.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Nationality { get; set; }

        public string FatherFirstName { get; set; }

        public string FatherLastName { get; set; }

        public string MotherFirstName { get; set; }

        public string MotherLastName { get; set;}
    }
}
