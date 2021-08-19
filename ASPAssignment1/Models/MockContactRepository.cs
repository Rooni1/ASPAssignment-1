using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment1.Models
{
    public class MockContactRepository: IContactRepository
    {
        public IEnumerable<Contact> ContactInfo =>
            new List<Contact>
            {
                new Contact{ FirstName = "Haroon", LastName =  "Munir",
                             Email= "haroon_munir@hotmail.com",MobilNumber = 0760445327}
            };

        
        
    }
}
