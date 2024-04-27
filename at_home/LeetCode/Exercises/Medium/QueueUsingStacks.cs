using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    public class MyQueue
    {
        /// <summary>
        /// Stack -> Last In First Out
        /// Queue -> First In First Out 
        /// UNFINISHED 
        /// </summary>
        /// 
        public Stack<int> enqueue_stack;
        public Stack<int> dequeue_stack;
        public MyQueue()
        {
            enqueue_stack = new Stack<int>();
            dequeue_stack = new Stack<int>();
        }

        public void Push(int x)
        {
            enqueue_stack.Push(x);
        }

        public int Pop()
        {
            if (dequeue_stack.Count == 0)
            {
                while (enqueue_stack.Count > 0)
                {
                    dequeue_stack.Push(enqueue_stack.Pop());
                }
            }
            return dequeue_stack.Pop();
        }

        public int Peek()
        {
            if (dequeue_stack.Count == 0)
            {
                while (enqueue_stack.Count > 0)
                {
                    dequeue_stack.Push(enqueue_stack.Pop());
                }
            }
            return dequeue_stack.Peek();
        }

        public bool Empty()
        {
            return enqueue_stack.Count == 0 && dequeue_stack.Count == 0;
        }
    }

}