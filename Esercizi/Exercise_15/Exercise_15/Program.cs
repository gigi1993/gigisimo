using System;

namespace Exercise_15
{
	class MainClass
	{

		static string[] laudatory_phrases = new string[]
		{"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
		static string[] laudatory_story = new string[] 
		{"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
		static string[] first_name = new string[]  {"Dayan", "Stella", "Hellen", "Kate"};
		static string[] second_name = new string[] {"Johnson", "Peterson", "Charls"};
		static string[] city = new string[] {"London", "Paris", "Berlin", "New York", "Madrid"};
		static Random index_generator;

		public static void Main (string[] args)
		{
			index_generator = new Random();
			string phrase = ChooseRandomly(laudatory_phrases);
			string story = ChooseRandomly(laudatory_story);
			string name = ChooseRandomly(first_name);
			string surname = ChooseRandomly(second_name);
			string town = ChooseRandomly(city);

			Console.WriteLine("{0} {1} -- {2} {3}, {4}", phrase, story, name, surname, town);
		}
		static string ChooseRandomly(string[] sentence)
		{
			int index = index_generator.Next(sentence.Length);
			string result = sentence[index];
			return result;
		}

	}
}
