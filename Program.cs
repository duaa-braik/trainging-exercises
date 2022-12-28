// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.Intrinsics.X86;

public class Stack <T>
{
    private T[] stack;
    private int top; // top points to the current element
    private readonly int MAX_SIZE = 10000;

    public Stack()
    {
        stack = new T[MAX_SIZE];
        top = -1;
    }

    private bool IsEmpty()
    {
        if (top == -1)
        {
            return true;
        }
        return false;
    }

    private bool IsFull()
    {
        if (top == stack.Length) return true;
        return false;
    }

    public void Push (T t) // Stores an object on top of the stack.
    {
        if (!IsFull())
        {
            top++;
            stack[top] = t;
        }
        
    } 
    public T Pop() //  Removes the object on top of the stack and returns it.
    {
        if (!IsEmpty())
        {
            T removed = stack[top];
            top--;
            return removed;
        }
        else
        {
            return default!;
        }
    }
    public void Print () // Prints out all stack objects.
    {
        // this method prints the stack starting from the top element (last element)
        Console.WriteLine("Elements of stack are:");
        for(int i = top; i > -1; i--)
        {
            Console.Write($"{stack[i]}, ");
        }
        Console.WriteLine();

    }
    public void Peak () // Prints the object on top of the stack if exists without removing it.
    {
        if (!IsEmpty())
        {
            Console.WriteLine($"the Peak value is {stack[top]}");
        }
        else
        {
            Console.WriteLine("Stack is Empty");
        }
    }
    public void Clear() // Removes all objects from the stack.
    {
        top = -1;
        Console.WriteLine("Stack is empty now");
    }

}

public class test
{
    public static void Main(string[] args)
    {
        Stack<int> s = new();
        
        s.Push(7);
        s.Push(10);
        s.Push(8);
        s.Push(9);
        s.Push(12);
        s.Peak();
        s.Print();
        Console.WriteLine($"Removed the elemnt: {s.Pop()}");
        Console.WriteLine($"Removed the elemnt: {s.Pop()}");
        s.Peak();
        s.Clear();
        s.Push(15);
        s.Print();
    }
}
