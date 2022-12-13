namespace Making_Dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die(4);
            Console.WriteLine("Dice Roller");
            Console.WriteLine($"Die 1 = {die1.Roll}");
            die1.DrawRoll();
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.RollDie();
            Console.WriteLine($"Die 1 = {die1.Roll}");
            Console.WriteLine("Rolling");
            Thread.Sleep(500);
            die1.DrawRoll();
            Console.WriteLine($"Die 2 = {die2.Roll}");
            die2.DrawRoll();
        }
    }
}