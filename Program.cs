namespace Making_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die(4);
            Console.WriteLine("Dice Roller");
            Console.WriteLine($"Die 1 = {die1}");   // ToString() is automatically called
            die1.DrawRoll();
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.RollDie();
            Console.WriteLine($"Die 1 = {die1}");
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.DrawRoll();
            Console.WriteLine($"Die 2 = {die2}");
            die2.DrawRoll();
        }
    }
}