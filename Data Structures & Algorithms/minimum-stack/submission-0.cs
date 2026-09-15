public class MinStack {
    private List<int> _items;
    private List<int> _mins;

    public MinStack() {
        _items = new List<int>();
        _mins = new List<int>();
    }
    
    public void Push(int val) {
        int lastIndex = _mins.Count-1;
        if(_mins.Count == 0) _mins.Add(val);
        else if (val<_mins[lastIndex]) _mins.Add(val);
        else _mins.Add(_mins[lastIndex]);
        _items.Add(val);
    }
    
    public void Pop() {
        int lastIndex = _mins.Count-1;
        _mins.RemoveAt(lastIndex);
        _items.RemoveAt(_items.Count-1);
    }
    
    public int Top() {
        return _items[_items.Count-1];
    }
    
    public int GetMin() {
        int lastIndex = _mins.Count-1;
        return _mins[lastIndex];
    }
}
