using System.Collections;

namespace ienumrablestack
{
  
        public class StackUsingLinkedlist<T>:IEnumerable<T>
        {

            // A linked list node
            private class Node<T>
            {
                // integer data
                public T data;

                // reference variable Node type
                public Node<T> link;
            }

            // create global top reference variable
            Node<T> top;

            // Constructor
            public StackUsingLinkedlist() { this.top = null; }

            // Utility function to add
            // an element x in the stack
            // insert at the beginning
            public void push(T x)
            {
                // create new node temp and allocate memory
                Node<T> temp = new Node<T>();

                // check if stack (heap) is full.
                // Then inserting an element
                // would lead to stack overflow
                if (temp == null)
                {
                    Console.Write("\nHeap Overflow");
                    return;
                }

                // initialize data into temp data field
                temp.data = x;

                // put top reference into temp link
                temp.link = top;

                // update top reference
                top = temp;
            }

            // Utility function to check if
            // the stack is empty or not
            public bool isEmpty() { return top == null; }

            // Utility function to return
            // top element in a stack
            public T peek()
            {
                // check for empty stack
                if (!isEmpty())
                {
                    return top.data;
                }
                else
                {
                    Console.WriteLine("Stack is empty");
                    return default;
                }
            }

            // Utility function to pop top element from the stack
            public void pop() // remove at the beginning
            {
                // check for stack underflow
                if (top == null)
                {
                    Console.Write("\nStack Underflow");
                    return;
                }

                // update the top pointer to
                // point to the next node
                top = (top).link;
            }

            public void display()
            {
                // check for stack underflow
                if (top == null)
                {
                    Console.Write("\nStack Underflow");
                    return;
                }
                else
                {
                    Node<T> temp = top;
                    while (temp != null)
                    {

                        // print node data
                        Console.Write(temp.data);

                        // assign temp link to temp
                        temp = temp.link;
                        if (temp != null)
                            Console.Write(" -> ");
                    }
                }
            }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = top;
            while (temp != null)
            {

                // print node data
                yield return temp.data;

                // assign temp link to temp
                temp = temp.link;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

        // Driver code
        public class GFG
        {
            public static void Main(String[] args)
            {
                // create Object of Implementing class
                StackUsingLinkedlist<int> obj
                    = new StackUsingLinkedlist<int>();

                // insert Stack value
                obj.push(11);
                obj.push(22);
                obj.push(33);
                obj.push(44);

                // print Stack elements
                obj.display();

                // print Top element of Stack
                Console.Write("\nTop element is {0}\n", obj.peek());
            
            foreach(int i in obj)
            {
                Console.WriteLine(i);
            }

                // print Top element of Stack
                Console.Write("\nTop element is {0}\n", obj.peek());
            }
        }

   
}