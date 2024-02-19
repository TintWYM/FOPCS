using System;
namespace Exercise_H
{
	public class Program_2
	{
		public static void Main(string[] args) {
			Console.WriteLine("Print Array() ");

			int[] arr = { 3, 2, 6, 7, 9, 0, 1, 4, 8, 5 };
			PrintArray(arr);

		}

		public static void PrintArray(int[] arr) {
			for (int i = 0; i < arr.Length; i++) {
				Console.Write(arr[i]);
			}
		}
	}
}

