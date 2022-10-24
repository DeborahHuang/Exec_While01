using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_While01
{//Q1 1+ 2 + 3 + 4 + .... + N<105請問 N 是多少?
	internal class Program
	{
		static void Main(string[] args)
		{
			int total = 0;
			int N = 1;

			while(total < 105)
			{
				if (total + N >= 105) break;
				total += N;
				N += 1;
			}

			Console.WriteLine(N-1);
		}
	}
}
