using System;
namespace Exercise_G
{
	public class Program_2
	{
		public static void Main(string[]args)
		{
			Console.WriteLine("Descending order");

			int[] arr = { 3, 2, 1, 4, 0, 5, 7, 6, 9, 8 };

			int smallest;

			for (int i = 0; i < arr.Length; i++) {

				smallest = i;

				for (int j = i; j < arr.Length; j++) {

					if (arr[i] > arr[j]) {
						var temp = arr[i];
						arr[i] = arr[j];
						arr[j] = temp;
					}
				}

				foreach (int ele in arr) {
					Console.Write(ele);
				}

                Console.WriteLine();
            }
		}
	}
}

