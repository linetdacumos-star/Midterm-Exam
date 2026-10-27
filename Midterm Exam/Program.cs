using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> myStack = new Stack<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("===============================");
                Console.WriteLine(" STUDENT SERVICE QUEUE SYSTEM ");
                Console.WriteLine("===============================");
                Console.WriteLine("[1] - ADD STUDENT");
                Console.WriteLine("[2] - SHOW WAITING STUDENT");
                Console.WriteLine("[3] - SERVE NEXT STUDENT");
                Console.WriteLine("[4] - SHOW LAST SERVED STUDENT");
                Console.WriteLine("[5] - EXIT");
                Console.Write("Enter Choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("[1] - ADD STUDENT");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write($"\nEnter names of student {i + 1}: ");
                            names[i] = Console.ReadLine();

                            int totalSum = 0;
                            for (int r = 0; r < 3; r++)
                            {
                                Console.Write($" Enter the total number of waiting students {r + 1}: ");
                                scores[i, r] = int.Parse(Console.ReadLine());
                                totalSum += scores[i, r];
                            }
                            totals[i] = totalSum;
                        }
                        isRecorded = true;
                        Console.WriteLine("Student Successfully Served!\n");
                        break;

                    case "2":
                        Console.WriteLine("[2] - SHOW WAITING STUDENTS");
                        if (!isRecorded)
                        {
                            Console.WriteLine("Please record participant scores first!\n");
                            break;
                        {
                            Console.WriteLine($"{names[i],-12} {scores[i, 0],-5} {scores[i, 1],-5} {"scores[i, 2]",-5} {totals[i],5}");
                        }
                        Console.WriteLine();
                        break;


                }
            }
}