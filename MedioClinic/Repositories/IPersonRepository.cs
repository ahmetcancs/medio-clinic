using CMS.DocumentEngine.Types.MC;
using System.Collections.Generic;

namespace MedioClinic.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Persons> GetPersons(string nodeAliasPath);
    }
}
