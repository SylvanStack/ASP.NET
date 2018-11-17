using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代码检查
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons i = new Persons("a", "12", "同学");
            Addperson myperson = new Addperson(i);
            myperson.Add(new Persons("aa","123","朋友"));
            myperson.Add(new Persons("aaa","1234","家人"));
            myperson.Add(new Persons("aaaa","12345","其他"));
            myperson.RemoveAt(1);    
            myperson.Show();
            Console.WriteLine(myperson.FindName("a"));
            Console.WriteLine(myperson.FindAllMobileNumber("123"));
            myperson.Exists("aa");
            myperson[2].Name = "aaaaaa";
            myperson.Show();
        }
    }
     public class Persons
    {
        private string name;
        private string mobileNumber;
        private string relation;

        public Persons()
        {
        }

        public Persons(string name)
            : this(name, "<no mobileNumber>", "<no relation>")
        {
        }

        public Persons(string name, string mobileNumber, string relation)
        {
            Name = name;
            Relation = relation;
            MobileNumber = mobileNumber;
        }

        public string Name
        {
            get { return name; }
            set { name = value.Trim(); }
        }

        public string MobileNumber
        {
            get { return mobileNumber; }
            set { mobileNumber = value.Trim(); }
        }

        public string Relation
        {
            get { return relation; }
            set
            {
                if (CheckRelation(value.Trim()))
                {
                    relation = value.Trim();
                }
            }
        }

        public bool CheckRelation(string relation)
        {
            string[] relation1 = { "同学", "舍友", "朋友", "家人", "老师", "同事", "其他", };
            int j = 0;
            foreach (string i in relation1)
            {
                if (i == relation)
                {
                    j = 1;
                }
            }
            return j == 1;
        }
        public override string  ToString()
        {
            return "姓名:"+name+"手机号:"+mobileNumber+"关系:"+relation;
        }
     }
     public class Addperson
     {
         private List<Persons> myperson;

         internal List<Persons> Myperson
         {
             get { return new List<Persons>(myperson); }
             set { myperson = new List<Persons>(value); }
         }

         public Addperson(params Persons[] stu)
         {
             myperson = new List<Persons>(stu);
         }

         public Addperson(Addperson other)
         {
             myperson = new List<Persons>();
         }

         public Persons this[int index]
         {
             get
             {
                 return myperson[index];
             }
             set
             {
                 myperson[index] = value;
             }
         }

         public void Add(Persons stu)
         {
             if (!Contains(stu))
             {
                 myperson.Add(stu);
             }
         }

         public void AddRange(params Persons[] stu)
         {
             myperson.AddRange(stu);
         }

         public void Remove(Persons stu)
         {
             myperson.Remove(stu);
         }

         public void RemoveAt(int i)
         {
             myperson.RemoveAt(i);
         }

         public void RemoveRange(int i, int j)
         {
             myperson.RemoveRange(i, j);
         }

         public void Show()
         {
             for (int i = 0; i < myperson.Count; i++)
             {
                 Console.WriteLine(myperson[i].ToString());
             }
         }

         public int GetSum()
         {
             return myperson.Count;
         }

         public bool IsMobileNumber(Persons p,string a)
         {
             return p.MobileNumber.Substring(0, a.Length) == a;
         }

         public string FindAllMobileNumber(string a)
         {
             //return myperson.FindAll((Persons s) => s.MobileNumber.Substring(0,a.Length) == a).Count.ToString();
             return myperson.FindAll(delegate(Persons s) { return s.MobileNumber.Substring(0, a.Length) == a; }).Count.ToString();
         }

         public void FindList(string a)
         {
             myperson.FindLast((Persons s) => s.Name == a ? true : false).ToString();
         }

         public void   Exists(string a)
         {
             if (myperson.Exists((Persons s) => s.Name == a ? true : false).ToString() == "true")
             {
                 Console.WriteLine("存在");
             }
             else
             {
                 Console.WriteLine("不存在");
             }
             
         }

         public bool MobileNumberContains(string m)
         {
             for (int i = 0; i < myperson.Count; i++)
             {
                 if (m.Equals(myperson[i].MobileNumber))
                 {
                     return true;
                 }
             }
             return false;
         }

         public bool Contains(Persons m)
         {
             for (int i = 0; i < myperson.Count; i++)
             {
                 if (m.Name.Equals(myperson[i].Name))
                 {
                     return true;
                 }
             }
             return false;
         }

         public string FindName(string a)
         {
             return myperson.Find(delegate(Persons s) { return s.Name == a; }).ToString();

         }

         public bool CheckStuNum(string StuNum)
         {
             for (int i = 0; i < myperson.Count; i++)
             {
                 if (StuNum.Equals(myperson[i].Name))
                 {
                     return false;
                 }
             }
             return true;
         }

     }
}
