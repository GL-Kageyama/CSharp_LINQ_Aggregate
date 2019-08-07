using System;
using System.Linq;
using System.Collections.Generic;

namespace Aggregate
{
	class MainClass 
	{
		public static void Main(string[] args)
		{
			var aggr = new aggregateClass();

			aggr.GetMax();

			aggr.GetMin();

			aggr.GetAve();

			aggr.GetSum();

			aggr.GetCount();

			aggr.GetAgg();
		}
	}

	class aggregateClass
	{
		List<int> source = new List<int>
		{
			2, 7, 8, 4, 9, 49, 36, 3, 8, 8, 26, 78, 65
		};

		// Max()
		// 最大値を取得
		public void GetMax()
		{
			Console.WriteLine(source.Max());
		}

		// Min()
		// 最小値を取得
		public void GetMin()
		{
			Console.WriteLine(source.Min());
		}

		// Average()
		// 平均値を取得
		public void GetAve()
		{
			Console.WriteLine(source.Average());
		}

		// Sum()
		// 合計を取得
		public void GetSum()
		{
			Console.WriteLine(source.Sum());
		}

		// Count()
		// 要素数を取得
		public void GetCount()
		{
			Console.WriteLine(source.Count());
		}

		// Aggregate()
		// 集計を取得
		public void GetAgg()
		{
			Console.WriteLine(source.Aggregate((now, next) => now + next));
		}
	}
}

