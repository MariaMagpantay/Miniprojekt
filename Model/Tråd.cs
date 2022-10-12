namespace Model
{
    public class Tråd
    {
        public Tråd (long trådID, string tForfatter, string overskrift, long stemmer, DateTime dato, string indhold, List<Kommentar> kommentarListe)
        {
            this.TrådID = trådID;
            this.TForfatter = tForfatter;
            this.Overskrift = overskrift;
            this.Stemmer = stemmer;
            this.Dato = dato;
            this.Indhold = indhold;
            this.KommentarListe = kommentarListe;
        }

        public long TrådID { get; set; }
        public string TForfatter { get; set; }
        public string Overskrift { get; set; }
        public long Stemmer { get; set; }
        public DateTime Dato { get; set; }
        public string Indhold { get; set; }
        public List<Kommentar> KommentarListe { get; set; } = new List<Kommentar>();

       public Tråd()
        {

        }
      
    }

}
