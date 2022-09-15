using LinkedListProblem;

LinkedList list = new LinkedList();
bool flag = true;
while (flag)
{
    Console.WriteLine("Select Program\n 1.Create LinkedList\n 2.Add Element in Reverse Order\n 3.Append Element in LinkedList");
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
    }
}