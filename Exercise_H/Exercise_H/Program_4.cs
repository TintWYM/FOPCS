using System;
namespace Exercise_H
{
	public class Program_4
	{
		public static void Main(string[] args) {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            Program_2.PrintArray(A);
            setArray(A,999);
            Program_2.PrintArray(A);
        }

        private static void setArray(int[] arr, int value) {
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = value;
            }
        }
    }
}

