using Indexer_Exceptions_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions_Practice.Services.Interfaces
{
    internal interface IPersonService
    {
        Person GetById(int? id);
    }
}
