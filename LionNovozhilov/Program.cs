public class Program
{
    public static void Main()
    {
        Lion lion = new Lion();
        ZooWorker worker = new ZooWorker();

        lion.OnHungry += worker.FeedLion; // Подписка на событие

        lion.Walk();
    }
}