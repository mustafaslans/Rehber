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
    class KisiRepository : IKisi
    {
        RehberContext db;
        public KisiRepository()
        {
            db = new RehberContext();
        }
        public void Add(Kisi item)
        {
            db.Kisis.Add(item);
            db.SaveChanges();
        }

        public void Delete(Kisi item)
        {
            db.Kisis.Remove(item);
            db.SaveChanges();
        }

        public ICollection<Kisi> GetAll(Expression<Func<Kisi, bool>> paramater = null)
        {
            return paramater == null ?
                 db.Kisis.ToList() :
                 db.Kisis.Where(paramater).ToList();
        }

        public void Update(Kisi item)
        {
            Kisi eskikisi = db.Kisis.Find(item.KisiID);
            eskikisi.KisiID = item.KisiID;
            eskikisi.KisiAdi = item.KisiAdi;
            eskikisi.KisiSoyadi = item.KisiSoyadi;
            eskikisi.KisiYas = item.KisiYas;
            db.SaveChanges();
        }
    }
}
