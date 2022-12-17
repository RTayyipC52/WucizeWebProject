using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TrCategoryManager : ITrCategoryService
    {
        ITrCategoryDal _trCategoryDal;
        public TrCategoryManager(ITrCategoryDal trCategoryDal)
        {
            _trCategoryDal = trCategoryDal;
        }

        public void Add(TrCategory t)
        {
            _trCategoryDal.Add(t);
        }

        public void Delete(TrCategory t)
        {
            _trCategoryDal.Delete(t);
        }

        public List<TrCategory> GetAll()
        {
            return _trCategoryDal.GetAll();
        }

        public TrCategory GetById(int id)
        {
            return _trCategoryDal.GetById(id);
        }

        public void Update(TrCategory t)
        {
            _trCategoryDal.Update(t);
        }
    }
}
