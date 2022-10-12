using Model;
using Data;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;
using System.Text.Json;

namespace Service
{
    public class DataService
    {
        private readonly HttpClient http;
        private TrådContext db { get; }

        public DataService (TrådContext db)
        {
            this.db = db;
        }

        public void SeedData()
        {
            Tråd tråd = db.Tråde.FirstOrDefault()!;
            Bruger brugersalsa = new Bruger(1, "SalsaMan");
            Bruger bror = new Bruger(2, "Brother");
            Bruger suppemand = new Bruger(3, "HSM Fan no.1");
            Kommentar testKommentar = new Kommentar(1,1,"test", brugersalsa, 0, new DateTime(2022, 10, 12));
            Kommentar testKommentar2 = new Kommentar(2, 1, "JEG ELSKER SUPPE OG SHARPAY", suppemand, 1, new DateTime(2022, 10, 12));
            Tråd testTråd = new Tråd(1, bror, "test overskrift", 0, new DateTime(2022, 10, 12), "test indhold");
            testTråd.KommentarListe.Add(testKommentar);
            testTråd.KommentarListe.Add(testKommentar2);
            if (tråd == null)
            {
                db.Tråde.Add(testTråd);
            }

            db.SaveChanges();
        }

        private readonly HttpClient httpClient;

        public DataService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public List<Tråd> GetTråde()
        {
            return db.Tråde.Include(t => t.KommentarListe).ToList();
        }
        public async Task<Tråd> GetTråd(int id)
        {
            var result = await httpClient.GetFromJsonAsync<Tråd>("api/tråd/" + id);
            return result;
        }



    }
}
