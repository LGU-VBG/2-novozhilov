using System;
using System.Threading;

public class Lion
{
    public delegate void LionHungryDelegate();

    public LionHungryDelegate OnHungry;

    public void Walk()
    {
        for (int hour = 1; hour <= 12; hour++)
        {
            Console.WriteLine($"Час {hour}: Лев гуляет...");
            Thread.Sleep(1000); // Имитация времени

            if (hour == 5)
            {
                OnHungry?.Invoke(); // Вызываем событие голода
            }
        }
    }
}

public class ZooWorker
{
    public void FeedLion()
    {
        Console.WriteLine("Работник зоопарка: Лев голоден! Я его кормлю.");
    }
}

