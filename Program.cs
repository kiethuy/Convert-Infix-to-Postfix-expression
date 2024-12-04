
using stack;

namespace StackStucture
{
    class Program
    {
        static public void Main()
        {
            StackStruct stack = new StackStruct(3, 0);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            //Console.WriteLine(stack.Pop());
            stack.ShowStack();
        }
    }
}