public class TimeMap {
    private Dictionary<string, List<Item>> dict;
    public TimeMap() {
        dict = new();
    }

    public void Set(string key, string value, int timestamp) {
        if (dict.ContainsKey(key)) dict[key].Add(new Item(timestamp, value));
        else {
            var list = new List<Item> { new(timestamp, value) };
            dict[key] = list;
        }
    }

    public string Get(string key, int timestamp) {
        if (!dict.TryGetValue(key, out var list) || timestamp < list[0].t)
            return "";
        int l = 0, r = list.Count - 1;
        while (r > l) {
            int m = l + (r - l + 1) / 2;
            if (timestamp > list[m].t)
                l = m;
            else if (timestamp < list[m].t)
                r = m - 1;
            else
                return list[m].value;
        }

        return list[l].value;
    }
    struct Item {
        public int t;
        public string value;
        public Item(int ta, string v) {
            t = ta;
            value = v;
        }
    }
}