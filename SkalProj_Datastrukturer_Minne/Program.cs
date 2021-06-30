using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {


        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            /*1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir
                 genomförbar.*/

            List<string> theList = new List<string>();
            bool done = false;
            do
            {

                Console.WriteLine("\n+ to add\n- to remove\n0 to exit\n");

                string input = Console.ReadLine();
                char nav = ' ';
                string value = "";
                try
                {
                    while (input.Length == 1 && (input[0] == '+' || input[0] == '-'))
                    {
                        Console.WriteLine("\nplease enter also a word\n");
                        input = Console.ReadLine();
                    }

                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine($"\nCurrent capacity: { theList.Capacity}");
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine($"\nCurrent capacity: { theList.Capacity}");
                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nplease use only + or -");
                        break;
                }
            } while (!done);


            //2.När ökar listans kapacitet ? (Alltså den underliggande arrayens storlek)
            /*Kapaciteten ökar när antalet element i listan är lika med den.*/

            //3.Med hur mycket ökar kapaciteten?
            /*Enligt min observation så dubbleras kapaciteten, när den ökar.

            //4.Varför ökar inte listans kapacitet i samma takt som element läggs till ?
            /*Jag gissar det har nåt att göra med prestandan. Om den ökar i samma takt, så antar jag att
            den underliggande arrayen måste expanderas varje gång vilket kan vara kostsamnt.*/


            //5.Minskar kapaciteten när element tas bort ur listan?
            /*Nej, den gör inte det hos mig.*/

            //6.När är det då fördelaktigt att använda en egendefinierad array istället för en lista ?
            /*Om man vet att kapaciteten inte varierar, så kan det vara fördelaktigt att använda en array. 
             *Dessutom kan det gå snabbt att jobba med en array då man accessar själva arrayen direkt och även indexerar i den utan att anropa "get()" metoder.*/


        }

        /// <summary>
        /// prints a reversed text found in a stack
        /// </summary>
        /// <param name="text"></param>
        private static void ShowReveresedWords(Stack<string> text)
        {
            Console.WriteLine("\ncurrent state of reversed the text: ");
            Console.WriteLine("----------------------");
            foreach (String word in text)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine();
        }

        private static void ShowCustomers(Queue<string> theQueue)
        {
            Console.WriteLine("\nPeople in line: ");
            Console.WriteLine("----------------------");
            foreach (String customer in theQueue)
            {
                Console.Write(customer + " ");
            }
            Console.WriteLine("\n----------------------");
            Console.WriteLine();
        }


        private static char GetOppositParentesis(char parentesis)
        {
            if (parentesis == ')')
                return '(';
            else if (parentesis == '}')
                return '{';
            else
                return '[';
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> theQueue = new Queue<string>();

            bool done = false;
            do
            {

                Console.WriteLine("\n+Customername to add an ICA-customer\n- to assist the first customer\n0 to exit\n");

                string input = Console.ReadLine();
                char nav = ' ';
                string value = "";
                try
                {

                    while (input.Length == 1 && input[0] == '+')
                    {
                        Console.WriteLine("\nplease enter also a customer name\n");
                        input = Console.ReadLine();
                    }

                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter ICA-customer name");
                }


                switch (nav)
                {
                    case '+':
                        theQueue.Enqueue(value);
                        ShowCustomers(theQueue);
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                        {
                            Console.WriteLine($"\nassisted: {theQueue.Dequeue()}");
                            ShowCustomers(theQueue);
                        }
                        else
                            Console.WriteLine("\nno customers in line");
                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nplease use only + or -");
                        break;
                }
            } while (!done);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */


            //1. Varför är det inte så smart att använda en stack i det här fallet?
            /*Det är inte smart för att den inte följer den köaktiga logiken. Det blir inte rättvist mot personer som kommit tidigare.*/


            Stack<string> theSackQueue = new Stack<string>();

            bool done = false;
            do
            {
                Console.WriteLine("\n+word to add word to reversed a text\n- to remove the last word\n0 to exit");

                string input = Console.ReadLine();
                char nav = ' ';
                string value = "";


                try
                {
                    while (input.Length == 1 && input[0] == '+')
                    {
                        Console.WriteLine("\nplease enter also a word\n");
                        input = Console.ReadLine();
                    }

                    nav = input[0];
                    value = input.Substring(1);
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Did not work, please enter a word");
                }
                switch (nav)
                {
                    case '+':
                        theSackQueue.Push(value);
                        ShowReveresedWords(theSackQueue);
                        break;
                    case '-':
                        if (theSackQueue.Count > 0)
                        {
                            theSackQueue.Pop();
                            ShowReveresedWords(theSackQueue);
                        }
                        else
                            Console.WriteLine("\nno text to reverse");
                        break;
                    case '0':
                        done = true;
                        break;
                    default:
                        Console.WriteLine("\nplease use only + or -");
                        break;
                }
            } while (!done);
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            //Vilken datastruktur använder du?
            /*Jag använder en stack då jag anser att den är lämplig i det här tillfället.*/

            bool isCorrect = true;

            Console.Write("\nEnter the string: ");
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char alphabet in input)
            {
                if (alphabet == '(' || alphabet == '{' || alphabet == '[')
                {
                    stack.Push(alphabet);
                }
                else if (alphabet == ')' || alphabet == '}' || alphabet == ']')
                {
                    if (stack.Count > 0 && stack.Pop() != GetOppositParentesis(alphabet))
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }

            if (!isCorrect || stack.Count > 0)
                Console.WriteLine("\nThe string is incorrect\n");
            else
                Console.WriteLine("\nThe string is correct\n");

        }

        /// <summary>
        /// Find the nth even number recursively
        /// </summary>
        /// <param name="n"></param>
        private static int RecursiveEven(int n)
        {
            if (n == 0)
                return 2;
            return RecursiveEven(n - 1) + 2;
        }

        /// <summary>
        /// Initiates the recursive method to find the nth even number
        /// </summary>
        private static void CalculateEven()
        {
            int number;
            Console.Write("\nEnter a number: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Please enter a valid number: ");
            }
            Console.WriteLine($"\nResult: {RecursiveEven(number)}\n");
        }


        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            /*
             1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess
                grundläggande funktion*/

            /* Stacken är en strukturerad datalagringssätt. När man t.ex anropar en metod, så läggs ett utryme överst på en stack. 
             * Det utrymmet behåller information som behövs utav metoden och sen tas det bort när anropet är klar. 
             * På samma sätt lagrar vi data i stacken och tar nytta av dess speciella funktioner där det är lämpligt. 

             *Heapen är däremot inte strukturerad som stacken men fördelen här är att den är flexibel. Till skillnad från stacken, är det inte bara heapens topp som vi har tillgång till.
             *Det gör att man/kompilatorn på något sätt måste veta vart man har lagrat data för senare borttagning. 
             
             
             Stack                                                                      Heap 
              | |                                                                       |2|        
              |3|<- stackens topp som vi alltid kommunicerar med                        |1|    <- inte så strukturerad men det går att komma åt vilket värde som helst så länge man vet var värdet finns
              |2|                                                                       | |  
              |1|                                                                       |3|
             
             */




            //2. Vad är Value Types repsektive Reference Types och vad skiljer dem åt?
            /*En variabel av value type innehåller själva värdet som är lagrad i den medans en reference type variable refererar ett objekt som lagrar värdet.*/

            //3. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?

            /* I den första så lever x och y i sina egna boxar. Om jag modifierar den ena, så har det ingen effekt på den andra.  
             * I den andra (p.g.a x = y satsen) refererar båda variablerna samma objekt. Det gör att ändringar som görs på x kan påverka y.  */



            Queue<int> myQueue = new Queue<int>(Enumerable.Range(1, 25));

            Console.WriteLine($"Queue length after Clear(): {myQueue.Count}.");

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Find the nth even element"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        CalculateEven();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

    }
}

