using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrigorevKU.Sprint2.TaskReview.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool a = (x*x + y*y >= 0);
            bool b = (y >= x);
            bool c = (x <= 0);
            if (a && b || c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
