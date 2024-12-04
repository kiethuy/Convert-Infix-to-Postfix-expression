using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class StackStruct<T>
    {
        private T[] stack;
        private int top;
        private int maxSize;
        private int reseredSize;
        private int count = 0;
        public StackStruct(int maxSize, int reseredSize)
        {
            this.reseredSize=reseredSize;
            this.maxSize= maxSize;
            stack = new T[maxSize];
            top = reseredSize ;
        }
        public void Push(T value)
        {
            if (this.top!=maxSize)
            {
                stack[top] = value;
                this.top++;
                count++;
            }
            else
            {
                Console.WriteLine("ngăn xếp đã đầy");
            }
        }
        public T Pop()
        {
            T result = default(T);
            if (IsEmty())
            {
                Console.WriteLine("ngan xep rỗng");
            }
            else
            {
                result = stack[--this.top];
                stack[--this.top] = default;
                count--;
            }
            return result;
        }
        public T Peek()
        {
            return stack[this.top - 1];
        }
        public bool IsEmty()
        {
            if(this.top== this.reseredSize)
            {
                return true;
            }
            return false;
        }
        public int Count()
        {
            return this.count;
        }
        public void ShowStack()
        {
            for(int i = Count()-1; i >=this.reseredSize; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }

}
