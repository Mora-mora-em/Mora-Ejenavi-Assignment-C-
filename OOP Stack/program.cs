class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Pop()); // Output: 2
        Console.WriteLine(stack.Pop()); // Output: 1
    }
}