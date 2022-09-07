using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Repo
{
    public class TestRepo
    {
        public string Reverse(string data)
        {
            return new string(data.Reverse().ToArray());
        }
        public string ReverseOrSqrt(string data)
        {
            if (double.TryParse(data, out double value))
            {
                return Math.Sqrt(value).ToString();
            }
            else
            {
                return Reverse(data);
            }
        }
    }
}
