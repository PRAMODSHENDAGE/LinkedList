using LinkedListProblem;

LinkedList list = new LinkedList();
LinkedListStack stack = new LinkedListStack();
LinkedListQueue queue = new LinkedListQueue();
bool flag = true;
while (flag)
{
    Console.WriteLine("Select Program\n 1.Create LinkedList\n 2.Add Element in Reverse Order\n 3.Append Element in LinkedList\n 4.Insert Element At Particular Position\n 5.Delete First Element In LinkedList\n 6.Delete Last Element In LinkedList\n 7.Search Element In LinkedList\n 8.Insert Node After Particular Node\n 9.Delete Node & Find Size\n 10.Create Stack\n 11.Peek & Pop from Stack\n 12.Create Queue\n 13.Dequeue Element");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            break;

        case 2:
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            break;

        case 3:
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            break;

        case 4:
            list.Add(70);
            list.InsertAtGivenPosition(1, 30);
            list.Add(56);
            list.Display();
            break;

        case 5:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.PopFirst();
            list.Display();
            break;

        case 6:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.PopLast();
            list.Display();
            break;

        case 7:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Search(56);
            list.Display();
            break;

        case 8:
            list.Add(56);
            list.Add(30);
            list.Add(70); 
            list.InsertNodeAfterParticularNode(40, 30);
            list.Display();
            break;

        case 9:
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.DeleteNodeAtParticularPosition(2);
            list.Size();
            list.Display();
            break;

        case 10:
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            list.Display();
            break;

        case 11:
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Peek();
            stack.Pop();
            stack.Display();
            break;

        case 12:
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            break;

        case 13:
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Display();
            break;
    }
}