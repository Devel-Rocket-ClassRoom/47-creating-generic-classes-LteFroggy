using System;

class SimpleQueue<T> {
    private T[] _items;
    private int _front;
    private int _back;
    private int _size;
    private int _capacity;

    public int Count => _size;
    public bool IsFull => _size == _capacity;
    public bool IsEmpty => _size == 0;

    public SimpleQueue(int capacity) {
        _items = new T[capacity];
        _front = 0;
        _back = 0;
        _capacity = capacity;
        _size = 0;
    }
    public void Enqueue(T item) {
        if(IsFull) {
            Console.WriteLine($"큐가 가득 찼습니다.");
            return;
        }
        _items[_back++] = item;
        _back %= _capacity;
        _size++;
    }

    public T Dequeue() {
        if (IsEmpty) {
            Console.WriteLine($"큐가 비어있습니다.");
            return default(T);
        }
        _size--;
        
        // 이전 바퀴 _front가 증가된 후 %= 연산을 수행하지 못했으므로, 이번 바퀴에 수행
        _front %= _capacity;

        return _items[_front++];
    }

    public T Peek() {
        if (IsEmpty) {
            Console.WriteLine($"큐가 비어있습니다.");
            return default(T);
        }

        _front %= _capacity;
        return _items[_front];
    }
}