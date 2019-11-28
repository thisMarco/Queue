namespace Queue
{
    class Node
    {
        public int Value { get; set; }
        public Node nextNode = null;

        public Node() { }
        public Node(int newElement)
        {
            Value = newElement;
        }
    }
}
