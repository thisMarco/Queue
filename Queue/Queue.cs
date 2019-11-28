using System;

namespace Queue
{
    class Queue
    {
        public Node firstNode = null;
        public Node lastNode = null;

        public void enQueue( int newElement) //Adding Element to the Queue
        {
            if (isEmpty())
            {
                firstNode = new Node(newElement);
                lastNode = firstNode;
            }
            else
            {
                lastNode.nextNode = new Node(newElement);
                lastNode = lastNode.nextNode;
            }
            //Console.WriteLine("\n\t\t{0} added to the Queue.", newElement);            
        }

        public Node deQueue() //Removing an element from the Queue
        {
            if (isEmpty())
            {
                Console.WriteLine("\n\n\t\t The Queue is Empty!");
                return null;
            }
            else
            {
                Node removedNode = firstNode;
                firstNode = firstNode.nextNode;
                removedNode.nextNode = null;                
                return removedNode;
            }
        }

        public bool isEmpty() //Check if the Queue is Empty
        {
            if (firstNode == null)
                return true;
            else
                return false;
        }

        public void displayQueue(Node nNode) //Display the Queue
        {
            if (!isEmpty())
            {
                if (nNode != lastNode)
                {
                    displayQueue(nNode.nextNode);
                    Console.Write("\t\t{0}\n", nNode.Value);
                }
                else
                    Console.Write("\t\t{0}\n", nNode.Value);
            }
            else
                Console.WriteLine("\t\tThe Queue is Empty!\n\t\tNothing to Display!");                        
        }
    }
}
