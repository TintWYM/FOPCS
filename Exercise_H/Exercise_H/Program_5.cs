using System;
namespace Exercise_H
{
	public class Program_5
	{
		public static void Main(string[] args) {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            Program_2.PrintArray(A);

			int[] B = ResizeArray(A, 10);
            Program_2.PrintArray(B);

			int[] C = ResizeArray(B, 3);
			Program_2.PrintArray(C);
        }

		public static int[] ResizeArray(int[] arr, int newSize) {
			int[] newArray = new int[newSize];

			int limit = Math.Min(arr.Length,newSize);

			for (int i = 0; i < limit; i++) {
				newArray[i] = arr[i];
			}

			return newArray;
		}
	}
}

