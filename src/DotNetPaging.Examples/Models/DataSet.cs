using System.Collections.Generic;

namespace DotNetPaging.Examples.Models
{
    public static class DataSet{

        static System.Random random = new System.Random();
        public static List<string> StringDataSet {get; set;} = new List<string>();

        public static void CreateDataSet(){

            for(int i = 0; i< 100;i++){

                var randomLetters = $"{GetLetter()}{GetLetter()}{GetLetter()}{GetLetter()}{GetLetter()}{GetLetter()}";
                StringDataSet.Add(randomLetters);
            }
        }

        public static string GetLetter()
        {
            // This method returns a random lowercase letter
            // ... Between 'a' and 'z' inclusize.
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let.ToString();
        }
    }
}
