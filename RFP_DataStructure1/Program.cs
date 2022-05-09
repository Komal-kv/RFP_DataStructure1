// See https://aka.ms/new-console-template for more information

using RFP_DataStructure1;

Console.WriteLine("Program for Stack and Queue");

LinkedListStack linkedListStack = new LinkedListStack();
linkedListStack.Push(70);
linkedListStack.Push(30);
linkedListStack.Push(56);
linkedListStack.Peek();

linkedListStack.Pop();
linkedListStack.IsEmpty();