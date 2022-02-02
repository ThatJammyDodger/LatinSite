using Newtonsoft.Json;

namespace LatinVocabTest.Data
{
    public class results
    {
        public string In_English { get; set; }
        public string In_Latin { get; set; }
        public string Mode { get; set; }
        public bool HintsUsed { get; set; }
        public bool Correct { get; set; }

        public static List<results> all_results = new List<results>();
        public static int totalAsked { get; set; }
        public static int totalCorrect { get; set; }

        public results(string eng, string lat, string mode, bool hints, bool right)
        {
            In_English = eng;
            In_Latin = lat;
            Mode = mode;
            HintsUsed = hints;
            Correct = right;

            if (right) { totalCorrect++; }
            totalAsked++;

            all_results.Add(this);
        }

        public override string ToString()
        {
            return $"English: {In_English }\nLatin: { In_Latin }\nMode: { Mode }\nHinted: { HintsUsed }\nCorrect: { Correct }\n";
        }
    }

    public class AllResults
    {
        public List<results> all_results = new List<results>();
        public int totalAsked { get; set; }
        public int totalCorrect { get; set; }

        public void Update()
        {
            all_results = new List<results>(results.all_results);
            totalAsked = results.totalAsked;
            totalCorrect = results.totalCorrect;
        }

        public string JSONstring()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
