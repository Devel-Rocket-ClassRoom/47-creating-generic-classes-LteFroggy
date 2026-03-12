using System;

ObjectPool<Bullet> bulletPool = new ObjectPool<Bullet>(3);
Bullet b1 = bulletPool.Get();
Bullet b2 = bulletPool.Get();
Bullet b3 = bulletPool.Get();

Console.WriteLine($"=== 총알 발사 ===");
b1.Fire(10, 20);
b2.Fire(30, 40);
b3.Fire(50, 60);
Console.WriteLine($"활성 : {bulletPool.ActiveCount}, 비활성 : {bulletPool.AvaliableCount}");
Console.WriteLine();

Console.WriteLine($"=== 풀 초과 시도 ===");
Bullet b4 = bulletPool.Get();
Console.WriteLine();

Console.WriteLine($"=== 반납 후 재사용 ===");
bulletPool.Return(b1);
Console.WriteLine($"활성 : {bulletPool.ActiveCount}, 비활성 : {bulletPool.AvaliableCount}");
b1 = bulletPool.Get();
b1.Fire(100, 200);
Console.WriteLine($"활성 : {bulletPool.ActiveCount}, 비활성 : {bulletPool.AvaliableCount}");

