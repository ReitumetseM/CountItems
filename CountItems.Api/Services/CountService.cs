using System.Collections.Generic;

namespace CountItems.Api.Services
{
    public interface ICountService
    {
        Dictionary<T, int> CountItems<T>(IEnumerable<T> items) where T : notnull;
    }

    public class CountService : ICountService
    {
        public Dictionary<T, int> CountItems<T>(IEnumerable<T> items) where T : notnull
        {
            var counts = new Dictionary<T, int>();
            
            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                    counts[item]++;
                else
                    counts[item] = 1;
            }
            
            return counts;
        }
    }
}