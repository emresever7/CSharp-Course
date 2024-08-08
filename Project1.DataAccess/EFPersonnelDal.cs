using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.DataAccess
{
    public class EFPersonnelDal : IPersonnelDal
    {
        public void Add(Personnel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Personnel entity)
        {
            throw new NotImplementedException();
        }

        public List<Personnel> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Personnels.ToList();

            }
        }

        public Personnel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Personnel entity)
        {
            throw new NotImplementedException();
        }
    }
}
