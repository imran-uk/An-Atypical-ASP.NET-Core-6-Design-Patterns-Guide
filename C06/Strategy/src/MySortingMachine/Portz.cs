namespace MySortingMachine;

public class Portz
{
    // TODO
    // how to set this to asc by default??
    public ISortPortStrategy SortStrategy { get; set; } = new SortStrategyDefault();

    public IEnumerable<int> Items { get; private set; }

    public Portz(IEnumerable<int> items) => Items = items;

    public void Sort()
    {
        if (SortStrategy == null)
        {
            throw new NullReferenceException("Sort strategy not found.");
        }
        Items = SortStrategy.Sort(Items);
    }
}
