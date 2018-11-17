using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list简易通讯录
{
    class Persons
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
            this.name = name;
            this.relation = relation;
            this.mobileNumber = mobileNumber;
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
            string[] relation1 = {"同学","舍友","朋友","家人","老师","同事","其他", };
            int j = 0;
            foreach(string i in relation1)
            {
                if (i == relation)
                {
                   j=1;
                }
            }
            return j == 1;
        }



    }
}
