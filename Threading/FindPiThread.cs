using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    internal class FindPiThread
    {
        int dartNum = 0;
        int dartboardCount;
        public int dartBoard
        {
            get { return dartboardCount; }
            set { dartboardCount = value; }
        }
        Random dartThrow;
        
        public FindPiThread(int dartNum)
        {
            this.dartNum = dartNum;
            dartboardCount = 0;
            dartThrow = new Random();
        }

        public void throwDarts()
        {
            for(int i = 0; i <= dartNum; i++)
            {
                var x = dartThrow.NextDouble();
                var y = dartThrow.NextDouble(); 
                
                if(Math.Sqrt((x * x) + (y * y)) < 1)
                {
                    dartboardCount++;
                }
            }
        }
    }
}
