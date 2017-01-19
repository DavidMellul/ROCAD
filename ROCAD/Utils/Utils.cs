using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ROCAD.Utils
{
    public class Utils
    {
        private static Random rng = new Random();

        public static List<T> shuffleList<T>(List<T> list)
        {
            return list.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}