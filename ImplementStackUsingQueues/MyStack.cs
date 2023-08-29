using System;



public class MyStack
{
    private Queue<int> queue1;
    private Queue<int> queue2;

    public Queue<int> Queue1 => queue1;
    public Queue<int> Queue2 => queue2;

    public MyStack()
    {
        queue1 = new Queue<int>();
        queue2 = new Queue<int>();
    }

    public void Push(int x)
    {
        queue1.Enqueue(x);
        queue2 = queue1;
    }

    public int Pop()
    {
        int num = queue1.Reverse().First();
        Console.WriteLine("Need to Dequeue this " + num);
        
        List<int> ints = new List<int>();
        ints = queue1.ToList();
        ints.RemoveAt(queue1.Count - 1); //Remove the last 
        queue1.Clear();

        for(int i =0; i < ints.Count; i++)
        {
            queue1.Enqueue((int)ints[i]);
        }
        

        return num;
    }

    public int Top()
    {
        int num;
        num = queue2 != null ? queue2.Reverse().First() : 0; //Can't call double returns...only return a local variable.
        return num;
    }

    public bool Empty()
    {
        bool isEmpty = queue1.Count == 0;
        return isEmpty;
    }

    public override string ToString() => String.Join(',',queue2.Reverse());
    
}

