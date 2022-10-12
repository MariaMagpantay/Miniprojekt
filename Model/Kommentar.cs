namespace Model
{
    public class Kommentar
    {
        public Kommentar(long kommentarID, long trådID, string tekst, string kForfatter, long stemmer, DateTime dato = new DateTime())
        {
            this.KommentarID = kommentarID;
            this.TrådID = trådID;
            this.Tekst = tekst;
            this.KForfatter = kForfatter;
            this.Stemmer = stemmer;
            this.Dato = dato;
        }

        

        public long KommentarID { get; set; }   
        public long TrådID { get; set; }    
        public string Tekst { get; set; }
        public string KForfatter { get; set; }
        public long Stemmer { get; set; }
        public DateTime Dato { get; set; }

        public Kommentar ()
        {

        }

    }
}
