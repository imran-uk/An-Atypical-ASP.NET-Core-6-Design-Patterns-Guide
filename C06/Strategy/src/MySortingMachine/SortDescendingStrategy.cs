using System.Collections.Generic;
using System.Linq;

namespace MySortingMachine;

//public class SortDescendingStrategy : ISortStrategy
//{
//    public IOrderedEnumerable<string> Sort(IEnumerable<string> input)
//        => input.OrderByDescending(x => x);
//}

public class SortDescendingStrategy : ISortPortStrategy
{
    public IOrderedEnumerable<int> Sort(IEnumerable<int> input)
        => input.OrderByDescending(x => x);
}

// TODO check if better way to alias a method, i think threre is...
public class SortStrategyDefault : ISortPortStrategy
{
    public IOrderedEnumerable<int> Sort(IEnumerable<int> input)
    {
        return input.OrderByDescending(x => x);
    }
}

public class SortDescendingStrategyClassic : ISortStrategy
{
    public IOrderedEnumerable<string> Sort(IEnumerable<string> input)
    {
        return input.OrderByDescending(x => x);
    }
}
