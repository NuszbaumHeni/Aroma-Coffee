using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aroma_Coffee
{
    public class Model
    {
        private Persistence mydb;
        public Model(Persistence persistence)
        {
            mydb = persistence;

        }
            public bool regist(string name, string pass)
        {
            bool success = false;
            if (mydb.user.Where(x => x.Name == name).Any())
            {
                return success;
            }
            else
            {
                using var asd = mydb.Database.BeginTransaction();
                mydb.user.Add(new user { Name = name, Pass = pass });
                asd.Commit();
                mydb.SaveChanges();
                return true;
            }
        }
        public bool login(string name, string pass)
        {
            return mydb.user.Where(x => x.Name == name && x.Pass == pass).Any();
        }

        public (int,int,int) ChangeMaterial(string coffe)
        {
            switch(coffe)
            {
                case "Szimpla":
                    return (1, 1, 0);
                case "Hosszú":
                    return (2,2, 0);
                case "Cappucino":
                    return (1, 1, 2);
                case "Frappé":
                    return (1, 2, 2);
                default:
                    return (0, 0, 0);       
            }
        }
        public void coffeorder(string user,string name, int water, int cofe,int choco,int sugar,int milk)
        {
                using var asd = mydb.Database.BeginTransaction();
                mydb.kavek.Add(new kave { user = user, name = name, water = water, cofe = cofe, choco = choco, sugar = sugar, milk = milk });
                asd.Commit();
                mydb.SaveChanges();

        }
    }
}

