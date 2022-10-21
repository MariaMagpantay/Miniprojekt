using Data;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service
{
    public class DataService
    {
        private TrådContext db { get; }

        public DataService(TrådContext db)
        {
            this.db = db;
        }

        public void SeedData()
        {
            Tråd tråd = db.Tråde.FirstOrDefault()!;
            Bruger brugersalsa = new Bruger(1, "SalsaMan");
            Bruger bror = new Bruger(2, "Brother");
            Bruger suppemand = new Bruger(3, "HSM Fan no.1");
            Kommentar testKommentar = new Kommentar(1, "test", brugersalsa, 0, new DateTime(2022, 10, 12));
            Kommentar testKommentar2 = new Kommentar(2, "JEG ELSKER SUPPE OG SHARPAY", suppemand, 1, new DateTime(2022, 10, 12));
            Kommentar testKommentar3 = new Kommentar(3, "Jeg tester lige kommentaren", bror, 5, new DateTime(2022, 10, 21));
            Tråd testTråd = new Tråd(1, bror, "test overskrift", 0, new DateTime(2022, 10, 12), "test indhold");
            Tråd testTråd1 = new Tråd(2, brugersalsa, "test test", 0, new DateTime(2022, 10, 21), "test indhold til tråd 2");
            testTråd.KommentarListe.Add(testKommentar);
            testTråd.KommentarListe.Add(testKommentar2);
            testTråd1.KommentarListe.Add(testKommentar3);
            if (tråd == null)
            {
                db.Tråde.Add(testTråd);
                db.Tråde.Add(testTråd1);
            }

            db.SaveChanges();
        }

        private readonly HttpClient httpClient;

        public DataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }



        //GET metoder
        public List<Tråd> GetAlleTråde()
        {
            return db.Tråde.Include(t => t.Bruger).ToList();
        }

        public Tråd GetTråd(int id)
        {
            return db.Tråde.Include(t => t.Bruger).Include(t => t.KommentarListe).ThenInclude(t => t.Bruger).FirstOrDefault(t => t.TrådID == id);
            //var result = await httpClient.GetFromJsonAsync<Tråd>("api/tråd/" + id);
            //return result;
        }

        //////////Er nedenstående metode nødvendig?
        public List<Tråd> GetAlleKommentarer()
        {
            return db.Tråde.Include(t => t.KommentarListe).ThenInclude(t => t.Bruger).ToList();
        }



        //POST metoder
        public string CreateTråd(int brugerID, string overskrift, string indhold)
        {
            Bruger bruger = db.Brugerer.FirstOrDefault(b => b.BrugerID == brugerID);
            db.Tråde.Add(new Tråd { Bruger = bruger, Overskrift = overskrift, Indhold = indhold });
            db.SaveChanges();
            return "Tråd created";
        }

        public string CreateKommentar(int trådID, int brugerID, string tekst)
        {
            Tråd tråd = db.Tråde.FirstOrDefault(t => t.TrådID == trådID);
            Bruger bruger = db.Brugerer.FirstOrDefault(b => b.BrugerID == brugerID);
            tråd.KommentarListe.Add(new Kommentar { Bruger = bruger, Tekst = tekst });
            db.SaveChanges();
            return "Kommentar created";
        }


        //PUT metoder
    }
}
