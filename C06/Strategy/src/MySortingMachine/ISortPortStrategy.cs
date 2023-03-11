namespace MySortingMachine;

public interface ISortPortStrategy
{
    IOrderedEnumerable<int> Sort(IEnumerable<int> input);
}
