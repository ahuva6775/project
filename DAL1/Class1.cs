using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL1
{
    public class Class1
    {
        public static List<information> getAll()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.information.ToList();
            }
        }
        public static List<information> AddInformation()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.information.ToList();

            }
        }
        public static List<information> DeleteInformation()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.information.ToList();

            }
        }

 public static List<information> UpdateInformation()
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                return db.information.ToList();

            }
        }
        public static Person getByNameAndPwd(string name, string pwd)
        {
            using (ProjectEntities db = new ProjectEntities())
            {
                //for (int i = 0; i < db.information.Count(); i++)
                //{
                //    if (db.Person.ToList()[i].Name == name && db.Person.ToList()[i].Pwd == pwd)
                //        return db.Person.ToList()[i];
                //    else
                //        return 0;
                //}
                //return db.Person.ToList();
                Person p = db.Person.FirstOrDefault(x => x.Name == name && x.Pwd == pwd);
                return p;
            }
        }
    }
}
