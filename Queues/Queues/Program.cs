using System;
using System.Collections.Generic;
using System.Collections;


namespace Queues
{
    class Program
    {

        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string elements = "";
            string dequeueAbfrage = "";
            Console.WriteLine("Für die Queue gebe Elemente ein die in die Queue sollen!");
            Console.WriteLine("Wenn du fertig bist schreibe: END");
           
            while (elements != "end")
            {

                elements = Console.ReadLine();
                if (elements.Equals ("END"))
                {
                    Console.WriteLine("Deine vorgegebene Queue:");
                    foreach (var item in queue)
                    {
                        Console.WriteLine($"Queue Element:  {item}");
                    }
                    //Console.WriteLine("Für dequeue deiner Queue schreibe : DEQEUEUE");
                    //do
                    //{

                    //    dequeueAbfrage = Console.ReadLine();
                    //    if (dequeueAbfrage.Equals("DEQUEUE"))
                    //    {
                    //        Console.WriteLine("Dein erstes Element ist: " + queue.Dequeue());
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Deine Eingabe war falsch");
                    //    }

                    //} while (dequeueAbfrage.Equals(""));
                    //Console.WriteLine("Programm end.");



                    //while (dequeueAbfrage != "ok")
                    //{
                    //    dequeueAbfrage = Console.ReadLine();
                    //    if (dequeueAbfrage.Equals("ok"))
                    //    {
                    //        if (dequeueAbfrage.Equals("dequeue"))
                    //        {
                    //            Console.WriteLine("Dein erstes Element ist: " + queue.Dequeue());
                    //        }
                    //        else
                    //        {
                    //            Console.WriteLine("deine Eingabe war falsch, wiederhole.");
                    //        }
                    //    }
                    //}




                }
                queue.Enqueue(elements);

            }

         







            Console.ReadKey();

        }
       
    }
}
