using System;
using System.Threading;
using System.Threading.Tasks;

namespace massa
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] mass =new int[10];
			Random r1 = new Random();
			int p=mass[0];


			var task1 = Task.Factory.StartNew(() =>    
			{
				Thread.Sleep(2000);
				for (int i = 0; i < mass.Length; i++)
				{
					mass[i] = r1.Next(0, 100);
					Console.WriteLine($"Индекс массива {i}: "+mass[i]);
				}
				var task2 = Task.Factory.StartNew(() => 
				{
					
					Thread.Sleep(3000);
					for (int i = 1; i < mass.Length; i++)
					{
						if (mass[i]>p)
						{
							p =+ mass[i];
						}
						
					}
					Console.WriteLine("Максимальное значение в массиве: "+p);
					var task3 = Task.Factory.StartNew(() =>
					{
						Thread.Sleep(4000);
						int temp;
						for (int i = 0; i < mass.Length - 1; i++)
						{
							for (int j = i + 1; j < mass.Length; j++)
							{
								if (mass[i] > mass[j])
								{
									temp = mass[i];
									mass[i] = mass[j];
									mass[j] = temp;
								}
							}
						}

						Console.WriteLine("Вывод отсортированного массива");
						for (int i = 0; i < mass.Length; i++)
						{
							Console.WriteLine($"{i}: "+mass[i]);
						}
					});
				});
			});
			task1.Wait(); 
			

			Console.ReadLine();
		}

        
    }
}
