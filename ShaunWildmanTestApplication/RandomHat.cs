using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaunWildmanTestApplication
{
    class RandomHat
    {

        public void buildList(int list, List<int> myList)
        {

            for (int i = 1; i <= list; i++)
            {
                myList.Add(i);

            }

        }
        public void pullNumberOutOfList(List<int> myList, int list)
        {

           
            for (int i =0; i<= list; i++)
            {

                Random random = new Random();
                // Get the next item at random.
                var index = random.Next(0, myList.Count);

                var item = myList[index];

                // Remove the item from the list and push it to the top of the deck.
                myList.RemoveAt(index);

                Console.WriteLine(item);

                Console.ReadLine();


            }




        }

        


    }

}