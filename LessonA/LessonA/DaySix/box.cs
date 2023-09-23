using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySix
{
    class Box
    {
        List<int> noList = new List<int>();
        public void FillList(int from, int to)
        {
            int i = 0;
            for (i = from; i < to; i++)
            {
                noList.Add(i);
            }
        }
        public List<int> GetList()
        {
            return noList;
        }
    }
}
