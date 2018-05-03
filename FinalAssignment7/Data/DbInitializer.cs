using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalAssignment7.Models;

namespace FinalAssignment7.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NotesContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
            new User{Email="Bpitt@gmail.com",Name="Brad Pitt",CreatedOn=DateTime.Parse("2015-01-15")},
            new User{Email="RDJ@ironman.com",Name="Robert Downey Jr",CreatedOn=DateTime.Parse("2018-03-25")},
            new User{Email="AnthonyP@yahoo.com",Name="Anthony Perkins",CreatedOn=DateTime.Parse("2017-08-07")}
            
            };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var categories = new Category[]
            {
            new Category{Name="CSC 435"},
            new Category{Name="Network Security"},
            new Category{Name="Criminal Justice"}
            
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var notes = new Note[]
            {
                new Note{Title="Note 1",Notes="Git - Create Account, Set up SSH key, Create / Clone Repository.",CreatedOn=DateTime.Parse("2018-02-13"),CategoryId=1,UserId=1,IsDeleted=false },
                new Note{Title="Note 2",Notes="Git - fetch, pull, branch, checkout.",CreatedOn=DateTime.Parse("2018-03-27"),CategoryId=2,UserId=2,IsDeleted=false },
                new Note{Title="Note 3",Notes="Visual Studio - Create web application create Service, Domain, Repository, Core Services.",CreatedOn=DateTime.Parse("2018-2-11"),CategoryId=3,UserId=3,IsDeleted=false }
                
            };
            foreach (Note n in notes)
            {
                context.Notes.Add(n);
            }
            context.SaveChanges();
        }
    }
}
