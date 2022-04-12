using System.Collections.Generic;
using System.Security.Policy;

namespace SortingUtils
{
    public class BubbleSorting : ISorting
    {
        public List<int> Sort(List<int> olddata)
        {
            var data = new List<int>();
            data.AddRange(olddata);
            bool finished = false;
            while (!finished)
            {
                finished = true;
                for (int i = 0; i < data.Count - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        (data[i], data[i + 1]) = (data[i + 1], data[i]);
                        int v = data[i];
                        data[i] = data[i + 1];
                        data[i] = v;
                        finished = false;
                    }
                }
            }

            return data;
        }
    }
}