using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment1.Models
{
    public interface IContactRepository
    {
        public IEnumerable<Contact> ContactInfo { get; }
    }
}
