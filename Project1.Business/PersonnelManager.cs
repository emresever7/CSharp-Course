using Project1.DataAccess;
using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Business
{
    public class PersonnelManager : IPersonnelService
    {
        IPersonnelDal _personnelDal;

        public PersonnelManager(IPersonnelDal personnelDal)
        {
            _personnelDal = personnelDal;
        }

        public List<Personnel> GetAll()
        {
            return _personnelDal.GetAll();
        }
    }
}
