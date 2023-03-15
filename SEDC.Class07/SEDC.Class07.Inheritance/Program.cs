// See https://aka.ms/new-console-template for more information
using SEDC.Class07.Inheritance;
Console.WriteLine("Hello, World!");

// default ctor
Trainer trainer = new Trainer()
{
    Academy = "Code",
    CreatedOn = DateTime.Now,
    FirstName = "Anes",
    Id = 1,
    LastName = "Demishoski",
    Salary = 100,
    Subjects = new string[] { "C#" }
};
trainer.PrintInfo();
trainer.GetAge();
// second ctor 
Trainer trainer1 = new Trainer(1, "Bob", "Bobsky", "Network", 150);
trainer1.PrintInfo();
trainer.GetAge();
Assistant assistant = new Assistant()
{
    Id = 1,
    LastName = "Tetovo",
    FirstName = "Keny",
    CreatedOn = DateTime.Now,
    Academy = "Code",
    Courses = new string[] { "C#" }
};
assistant.PrintInfo();
Student student = new Student()
{
    Id = 1,
    FirstName = "Ernes",
    LastName = "Canoski",
    CreatedOn = DateTime.Now,
    CurrentSubject = "C# Basic",
    FinishedSubject = new string[] { "AJS", "BJS", }

};
student.PrintInfo();