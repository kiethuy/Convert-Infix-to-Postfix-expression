using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class ConvertToPostFixExpr
    {
        char[] postFix;
        List<Tuple<char, int>> operators;
        public ConvertToPostFixExpr()
        {
            operators = new List<Tuple<char, int>>();
            operators.Add(new Tuple<char,int>('^', 3));
            operators.Add(new Tuple<char,int>('*', 2));
            operators.Add(new Tuple<char,int>('/', 2));
            operators.Add(new Tuple<char,int>('%', 2));
            operators.Add(new Tuple<char,int>('+', 1));
            operators.Add(new Tuple<char,int>('-', 1));
        }
        public void Convert(char[] infix)
        {
            Tuple<char, int> cuOperator;
            Tuple<char, int> topStackOperator;
            StackStruct< Tuple<char, int>> Operator = new StackStruct <Tuple<char, int>>(20,0);
            string outPut = string.Empty;
            for(int i=0; i< infix.Length; i++)
            {
                var result= operators.Find(opera => opera.Item1 == infix[i]);
                if (result != null)
                {
                    cuOperator = result;
                    if (Operator.Count() == 0)
                    {
                        Operator.Push(cuOperator);
                    }
                    else
                    {
                        if(cuOperator.Item2>
                    }
                }
                else
                {

                }
            }
        }
        private void CheckPriority(char curentOpera, char OpraInTopStack)
        {
            Tuple<char, int> cuOperator;
            Tuple<char, int> topStackOperator;
            this.operators.ForEach
            (
               item =>
               {
                   if (curentOpera== item.Item1)
                   {
                       cuOperator = new Tuple<char, int>(item.Item1, item.Item2);
                   }
                   else if (OpraInTopStack == item.Item1)
                   {
                       topStackOperator = new Tuple<char, int>(item.Item1, item.Item2);
                   }
               }
            );
        }
    }
}
