using ScaffoldDbLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScaffoldDbLib
{
    class Class1
    {
        public Class1(ScaffoldDbContext context)
        {
            context.Users.FromSqlRaw(@"CREATE PROCEDURE TestSp 
          AS
            BEGIN

         Select * from dbo.[User];
            END
            GO");
            context.Users.FromSqlRaw("EXEC TestSp");

            var data = context.Users.Include(p => p.Grade).FirstOrDefault();
            var dd = data.Grade.GradeName;
        }
    }
}
