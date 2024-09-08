using System.Xml.Linq;



//добавлен комментарий
class Driver
{
    public int Round;
    public Thread Thrd;
    public string Name { get; set; }

    public Driver(string name)
    {
        this.Name = name;
        Round = 1;
        this.Thrd = new Thread(this.Run);
        Thrd.Start();
    }

    public void Run()
    {
        Console.WriteLine($"{Name} начал гонку");
        for (int i = 1; i < 10; i++)
        {
            
                Console.WriteLine($"На трассе {Name}, круг # {Round}");
                Thread.Sleep(500);
                Round++;
        }
                Console.WriteLine($"{Name} закончил гонку");
    }
}


class Program
{
    static void Main()
    {
        Console.WriteLine("Основной заезд начат");
        Driver speedy = new Driver("Молния");
        Driver greedy = new Driver("Ghosty");


        do
        {
            Thread.Sleep(100);

        } while (speedy.Thrd.IsAlive && greedy.Thrd.IsAlive);
        Console.WriteLine("Основной заезд окончен");

    }

        
    
}

