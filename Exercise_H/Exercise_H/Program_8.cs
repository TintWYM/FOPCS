using System;
namespace Exercise_H
{
	public class Program_8
	{
		delegate double DoubleOps(double x);

		public static void Main(string[] args) {
			double[] A = new double[] { 1.0, 2.0, 3.0, 4.0 };
			DoubleOps MyOps = Square_root;

			double[] B = ProcessArray(A, MyOps);

			PrintArray(B);
		}

		static double[] ProcessArray(double[] arr, DoubleOps ops) {
			double[] newArray = new double[arr.Length];

			for (int i = 0; i < arr.Length; i++) {
				newArray[i] = ops(arr[i]);
            }

			return newArray;
		}

		static double Square_root(double x) {
			return Math.Sqrt(x);
		}

		static void PrintArray(double[] array) {
			Console.WriteLine("[");

			for (int i = 0; i < array.Length; i++) {
				Console.WriteLine(array[i] + "\t");
			}

			Console.WriteLine("]");
		}
    }
}

