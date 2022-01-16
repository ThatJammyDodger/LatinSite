using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LatinVocabTest.Data.WordTypes;
using Newtonsoft.Json;

#nullable disable

namespace LatinVocabTest.Data
{
    class All_Types
    {
        public verb[] verbs = new verb[154];
        public noun[] nouns = new noun[124];
        public adjective[] adjectives = new adjective[56];
        public pronoun[] pronouns = new pronoun[18];
        public adverb[] adverbs = new adverb[53];
        public preposition[] prepositions = new preposition[18];
        public conjunction[] conjunctions = new conjunction[20];
        public particle[] particles = new particle[3];

        /*public void read_all_types(string filePath, out all_types type)
        {
            all_types everything = new all_types();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string jsonString = reader.ReadToEnd();
                everything = JsonConvert.DeserializeObject<all_types>(jsonString);
            }
            type = everything;
        }*/

        /*public void initialise()
        {
            verb.members.CopyTo(verbs);
            noun.members.CopyTo(nouns);
            adjective.members.CopyTo(adjectives);
            pronoun.members.CopyTo(pronouns);
            adverb.members.CopyTo(adverbs);
            preposition.members.CopyTo(prepositions);
            conjunction.members.CopyTo(conjunctions);
            particle.members.CopyTo(particles);
        }*/

        public int num_of_words()
        {
            return verbs.Length + nouns.Length + adjectives.Length + pronouns.Length + adverbs.Length + prepositions.Length + conjunctions.Length + particles.Length;
        }

    }
}
