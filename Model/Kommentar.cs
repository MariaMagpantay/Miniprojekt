namespace Model
{
    public class Kommentar
    {
        public Kommentar(long kommentarID, long trådID, string tekst, Bruger bruger, long stemmer, DateTime dato = new DateTime())
        {
            this.KommentarID = kommentarID;
            this.TrådID = trådID;
            this.Tekst = tekst;
            this.Bruger = bruger;
            this.Stemmer = stemmer;
            this.Dato = dato;
        }
        public Kommentar(long kommentarID, long trådID, string tekst, Bruger bruger, long stemmer)
        {
            this.KommentarID = kommentarID;
            this.TrådID = trådID;
            this.Tekst = tekst;
            this.Bruger = bruger;
            this.Stemmer = stemmer;
        }



        public long KommentarID { get; set; }   
        public long TrådID { get; set; }    
        public string Tekst { get; set; }
        public Bruger Bruger { get; set; }
        public long Stemmer { get; set; }
        public DateTime Dato { get; set; }

        public Kommentar ()
        {

        }

    }
}
