using System;
using System.Collections.Generic;
using System.Linq;

namespace ROCAD.Utils
{
    public class Utils
    {
        private static Random rng = new Random();

        public static List<T> shuffleList<T>(List<T> list)
        {
            List<T> shuffledList = list.OrderBy(a => Guid.NewGuid()).ToList();
            Console.WriteLine(shuffledList.GetHashCode());
            Console.WriteLine(list.GetHashCode());
            return shuffledList;
        }

        public static string generateRandomProjectIdentifier()
        {
            return "";
        }
    }
}