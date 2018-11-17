using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 购物车
{
    class commodity
    {
        private string name;
        private double price;
        private int number;

        public commodity()
        {
        }

        public commodity(string name, double price, int number)
        {
            this.name = name;
            this.price = price;
            this.number = number;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price > 0)
                {
                    value = price;
                }
            }
        }

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (number > 0)
                {
                    value = number;
                }
            }
        }

        public string ToSting()
        {
            return "商品名字:" + name + "        商品价格:" + price + "            商品个数：" + number;
        }
    }
    class shoppingcart
    {
        private List<commodity> myshop;

        public shoppingcart()
        {
        }

        public shoppingcart(params commodity[] stu)
        {
            myshop = new List<commodity>(stu);
        }

        public commodity this[int index]
        {
            get
            {
                return myshop[index];
            }
            set
            {
                myshop[index] = value;
            }
        }

        public void Add(commodity m)
        {
            myshop.Add(m);
        }

        public void AddRange(params commodity[] stu)
        {
            myshop.AddRange(stu);
        }

        public  bool IsContains(commodity m)
        {
            return myshop.Contains(m);
        }

        public void show()
        {
            for (int i = 0; i < myshop.Count; i++)
            {
                Console.WriteLine(myshop[i].ToSting());
            }
        }

        public void Remove(commodity m)
        {
            myshop.Remove(m);
        }

        public void RemoveAt(int m)
        {
            myshop.RemoveAt(m);
        }

        public void RemoveAt(int m,int n)
        {
            myshop.RemoveRange(m,n);
        }

        public void Show()
        {
            foreach(commodity m in myshop)
            {
                m.ToSting();
            }
        }

        public void Contains(commodity m)
        {
            if (myshop.Contains(m))
            {
                Console.WriteLine("存在列表中");
            }
            else
            {
                m.ToSting();
            }
               
        }

        public int GetLength()
        {
            //Console.WriteLine(myshop.Count);
            return myshop.Count;
        }

        public bool Contains(string  m)
        {
            commodity stu = new commodity();
            if (stu.Name.Contains(m))
            {
                //Console.WriteLine("存在列表中");
                return true;
            }
            else
            {
                stu.ToSting();
                return false;
            }

        }


    }
}
