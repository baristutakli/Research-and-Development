using System;
using System.Collections.Generic;
using System.Linq;
namespace LearnLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Student> studentList = new List<Student>(){
            new Student { Id=1, FirstName="Bob", LastName="Marley", Age=15},
            new Student { Id = 2, FirstName = "Robert", LastName = "Johnson", Age = 25 },
            new Student { Id = 3, FirstName = "Ray", LastName = "Charles", Age = 15 },
            new Student { Id = 4, FirstName = "lbert", LastName = "King", Age = 15 },
            };
            List<Message> messageList = new List<Message>(){
            new Message { Id=1, MessageDetail ="not found"},
            new Message { Id = 2, MessageDetail ="invalid operation" },
            new Message { Id = 3, MessageDetail ="not autheticated" },
            new Message { Id = 4, MessageDetail ="Not allowed"},
            };
            List<Object> mixedList = new List<object> {  new Message { Id=1, MessageDetail ="Warning!!!"},
            new Message { Id = 2, MessageDetail ="Invalid operation" },
            new Message { Id = 3, MessageDetail ="Not autheticated" },
            new Message { Id = 4, MessageDetail ="Not allowed"},new Student { Id=1, FirstName="Bob", LastName="Marley", Age=15},
            new Student { Id = 2, FirstName = "Robert", LastName = "Johnson", Age = 25 },
            new Student { Id = 3, FirstName = "Ray", LastName = "Charles", Age = 15 },
            new Student { Id = 4, FirstName = "lbert", LastName = "King", Age = 15 }};

            //string kaynak = @"https://www.tutorialsteacher.com/linq/linq-lambda-expression";
            //var result = from s in studentList
            //             where s.Age > 10
            //             select s.FirstName;
            //// Returns the first element of sequence
            //Console.WriteLine("First: " + result.First());
            //Console.WriteLine("First: " + studentList.First(s => s.Age > 10).FirstName);
            //foreach (var item in result.ToList())
            //{
            //    Console.WriteLine(item);
            //}
            //// OfType
            //var messages = mixedList.OfType<Message>().Where(m => m.Id > 2).ToList();
            //foreach (var item in messages)
            //{
            //    Console.WriteLine("Message:" + item.MessageDetail);
            //}

          
            foreach (var item in messageList.CustomExtension(m => m.MessageDetail.Length > 2).ToList())
            {
                Console.WriteLine(item.MessageDetail);
            }

        }
    }
}
