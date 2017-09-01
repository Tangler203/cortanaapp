using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cortanaApp
{
    class Model
    {
        private int targetnum = -1;

        private string guessnum = "";

        public int getTargetNum()
        {
            return targetnum;
        }

        public void setTargetNum(int i)
        {
            targetnum = i;
        }

       public string getGuessNum()
        {
            return guessnum;
        }

        public void setGuessNum(string s)
        {
            guessnum = s;
        }
    }
}
