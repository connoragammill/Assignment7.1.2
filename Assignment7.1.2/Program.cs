namespace Assignment7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string word1 = "abc";
			string word2 = "pqr";

			string mergedWord = MergeStrings(word1, word2);
			Console.WriteLine($"The merged string is: {mergedWord}");
		}

		public static string MergeStrings(string word1, string word2)
		{
			int maxLength = 0;
			if (word1.Length > word2.Length)
			{
				maxLength = word1.Length;
			}
			else
			{
				maxLength = word2.Length;
			}
			char[] result = new char[word1.Length + word2.Length];
			int index = 0;

			for (int i = 0; i < maxLength; i++)
			{
				if (i < word1.Length)
				{
					result[index++] = word1[i];
				}

				if (i < word2.Length)
				{
					result[index++] = word2[i];
				}
			}

			return new string(result);
		}
	}
}
