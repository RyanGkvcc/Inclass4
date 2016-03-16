using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new linked list
            MyLinkedList myLinkedList = new MyLinkedList();

            //Add a few things to the linked list
            myLinkedList.Add("first");
            myLinkedList.Add("second");
            myLinkedList.Add("third");
            myLinkedList.Add("fourth");

            //Loop through with this differently looking for loop to output.
            //In here, the first part is initialization: Setting x to the Head
            //the second part is the test: if x!= null, keep going
            //The last part is: Set the current x to x's next pointer. (The next in the list)
            for (Node x = myLinkedList.Head; x != null; x=x.Next)
            {
                Console.WriteLine(x.Data);
            }

            //Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();

            //Use the retrive method to start at the Head of the linked list,
            //walk through it, and return the value that is at the passed in index.
            Console.WriteLine(myLinkedList.Retrive(2));
            Console.WriteLine(myLinkedList.Retrive(1));

            //Couple of blank lines
            Console.WriteLine();
            Console.WriteLine();


            //Do some deletes of the linked list
            //This will delete the frst one in the list
            myLinkedList.Delete(0);
            //Now there are 3, and this will delete the middle one
            myLinkedList.Delete(1);
            //Now there are 2, and this will delete the middle one
            myLinkedList.Delete(1);
            //Now there is only 1, and this loop will print it out
            for (Node x = myLinkedList.Head; x != null; x = x.Next)
            {
                Console.WriteLine(x.Data);
            }
        }
    }
}
