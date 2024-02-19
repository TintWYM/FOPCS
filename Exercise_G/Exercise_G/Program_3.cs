using System;
namespace Exercise_G
{
	public class Program_3
	{
		public static void Main(string[]args)
		{
			int[,] arr1 = { { 18, 82, 67, 33 }, { 3, 4, 3, 4 }, { 63, 35, 26, 87 }, { 77, 8, 98, 100 } };
			int[] totalMarks = new int[arr1.GetLength(0)];

			int[] avgSubject = new int[arr1.GetLength(1)];
			int avg = 0;

			for (int i = 0; i < arr1.GetLength(0); i++) {
				for (int j = 0; j < arr1.GetLength(1); j++) {
					totalMarks[i] += arr1[i, j];
					avg += arr1[i, j];
					avgSubject[j] += arr1[i, j];
				}

				Console.WriteLine($"Total marks of student{i + 1}{totalMarks[i]}");
			}

			for (int i = 0; i < arr1.GetLength(1); i++) {
				Console.WriteLine($"Average marks for subject{i + 1}:{avgSubject[i] / arr1.GetLength(1)}");
			}

			Console.WriteLine($"Overall marks : {avg / arr1.GetLength(0):F2}");
		}
	}
}

