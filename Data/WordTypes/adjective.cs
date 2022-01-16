using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LatinVocabTest.Data.WordTypes
{
    public class adjective
    {
        public string In_Latin { get; set; }
        public string In_English { get; set; }
        public string Other_Forms { get; set; }



        public override string ToString()
        {
            return $"Latin: {In_Latin}\nEnglish: {In_English}\nOther forms: {Other_Forms}";
        }

        public static List<adjective> members = new List<adjective>();

        public adjective(string lat = "", string eng = "", string forms = "")
        {
            In_Latin = lat;
            In_English = eng;
            Other_Forms = forms;
            
            members.Add(this);
        }
    }
}
