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
        _items[(_back++) % _capacity] = item;
        _size++;
    }

    public T Dequeue() {
        if (IsEmpty) {
            Console.WriteLine($"큐가 비어있습니다.");
            return default(T);
        }
        _size--;
        return _items[(_front++) % _capacity];
    }

    public T Peek() {
        if (IsEmpty) {
            Console.WriteLine($"큐가 비어있습니다.");
            return default(T);
        }

        return _items[(_back - 1) % _capacity];
    }
}