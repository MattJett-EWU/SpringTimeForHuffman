using System;
using System.Diagnostics;

namespace SpringTimeForHuffman
{
	class AnnoyingAndLongFileNameJustForYouPhoenixButThankGodForTheTabKeyRight
	{
		public static void Main(string[] args)
		{
			string input;
			string encodeResult;
			string decodeResult;
			string dataRepresentation;

			try
			{
				Console.Write("=== HUFFMAN ENCODER ===\n\nInput: ");
				while ((input = Console.ReadLine()) != null && input.Length > 1)
				{
					// ENCODE w/ timer
					Stopwatch time;
					time = Stopwatch.StartNew();
					encodeResult = Huffman.Encode(input.Trim());
					time.Stop();

					// NODES w/ logical position and character
					dataRepresentation = Huffman.DataLiteral();

					// DECODE
					decodeResult = Huffman.Decode();

					// OUTPUT
					Console.WriteLine("\nNodes : " + dataRepresentation + "\nEncode: " + encodeResult + "\nDecode: " + decodeResult + "\n\n\n" +
						"Diagnostics\n-----------\n" + "Length: " + encodeResult.Length + "\n" + "Speed: " + time.ElapsedMilliseconds + "ms" + "\n\n\n");

					// NOTE: I made this class static, I felt there was no need to make this an object. 
					// therefore I use this Clear() method to wipe my class clean after each input is entered.
					Huffman.Clear();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("ERROR: Input was invalid, run program again.\n");
			}
		}
	}
}
