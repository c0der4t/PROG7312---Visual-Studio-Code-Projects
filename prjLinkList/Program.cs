Node n = new Node(6);
Node na = new Node(7);
Node nb = new Node(9);

n.next = na;
na.next = nb;

System.Console.WriteLine(countFromGivenNode(n));


static int countFromGivenNode (Node Head) {

    int count = 0;
    Node current = Head;

    while (current.next != null) {
        count++;
        current = current.next;
    }

    return count;
}