namespace ConsoleApp8
{
        internal class Program
        {
                static void Main(string[] args)
                {
                        List<Word> words = new List<Word>();

                        Word w1 = new Word { EnglishText = "hello", Translation = "Привет", ExampleSentence = "Hello World!" };
                        words?.Add(w1);

                        

                        words.Remove(w1);

                        foreach (Word word in words)
                        {
                                Console.WriteLine(word.ToString());
                        }

                        Console.WriteLine("The END");
                }
        }
}
