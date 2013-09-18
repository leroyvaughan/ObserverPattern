using System;
using ObserverPattern.Interface;
using ObserverPattern.SubjectClass;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DevelopmentProject Project1 = new DevelopmentProject("New Home Page", 
                "proj1");
            Project1.Attach(new Person("Project Manager"));
            
            //First task is UX Design
            ProjectTask task1 = new ProjectTask("Create Mockups", "proj1_task1");
            task1.Attach(new Person("UX Manager"));
            task1.Attach(new Person("Front End Dev"));
            
            //simulating UX Designer logging task as complete
            task1.UpdateItem("completed", "UX Designer");
            Project1.UpdateItem("milestone 1", "UX Designer");

            //Second task is Back End code
            ProjectTask task2 = new ProjectTask("Code Back End", "proj1_task2");
            task2.Attach(new Person("IT Dev Manager"));
            task2.Attach(new Person("Front End Dev"));

            //simulating IT Dev logging task as complete
            task2.UpdateItem("completed", "IT Dev");
            Project1.UpdateItem("milestone 2", "IT Dev");

            ProjectTask task3 = new ProjectTask("Code UI", "proj1_task3");
            task3.Attach(new Person("Front End Dev Manager"));

            //simulating Front End Dev logging task as complete
            task3.UpdateItem("completed", "Front End Dev");
            Project1.UpdateItem("milestone 3", "Front End Dev");

            Console.ReadKey();
        }
    }
}
