using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create and display a Singly Linked List");
                Console.WriteLine("2. Create a singly linked list of n nodes and display it in reverse order");
                Console.WriteLine("3. Create a singly linked list of n nodes and count the number of nodes");
                Console.WriteLine("4. Insert a node at any position in a Singly Linked List");
                Console.WriteLine("5. Insert a node at the beginning of a Singly Linked List");
                Console.WriteLine("6. Insert a node at the end of a Singly Linked List");
                Console.WriteLine("7. Get a node in an existing singly linked list");
                Console.WriteLine("8. Find the first index that matches a given element");
                Console.WriteLine("9. Check whether a single linked list is empty or not");
                Console.WriteLine("10. Empty a singly linked list");
                Console.WriteLine("11. Remove the node from the singly linked list at the specified index");
                Console.WriteLine("12. Calculate the size of a Singly Linked list");
                Console.WriteLine("13. removes the first element from a Singly Linked list");
                Console.WriteLine("14. removes the tail element from a Singly Linked list");
                Console.WriteLine("15. convert a Singly Linked list into an array");
                Console.WriteLine("16. convert a Singly Linked list into a string");
                Console.WriteLine("18. check if an element is present in the Singly Linked list");
                Console.WriteLine("0. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("");
                        Q1();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Q2();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Q3();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Q4();
                        break;
                    case 5:
                        Console.WriteLine("");
                        Q5();
                        break;
                    case 6:
                        Console.WriteLine("");
                        Q6();
                        break;
                    case 7:
                        Console.WriteLine("");
                        Q7();
                        break;
                    case 8:
                        Console.WriteLine("");
                        Q8();
                        break;
                    case 9:
                        Console.WriteLine("");
                        Q9();
                        break;
                    case 10:
                        Console.WriteLine("");
                        Q10();
                        break;
                    case 11:
                        Console.WriteLine("");
                        Q11();
                        break;
                    case 12:
                        Console.WriteLine("");
                        Q12();
                        break;
                    case 13:
                        Console.WriteLine("");
                        Q13();
                        break;
                    case 14:
                        Console.WriteLine("");
                        Q14();
                        break;
                    case 15:
                        Console.WriteLine("");
                        Q15();
                        break;
                    case 16:
                        Console.WriteLine("");
                        Q16();
                        break;
                    case 18:
                        Console.WriteLine("");
                        Q18();
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }

                Console.WriteLine(); // Add a blank line for better readability
            }

        }


        //Write a  c# program to create and display a Singly Linked List.
        static void Q1()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            list.PrintAll();
        }

        //Write a  c# program to create a singly linked list of n nodes and display it in reverse order.
        static void Q2()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();
            Console.WriteLine("----- Print Reverse order -----");
            list.PrintedReverse();
        }

        //Write a  c# program to create a singly linked list of n nodes and count the number of nodes.
        static void Q3()
        {
            Console.WriteLine("Enter the number of nodes you want to create:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n == 0) { return; }

            LinkedList<string> list = new LinkedList<string>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter data for nodes number " + i +" :");
                list.AddLast(Console.ReadLine());
            }

            Console.WriteLine("You have entered the value of all nodes");
            Console.WriteLine("----- Print -----");
            list.PrintAll();
        }

        //Write a  c# program to insert a node at any position in a Singly Linked List.
        static void Q4()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- Print after add h in position 2 -----");
            list.AddINIndex(2, "g");
            list.PrintAll();
        }

        // Write a  c# program to insert a node at the beginning of a Singly Linked List.
        static void Q5()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- Print after add h in the beginning -----");
            list.AddFirst("h");
            list.PrintAll();
        }


        //Write a  c# program to insert a node at the end of a Singly Linked List.
        static void Q6()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- Print after add h in the end -----");
            list.AddLast("h");
            list.PrintAll();
        }

        //Write a  c# program to get a node in an existing singly linked list.
        static void Q7()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- GET AND Print Node num 3 -----");
            var Node3 = list.getNode(3);
            Console.WriteLine("Node number: 3");
            Console.WriteLine("Node data:" + Node3.data);
        }


        //Write a  c# program to find the first index that matches a given element. Return -1 for no matching.
        static void Q8()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- find the first index that matches a given element (c) -----");
            Console.WriteLine("Index: " + list.FindFirstIndex("c"));
        }

        //Write a  c# program to check whether a single linked list is empty or not. Return true otherwise false.
        static void Q9()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("-----single linked list is empty : " + list.IsNull());
            
        }


        //Write a  c# program to empty a singly linked list by pointing the head towards null.
        static void Q10()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            list.EmptyList();

            Console.WriteLine("----- Print after empty a singly linked list -----");
            list.PrintAll();
        }

        //Write a  c# program that removes the node from the singly linked list at the specified index.
        static void Q11()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            list.Remove(2);

            Console.WriteLine("----- Print after remove node in index 2 -----");
            list.PrintAll();
        }

        //Write a  c# program that calculates the size of a Singly Linked list.
        static void Q12()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();
            Console.WriteLine("list Size: " + list.Size());

        }

        //Write a c# program that removes the first element from a Singly Linked list.
        static void Q13()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            list.Remove(0);

            Console.WriteLine("----- Print after remove first node -----");
            list.PrintAll();

        }

        //Write a  c# program that removes the tail element from a Singly Linked list.
        static void Q14()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            list.Remove(list.Size());

            Console.WriteLine("----- Print after remove tail node -----");
            list.PrintAll();

        }

        //Write a  c# program to convert a Singly Linked list into an array.
        static void Q15()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            var arr = list.ToArray();

            Console.WriteLine("----- Print from array -----");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }

        //Write a  c# program to convert a Singly Linked list into a string.
        static void Q16()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            var text = list.ToString();

            Console.WriteLine("----- Print from String -----");
            Console.WriteLine(text);
        }

        // Write a c# program to check if an element is present in the Singly Linked list.
        static void Q18()
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("a");
            list.AddLast("b");
            list.AddLast("c");
            list.AddLast("d");
            list.AddLast("e");

            Console.WriteLine("----- Print -----");
            list.PrintAll();

            Console.WriteLine("----- check if an element (c) is present in the list -----");
            Console.WriteLine(list.FindFirstIndex("c") > 0 ? "is present in list" : "is not present in list");

        }

    }

}
