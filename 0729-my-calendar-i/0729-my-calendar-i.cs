public class MyCalendar {
    private List<int[]> data = null;

    public MyCalendar() {
        data = new List<int[]>();
    }
    
    public bool Book(int start, int end) {
        if (data.Count == 0 || data.Count != 0 && start >= data[data.Count - 1][1])
        {
            data.Add(new int[] { start, end });
            return true;
        }
        else if (end <= data[0][0])
        {
            data.Insert(0, new int[] { start, end});
            return true;
        }
        else if (data[0][0] < start && start < data[data.Count - 1][0])
        {
            int l = 0,
                h = data.Count - 1;
            
            while (l <= h)
            {
                int mid = l + (h - l) / 2;
                
                if (data[mid][0] == start)
                    return false;
                else if (data[mid][0] < start)
                    l = mid + 1;
                else
                    h = mid - 1;
            }
            
            if (data[l - 1][1] <= start && data[l][0] >= end)
            {
                data.Insert(l, new int[] { start, end });
                return true;
            }
        }
        
        return false;
    }
}