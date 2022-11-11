// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.Intrinsics.X86;

public class Stack <T>
{
    public T[] stack;
    private int top; // top points to the current element
    public int capacity; 
    //public int Capacity;

    public Stack(int capacity)
    {
        this.capacity = capacity;
        stack = new T[capacity];
        top = -1;
    }

    private bool isEmpty()
    {
        if (top == -1)
        {
            return true;
        }
        else return false;
    }

    private bool isFull()
    {
        if (top == capacity - 1) return true;
        else return false;
    }

    public void Push (T t) // Stores an object on top of the stack.
    {
        if (!isFull())
        {
            top = top + 1;
            stack[top] = t;
        }
        else return;
        
    } 
    public T Pop() //  Removes the object on top of the stack and returns it.
    {
        if (!isEmpty())
        {
            T removed = stack[top];
            top = top - 1;
            capacity = capacity - 1;
            return removed;
        }
        else
        {
            return default(T);
        }
    }
    public void Print () // Prints out all stack objects.
    {
        // this method prints the stack starting from the top element (last element)

        int temp = top;
        Console.WriteLine("the elements of the stack are:");
        while(temp >= 0)
        {
            Console.Write($"{stack[temp]}, ");
            temp--;
        }
        Console.WriteLine();

    }
    public void Peak () // Prints the object on top of the stack if exists without removing it.
    {
        if (!isEmpty())
        {
            Console.WriteLine($"the Peak value is {stack[top]}");
        }
        else
        {
            Console.WriteLine("the Stack is Empty");
        }
    }
    public void Clear() // Removes all objects from the stack.
    {
        while(top >= 0)
        {
            Pop();
        }
        Console.WriteLine("the stack is empty now");
    }

}

public class test
{
    public static void Main(string[] args)
    {
        //int[] stack = new int[500];
        Stack<int> s = new Stack<int>(10);
        
        s.Push(7);
        s.Push(10);
        s.Push(8);
        s.Push(9);
        s.Push(12);
        s.Peak();
        s.Print();
        s.Pop();s.Pop();
        s.Peak();
        s.Clear();
    }
}
