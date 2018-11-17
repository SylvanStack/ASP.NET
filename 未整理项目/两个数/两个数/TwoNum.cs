using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两个数
{
    class TwoNum
    {
        private int num1;
    private int num2;

    public TwoNum(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int Add()
    {
        return num1 + num2;
    }

    public int Sub()
    {
        return num1 - num2;
    }

    public int Mul()
    {
        return num1 * num2;
    }

    public int Div()
    {
        return num1 / num2;
    }

    }
}
