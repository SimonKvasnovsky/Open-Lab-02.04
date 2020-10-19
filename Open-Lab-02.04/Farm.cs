using System;

namespace Open_Lab_02._04
{
    class Farm
    {
        public int GetLegsCount(int chickens, int cows, int pigs)
        {
            chickens = 2 * chickens;
            cows = 4 * cows;
            pigs = 4 * pigs;
            int GetLegsCount = (chickens + cows + pigs);
            return GetLegsCount;

        }
    }
}
