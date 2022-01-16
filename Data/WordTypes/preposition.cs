using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LatinVocabTest.Data.WordTypes
{
    public class preposition
    {
        public string In_Latin { get; set; }
        public string In_English { get; set; }
        public string Usage { get; set; }
        public string Other_Notes { get; set; }



        public override string ToString()
        {
            return $"Latin: {In_Latin}\nEnglish: {In_English}\nOther info: {Other_Notes}";
        }

        public static List<preposition> members = new List<preposition>();

        public preposition(string lat = "", string eng = "", string use = "", string inf = "")
        {
            In_Latin = lat;
            In_English = eng;
            Usage = use;
            Other_Notes = inf;

            members.Add(this);
        }
    }
}
