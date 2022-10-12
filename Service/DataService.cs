using Model;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Service
{
    public class DataService
    {
        private TrådContext db { get; }

        public DataService (TrådContext db)
        {
            this.db = db;
        }

        public void SeedData()
        {
            Tråd tråd = db.Tråde.FirstOrDefault()!;
            Kommentar testKommentar = new Kommentar(1,1,"test", "Mikkel", 0, new DateTime(2022, 10, 12));
            Tråd testTråd = new Tråd(1, "Hans", "test overskrift", 0, new DateTime(2022, 10, 12), "test indhold");
            testTråd.KommentarListe.Add(testKommentar);
            if (tråd == null)
            {
                db.Tråde.Add(testTråd);
            }

            db.SaveChanges();
        }

        public List<Tråd> GetTråde()
        {
            return db.Tråde.Include(t => t.KommentarListe).ToList();
        }

        
    }
}
