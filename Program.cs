
using stack;

namespace StackStucture
{
    class Program
    {
        static public void Main()
        {
            ConvertToPostFixExpr convertToPostFixExpr= new ConvertToPostFixExpr();
            string input= "3+5+4";
            string output =convertToPostFixExpr.Convert(input.ToCharArray());
            Console.WriteLine(output);
        }
    }
}