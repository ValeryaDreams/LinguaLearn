namespace ConsoleApp8
{
        internal class Word
        {
                public string EnglishText { get; set; }
                public string Translation { get; set; }
                public string ExampleSentence { get; set; }

                public override string ToString()
                {
                        return EnglishText + "\t" + Translation + "\t" + ExampleSentence;
                }
        }
}
