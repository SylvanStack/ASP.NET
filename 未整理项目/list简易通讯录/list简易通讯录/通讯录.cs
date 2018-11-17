using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list简易通讯录
{
    class Addperson
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
            myperson.Add(stu);
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

        
    }
}
