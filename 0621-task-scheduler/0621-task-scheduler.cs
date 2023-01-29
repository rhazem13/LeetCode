public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var dict = new Dictionary<char, int>();

        foreach (var task in tasks)
        {
            dict[task] = dict.ContainsKey(task) ? dict[task] + 1 : 1;
        }

        var max = dict.Max(d => d.Value);

        var count = dict.Count(d => d.Value == max);

        return max * count + Math.Max(tasks.Length - max * count, (max - 1) * (n - count + 1));
    }
}