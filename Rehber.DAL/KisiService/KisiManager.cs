using Rehber.DAL.RehberManagement;
using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DAL.KisiService
{
    public class KisiManager
    {
        KisiRepository kr;
        public KisiManager()
        {
            kr = new KisiRepository();
        }
        public string AddKisi(Kisi item)
        {
            try
            {
                kr.Add(item);
                return "Ekleme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateKisi(Kisi item)
        {
            try
            {
                kr.Update(item);
                return "Update işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteKisi(Kisi item)
        {
            try
            {
                kr.Delete(item);
                return "Delete işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ICollection<Kisi> GetAllKisi(Expression<Func<Kisi, bool>> parameter = null)
        {
            return kr.GetAll(parameter);
        }
    }
}
