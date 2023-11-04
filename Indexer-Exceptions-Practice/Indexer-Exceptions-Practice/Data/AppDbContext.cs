using Indexer_Exceptions_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions_Practice.Data
{
    internal class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person
                {
                    Id = 1,
                    FullName = "Nurlan Musayev",
                    Age = 21
                },


                new Person
                {
                    Id = 2,
                    FullName = "Narmin Narimanli",
                    Age = 18
                },

                new Person
                {
                    Id = 3,
                    FullName = "Eda Musayeva",
                    Age = 2
                }
            };
        }
    }
}
