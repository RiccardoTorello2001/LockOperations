using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aumento
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			object padlock = new object();

			for (int i = 0; i < 5; i++)
			{
				Task conta = new Task(() =>
				{
					//Monitor
					//Monitor.Enter(padlock);
					//try
					//{
					//    n++;
					//    Thread.Sleep(1);
					//    Console.WriteLine($"n = {n}");
					//}
					//finally
					//{
					//    Monitor.Exit(padlock);
					//}

					//lock
					lock (padlock)
					{
						n++;
						Thread.Sleep(1);
						Console.WriteLine($"n = {n}");
					}

				});
				conta.Start();
			}
			Console.ReadLine();
		}
	}
}
