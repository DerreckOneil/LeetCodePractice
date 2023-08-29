using System;

public class MainProgram
{

    public static void Main(string[] args)
    {
        MyStack obj = new MyStack();
        obj.Push(1);
        obj.Push(2);
        obj.Push(3);

        Console.WriteLine(obj.ToString());
        int param_2 = obj.Pop();
        int param_3 = obj.Top();
        bool param_4 = obj.Empty();

        Console.WriteLine("Pop: " + param_2 
                         +"\nTop: " + param_3
                         +"\nEmpty: " + param_4);

        /*
        */
    }

}