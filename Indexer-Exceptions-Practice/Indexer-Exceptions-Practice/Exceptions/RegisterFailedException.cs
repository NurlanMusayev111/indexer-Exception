using Indexer_Exceptions_Practice.Helpers.Constants;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions_Practice.Exceptions
{
    internal class RegisterFailedException : Exception
    {
        public RegisterFailedException() :this(AccountMessages.RegisterFailed)
        {
            
        }
        public RegisterFailedException(string msj):base(msj)
        {
            
        }
    }
}
