using Indexer_Exceptions_Practice.Data;
using Indexer_Exceptions_Practice.Models;
using Indexer_Exceptions_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions_Practice.Services
{
    internal class PersonService : IPersonService
    {
        private readonly AppDbContext _context;

        public PersonService()
        {
            _context = new AppDbContext();
        }

        public Person GetById(int? id)
        {
            if(id is null) throw new ArgumentNullException();

            Person existPerson = _context.People().FirstOrDefault(m =>  m.Id == id);

            if(existPerson is null) throw new NullReferenceException("Data Not Found");

            return existPerson;
        }
    }
}
