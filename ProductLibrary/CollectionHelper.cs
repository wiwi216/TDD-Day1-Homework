using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class CollectionHelper
    {
        public IEnumerable<int> GetGroupSumByField<T>(IEnumerable<T> dataSource, int countInGroup, string fieldName)
        {
            return dataSource.Select((value, index) => new { GroupNum = index / countInGroup, value })
                .GroupBy(group => group.GroupNum)
                .Select(group => group.Select(g => Convert.ToInt32(g.value.GetType().GetProperty(fieldName).GetValue(g.value, null))).Sum())
                .ToArray();
        }
    }
}
