using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LatinVocabTest.Data.WordTypes
{
    public class verb
    {
        public string In_English { get; set; }
        public string PP1 { get; set; }
        public string PP2 { get; set; }
        public string PP3{ get; set; }
        public string PP4 { get; set; }
        public string Conjugation { get; set; }
        public string Other_Info { get; set; }



        public override string ToString()
        {
            return $"English: {In_English}\nPrincipal Parts 1, 2, 3, 4:\n{PP1}, {PP2}, {PP3}, {PP4}\nConjugation: {Conjugation}\nOther info: {Other_Info}";
        }

        public static List<verb> members = new List<verb>();

        public verb(/*string lat = "",*/ string eng = "", string pp1 = "", string pp2 = "", string pp3 = "", string pp4 = "", string conj = "", string inf = "")
        {
            //In_Latin = lat;
            In_English = eng;
            PP1 = pp1;
            PP2 = pp2;
            PP3 = pp3;
            PP4 = pp4;
            Conjugation = conj;
            Other_Info = inf;

            members.Add(this);
        }
    }
}
