using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading.TPL
{
    public static class TaskSample
    {
         public   static void Test1()
        {
            Task t = Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine($"Running on Thread {Task.CurrentId}");
            });

            t.Wait(); // Wait until task finishes

            Console.WriteLine( "Done........." );
        }



        public static void MultipleTasksParallelly() {

            Task t1 = Task.Run(() => Work("Task 1"));
            Task t2 = Task.Run(() => Work("Task 2"));

            Task.WaitAll(t1, t2);
            Console.WriteLine("All tasks completed.");

            static void Work(string name)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"{name} → {i}");
                }
            }

        }

        public static void MultiParrallel()
        {
            Task.Run(() => 10)
            .ContinueWith(t => Console.WriteLine($"Result: {t.Result}"));
        }
        }
    }
