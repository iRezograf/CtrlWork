public class Arrays
{
    public void PrintArray(string [] arr)
    {
        Console.Write("[");
        foreach (var a in arr)
            Console.Write($"\"{a}\",");
        Console.Write($"\b] ");
    }
}