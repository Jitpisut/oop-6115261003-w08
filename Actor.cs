using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w08
{
    class Actor
    {
        private string fristName;
        private string lastName;
        private string nickName;
        private string age;

        public string FristName
        {
            get { return fristName; }
            set { fristName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public Actor(string fn,string ln,string nn,string a)
        {
            this.FristName = fn;
            this.LastName = ln;
            this.NickName = nn;
            this.Age = a;
        }
        public override string ToString()
        {
            return this.NickName +
                this.FristName +
                this.LastName;
        }
    }
}
