using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class ConvertToPostFixExpr
    {
        public char[] postFix;
        public List<Tuple<char, int>> operators;
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
        public string Convert(char[] infix)
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
                        if(cuOperator.Item2> Operator.Peek().Item2)
                        {
                            Operator.Push(cuOperator);
                        }
                        else
                        {
                            for (int j= Operator.Count()-1; j >= 0; j--)
                            {
                                if(Operator.stack[j]!= null 
                                    && 
                                    Operator.stack[j]== Operator.Peek())
                                {
                                    if (cuOperator.Item2 > Operator.stack[j].Item2)
                                    {
                                        break;
                                    }
                                    outPut += Operator.Pop().Item1;
                                }
                            }
                        }
                    }
                }
                else
                {
                    outPut += infix[i];
                    if (i== infix.Length)
                    {
                        outPut += Operator.Pop();
                    }
                }
            }
            return outPut;
        }
    }
}
