using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace ShaunWildmanTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            RandomHat hat = new RandomHat();

            Console.Write("Enter the a number");

            int list = Convert.ToInt32(Console.ReadLine());

            List<int> myList = new List<int>();

            hat.buildList(list, myList);

            Console.WriteLine("This is how many numbers in our deck");
            Console.WriteLine(list);

            hat.pullNumberOutOfList(myList, list);



            //Console.WriteLine("Hello and welcome to a Jira Example application!");

            //Console.Write("Username: ");
            //string username = Console.ReadLine();

            //Console.Write("Password: ");
            //string password = Console.ReadLine();

            //JiraTestAuth manager = new JiraTestAuth();

            //manager.JiraManager(username, password);

            //manager.RunQuery(JiraResource.ITSD);

            Console.Read();

        }
    }
}
