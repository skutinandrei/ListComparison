using System.Collections;
using System.Diagnostics;

namespace ListComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Stopwatch stopWatch = new Stopwatch();

            List<int> numbersInList = new List<int>();

            ArrayList numbersInArrayList = new ArrayList();

            LinkedList<int> numbersInLinkedList = new LinkedList<int>();

            stopWatch.Start();
            for (int i = 0; i < 1_000_000; i++)
            {   
                numbersInList.Add(rnd.Next(1, 10001));
            }
            stopWatch.Stop();

            var timeForFillingList = stopWatch.ElapsedMilliseconds;
            
            stopWatch.Restart();
            for (int i = 0; i < 1_000_000; i++)
            {
                numbersInArrayList.Add(rnd.Next(1, 10001));
            }
            stopWatch.Stop();
            var timeForFillingArrayList = stopWatch.ElapsedMilliseconds;
            

            stopWatch.Restart();
            for (int i = 0; i < 1_000_000; i++)
            {
                numbersInLinkedList.AddLast(rnd.Next(1, 10001));
            }
            stopWatch.Stop();
            var timeForFillingLinkedList = stopWatch.ElapsedMilliseconds;

            Console.WriteLine("RunTime for filling List: " + timeForFillingList + " milliseconds.");
            Console.WriteLine("RunTime for filling ArrayList: " + timeForFillingArrayList + " milliseconds.");
            Console.WriteLine("RunTime for filling LinkedList: " + timeForFillingLinkedList + " milliseconds.");



            stopWatch.Restart();
            Console.WriteLine(numbersInList[496752]);
            stopWatch.Stop();
            var timeForFindingElementByIndexInList = stopWatch.ElapsedMilliseconds;
            
            stopWatch.Restart();
            Console.WriteLine(numbersInArrayList[496752]);
            stopWatch.Stop();
            var timeForFindingElementByIndexInArrayList = stopWatch.ElapsedMilliseconds;

            stopWatch.Restart();
            Console.WriteLine(numbersInLinkedList.ElementAt(496752));
            stopWatch.Stop();
            var timeForFindingElementByIndexInLinkedList = stopWatch.ElapsedMilliseconds;

            Console.WriteLine("RunTime for finding 496753 element in List: " + timeForFindingElementByIndexInList + " milliseconds.");
            Console.WriteLine("RunTime for finding 496753 element in ArrayList: " + timeForFindingElementByIndexInArrayList + " milliseconds.");
            Console.WriteLine("RunTime for finding 496753 element in LinkedList: " + timeForFindingElementByIndexInLinkedList + " milliseconds.");


            stopWatch.Restart();
            foreach (int item in numbersInList)
            {
                if (item % 777 == 0) 
                {
                    Console.WriteLine(item);
                }

            }
            stopWatch.Stop();
            var timeForFindingElementInList = stopWatch.ElapsedMilliseconds;

            stopWatch.Restart();
            foreach (int item in numbersInArrayList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }

            }
            stopWatch.Stop();
            var timeForFindingElementInArrayList = stopWatch.ElapsedMilliseconds;

            stopWatch.Restart();
            foreach (int item in numbersInLinkedList)
            {
                if (item % 777 == 0)
                {
                    Console.WriteLine(item);
                }
            }
            stopWatch.Stop();
            var timeForFindingElementInLinkedList = stopWatch.ElapsedMilliseconds;

            Console.WriteLine("RunTime for finding number in List which devides by 777 : " + timeForFindingElementInList + " milliseconds.");
            Console.WriteLine("RunTime for finding number in ArrayList which devides by 777 : " + timeForFindingElementInArrayList + " milliseconds.");
            Console.WriteLine("RunTime for finding number in LinkedList which devides by 777 : " + timeForFindingElementInLinkedList + " milliseconds.");

        }
    }
}
