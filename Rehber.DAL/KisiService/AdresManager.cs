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
    public class AdresManager
    {
        //CRUD
        //Create/update felan mesajlar burdan gönderilecek
        AdresRepository ar;
        public AdresManager()
        {
            ar = new AdresRepository();
        }
        public string AddAdres(Adres item)
        {
            try
            {
                ar.Add(item);
                return "Ekleme işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UpdateAdres(Adres item)
        {
            try
            {
                ar.Update(item);
                return "Update işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DeleteAdres(Adres item)
        {
            try
            {
                ar.Delete(item);
                return "Delete işlemi başarılı";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ICollection<Adres> GetAllAdres(Expression<Func<Adres,bool>> parameter = null)
        {
            return ar.GetAll(parameter);
        }
    }
}
