using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{//Q2使用 while , 在畫面顯示所有可以整除 300 的整數,例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 300;
			int result = 1;

			while (result < number1)
			{
				if (number1 % result == 0)
				{
					Console.WriteLine(result);
				}
				result += 1;
			}
		}
	}
}
