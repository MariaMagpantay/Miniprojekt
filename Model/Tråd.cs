namespace Model
{
    public class Tråd
    {
        public Tråd (long trådID, Bruger bruger, string overskrift, long stemmer, DateTime dato, string indhold, List<Kommentar> kommentarListe)
        {
            this.TrådID = trådID;
            this.Bruger = bruger;
            this.Overskrift = overskrift;
            this.Stemmer = stemmer;
            this.Dato = dato;
            this.Indhold = indhold;
            this.KommentarListe = kommentarListe;
        }
        public Tråd(long trådID, Bruger bruger, string overskrift, long stemmer, DateTime dato, string indhold)
        {
            this.TrådID = trådID;
            this.Bruger = bruger;
            this.Overskrift = overskrift;
            this.Stemmer = stemmer;
            this.Dato = dato;
            this.Indhold = indhold;
        }


        public long TrådID { get; set; }
        public Bruger Bruger { get; set; }
        public string Overskrift { get; set; }
        public long Stemmer { get; set; }
        public DateTime? Dato { get; set; }
        public string Indhold { get; set; }
        public List<Kommentar> KommentarListe { get; set; } = new List<Kommentar>();

       public Tråd()
        {

        }
      
    }

}
