﻿using System;
namespace Exercise_H
{
	public class Program_7
	{
		public static void Main(string[] args) {
			int[,] A = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
			PrintMatrix("A",A);

			int[,] B = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
			PrintMatrix("B", B);

			int[,] C = MatrixMultiply(A,B);
			PrintMatrix("C", C);
        }

		public static int[,] MatrixMultiply(int[,] A, int[,] B) {
			int[,] R = new int[A.GetLength(0), B.GetLength(1)];

			for (int i = 0; i < A.GetLength(0); i++) {
				for (int j = 0; j < B.GetLength(1); j++) {
					for (int k = 0; k < A.GetLength(0); k++) {
						R[i, j] = R[i, j] + A[i, k] * B[k, j];
					}
				}
			}
			return R;
		}

		public static void PrintMatrix(string name, int[,] A) {
            Console.WriteLine("----" + name + "----");

			for (int i = 0; i < A.GetLength(0); i++) {
				for (int j = 0; j < A.GetLength(1); j++) {
					Console.WriteLine(A[i, j] + "\t");
				}
			}

			Console.WriteLine();
        }
    }
}

