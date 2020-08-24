using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w08
{
    class Movies
    {
        private string name;
        private string type;
        private string director;
        private Actor actorMovies;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        public Actor ActorMovise
        {
            get { return actorMovies; }
            set { actorMovies = value; }
        }
        public Movies (string n,string t,string d,Actor am)
        {
            this.Name = n;
            this.Type = t;
            this.Director = d;
            this.ActorMovise = am;
        }
        public override string ToString()
        {
            return this.Name + " " + "Represented by" + " " +
                this.ActorMovise.NickName + " " +
                this.ActorMovise.FristName + " " +
                this.ActorMovise.LastName;
        }
    }
}
