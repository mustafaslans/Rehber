using Rehber.DAL.Repository;
using Rehber.Entities.Context;
using Rehber.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rehber.DAL.RehberManagement
{
    public class AdresRepository : IAdres
    {
        RehberContext db;
        public AdresRepository()
        {
            db = new RehberContext();
        }
        public void Add(Adres item)
        {
            db.Adres.Add(item);
            db.SaveChanges();
        }

        public void Delete(Adres item)
        {
            db.Adres.Remove(item);
            db.SaveChanges();
        }

        public ICollection<Adres> GetAll(Expression<Func<Adres, bool>> paramater = null)
        {
            return paramater == null ?
                db.Adres.ToList() :
                db.Adres.Where(paramater).ToList();
        }

        public void Update(Adres item)
        {
            Adres eskiadres = db.Adres.Find(item.AdresID);
            eskiadres.AdresID = item.AdresID;
            eskiadres.Il = item.Il;
            eskiadres.Ilce = item.Ilce;
            db.SaveChanges();
        }
    }
}
