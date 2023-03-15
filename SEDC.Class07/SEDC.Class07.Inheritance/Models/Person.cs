namespace SEDC.Class07.Inheritance
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }
        
        // this will be only in Person class
        private DateTime DateOfBirth { get; set; }
        public Person()
        {
            CreatedOn = DateTime.Now;
            DateOfBirth = DateTime.Now.AddYears(-22);
        }

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedOn = DateTime.Now;
            DateOfBirth= DateTime.Now.AddYears(-22);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Person print info");
            string info = string.Format("Id: {0} person: {1} {2}", Id, FirstName, LastName);
            Console.WriteLine(info);
        }

        protected DateTime GetDateOfBirth()
        {
            return DateOfBirth;
        }
    }
}
