using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LatinVocabTest.Data.WordTypes
{
    public class noun
    {
        public string In_Latin { get; set; }
        public string In_English { get; set; }
        public string Other_Forms { get; set; }
        public string Gender { get; set; }
        public string Declension { get; set; }



        public override string ToString()
        {
            return $"Latin: {In_Latin}\nEnglish: {In_English}\nOther forms: {Other_Forms}";
        }

        public static List<noun> members = new List<noun>();

        public noun(string lat = "", string eng = "", string forms = "", string gen = "", string declension = "")
        {
            In_Latin = lat;
            In_English = eng;
            Other_Forms = forms;
            Gender = gen;
            Declension = declension;

            members.Add(this);
        }
    }
}
