namespace SEDC.Class07.Inheritance
{
    public class Assistant : Person 
    {
        public string Academy { get; set; }

        public string[] Courses { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine("Assistant print info");
            string info = $"Id: {Id}, Assistant name: {FirstName} {LastName} is assistant at {Academy} academy";
            Console.WriteLine(info);
        }

        public void CheckHomework()
        {
            Console.WriteLine("Checking homework");
        }
    }
}
