using System;
namespace Exercise_F
{
	public class Program_5
	{
		public static void Main(string[] args) {
            string[] names = { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = { 63, 29, 75, 82, 55 };

            Console.WriteLine("Report sorted in descending order of marks");

            // bubble sort - refer to topic 1 page 19
            for (int m = 0; m < names.Length - 1; m++)
            {
                for (int ij = 0; ij < marks.Length - 1; ij++)
                {
                    if (marks[ij] < marks[ij + 1]) // sorts by marks
                    {
                        int temp = marks[ij + 1];
                        string temp2 = names[ij + 1];

                        marks[ij + 1] = marks[ij];
                        names[ij + 1] = names[ij];

                        marks[ij] = temp;
                        names[ij] = temp2;
                    }
                }
            }

            // prints names + marks
            for (int m = 0; m < names.Length; m++)
            {
                Console.WriteLine(names[m] + "\t" + marks[m]);
            }

            Console.WriteLine("\nReport sorted alphabetically");

            // same bubble sort as above
            for (int m = 0; m < names.Length - 1; m++)
            {
                for (int ij = 0; ij < marks.Length - 1; ij++)
                {
                    if (names[ij].CompareTo(names[ij + 1]) == 1) // sorts by name
                    {
                        int temp = marks[ij + 1];
                        string temp2 = names[ij + 1];

                        marks[ij + 1] = marks[ij];
                        names[ij + 1] = names[ij];

                        marks[ij] = temp;
                        names[ij] = temp2;
                    }
                }
            }

            // prints names + marks
            for (int m = 0; m < names.Length; m++)
            {
                Console.WriteLine(names[m] + "\t" + marks[m]);
            }
        }
	}
}

