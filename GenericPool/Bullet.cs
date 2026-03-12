using System;

class Bullet : IPoolable {
    public bool IsActive;
    public int X, Y;

    public void Fire(int x, int y) {
        X = x;
        Y = y;
        IsActive = true;
        Console.WriteLine($"총알 발사! 위치 : ({X}, {Y})");
    }

    public void Reset() {
        IsActive = false;
        X = 0;
        Y = 0;
        Console.WriteLine($"총알 반납됨");
    }
}