using System.Runtime.Intrinsics.Arm;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("enter your name:");
        string? name = Console.ReadLine();
        System.Console.WriteLine($"Hello, {name}");
        System.Console.WriteLine("How are you?");
    }
}
