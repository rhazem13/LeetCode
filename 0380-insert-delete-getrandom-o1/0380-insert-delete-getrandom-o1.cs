public class RandomizedSet
{
    private readonly Random rand = new();
    private readonly List<int> list = new();
    private readonly Dictionary<int, int> dict = new();
    
    public bool Insert(int val)
    {
        if (dict.TryAdd(val, list.Count))
        {
            list.Add(val);
            return true;
        }
        return false;
    }
    
    public bool Remove(int val)
    {
        if (dict.TryGetValue(val, out int idx))
        {
            dict[list[^1]] = idx;
            dict.Remove(val);
            list[idx] = list[^1];
            list.RemoveAt(list.Count - 1);
            return true;
        }
        return false;
    }
    
    public int GetRandom() => list[rand.Next(list.Count)];
}