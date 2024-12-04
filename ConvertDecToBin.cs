using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class ConvertDecToBin
    {
        public StackStruct result;
        public ConvertDecToBin(StackStruct result)
        {
            this.result = result;
        }

        public void Convert(int dec)
        {
            int resutl = dec % 2;
            this.result.Push(resutl);
            if (dec / 2 == 0)
            {
                return;
            }
            Convert(dec/2);
        }
        
    }
}
