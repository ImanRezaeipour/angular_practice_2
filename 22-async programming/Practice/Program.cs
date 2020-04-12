using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			var task1 = DoSomeThingAsync(1, 2);

			var task2 = DoSomeThingAsync(4, 4);

			Task.WaitAll(task1, task2);

			System.Console.WriteLine(task1.Result);

			System.Console.WriteLine(task2.Result);

			System.Console.ReadLine();
		}

		private static async Task<int> DoSomeThingAsync(int number1, int number2)
		{
			return await Task.Run(() =>
			{
				System.Threading.Thread.Sleep(2000);
				return number1 * number2;
			});
		}
	}
}