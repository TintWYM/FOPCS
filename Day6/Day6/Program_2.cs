using System;
namespace Day_6
{
	public class Program_2
	{
		public static void Main(string[] args) {
            string upperPlainText = ReturnUpperInputSentence();
            string encryptedText = EncryptSentence(upperPlainText);
            PrintEncryptedSentence("The encrypted sentence is " + encryptedText);
            string decryptedText = DecrpytSentence(encryptedText);
            PrintDecryptedSentence("The decrypted sentence is " + decryptedText);
            Console.WriteLine("\nType any key to exit.");
            Console.ReadLine();
        }

        private static string ReturnUpperInputSentence() {
            Console.Write("Please enter the setence: ");

            string sent = Console.ReadLine();

            return sent.ToUpper();
        }

        private static string EncryptSentence(string upperPlainText) {
            string s = "";

            for (int i = 0; i < upperPlainText.Length; i++) {
                char Ch = upperPlainText[i];

                if (char.IsLetter(Ch))
                {
                    if ((int)Ch >= (int)'X')
                    {
                        s += (char)((int)Ch - 23);
                    }
                    else
                    {
                        s += (char)((int)Ch + 3);
                    }
                }
                else {
                    s += Ch;
                }
            }

            return s;
        }

        private static void PrintEncryptedSentence(string encryptedText)
        {
            Console.WriteLine(encryptedText);
        }

        private static void PrintDecryptedSentence(string decryptedText)
        {
            Console.WriteLine(decryptedText);
        }

        private static string DecrpytSentence(string isEncryptedText)
        {
            string s = "";

            for (int i = 0; i < isEncryptedText.Length; i++)
            {
                char Ch = isEncryptedText[i];

                if (char.IsLetter(Ch))
                {
                    if ((int)Ch >= (int)'X')
                    {
                        s += (char)((int)Ch + 23);
                    }
                    else
                    {
                        s += (char)((int)Ch - 3);
                    }
                }
                else
                {
                    s += Ch;
                }
            }

            return s;
        }
    }
}

