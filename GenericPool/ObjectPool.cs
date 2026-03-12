using System;
using System.Collections.Generic;

class ObjectPool<T> where T : class, IPoolable, new() {
    private List<T> _avaliable;
    private List<T> _active;
    
    private int _avaliableCount;
    private int _activeCount;

    private int _maxSize;
    public int AvaliableCount => _avaliableCount;
    public int ActiveCount => _activeCount;

    public ObjectPool(int capacity) {
        _avaliable = new List<T>(capacity);
        _active = new List<T>(capacity);

        _avaliableCount = 0;
        _activeCount = 0;

        _maxSize = capacity;
    }

    public T Get() {
        // 합이 capacity이상이면 null

        // 사용 가능한 것이 없으면, 만들어서 넣고 return
        if (_avaliableCount == 0) {
            // 만들 때, Capacity 넘어가면 null;
            if (_avaliableCount + _activeCount >= _maxSize) {
                Console.WriteLine($"풀이 가득 찼습니다!");
                return null;
            } 
            _active.Add(new T());
            return _active[_activeCount++];
        } 

        // 문제 없다면, avaliable에서 active로 옮기고 return
        else {
            _active.Add(_avaliable[_avaliableCount - 1]);
            _avaliable.RemoveAt(--_avaliableCount);
            return _active[_activeCount++];
        }
    }
    public void Return(T item) {
        item.Reset();
        _active.Remove(item);
        _activeCount--;
        _avaliable.Add(item);
        _avaliableCount++;
    }
}
