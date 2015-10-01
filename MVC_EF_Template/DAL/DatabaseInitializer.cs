using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_EF_Template.Models;

namespace MVC_EF_Template.DAL
{
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",BirthDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",BirthDate=DateTime.Parse("2002-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}