using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mas3
{
    class Program
    {
        static int[] mas1 = new int[20];
        static int[] mas2 = new int[20];
        static int[] mas3 = new int[20];
        static bool start1 = false;
        static bool start2 = false;
        static void Main(string[] args)
        {
            Task task1 = new Task(
                () =>
                {
                    Thread.CurrentThread.IsBackground = false;
                    Random random = new Random();
                    for (int i = 0; i < 20; i++)
                    {
                        mas1[i] = random.Next(1, 50);
                        mas2[i] = random.Next(1, 50);
                    }
                    start1 = true;
                });
            task1.Start();
            Thread.Sleep(500);
            Task task2 = new Task(
                () =>
                {
                    while (true)
                    {
                        Thread.CurrentThread.IsBackground = false;
                        int temp1;
                        for (int i = 0; i < 20; i++)
                        {
                            if (mas1[i] != 0 && mas2[i] != 0)
                            {
                                for (int j = i + 1; j < 20; j++)
                                {
                                    if (mas1[i] > mas1[j])
                                    {
                                        temp1 = mas1[i];
                                        mas1[i] = mas1[j];
                                        mas1[j] = temp1;
                                    }
                                }
                            }
                        }
                        int temp2;
                        for (int i = 0; i < 20; i++)
                        {
                            if (mas1[i] != 0 && mas2[i] != 0)
                            {
                                for (int j = i + 1; j < 20; j++)
                                {
                                    if (mas2[i] > mas2[j])
                                    {
                                        temp2 = mas2[i];
                                        mas2[i] = mas2[j];
                                        mas2[j] = temp2;
                                    }
                                }
                            }
                        }
                        start2 = true;
                    }
                });
            task2.Start();
            Thread.Sleep(500);
            Task task3 = new Task(
                () =>
                {
                    Thread.CurrentThread.IsBackground = false;
                    for (int i = 0; i < 20; i++)
                    {
                        if (mas1[i] != 0 && mas2[i] != 0)
                        {
                            mas3[i] = mas1[i] + mas2[i];
                            Console.WriteLine($"Число {i}= " + mas3[i]);
                        }
                    }
                });
            if (start1 && start2)
            {
                task3.Start();
            }
}
    }
}
