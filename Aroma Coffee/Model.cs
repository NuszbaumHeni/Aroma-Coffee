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
    }
}

