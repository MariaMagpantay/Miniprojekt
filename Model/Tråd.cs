namespace Model
{
    public class Tråd
    {
        //Konstrukterer 
        public Tråd (long trådID, Bruger bruger, string overskrift, long upvotes, long downvotes, DateTime dato, string indhold, List<Kommentar> kommentarListe)
        {
            this.TrådID = trådID;
            this.Bruger = bruger;
            this.Overskrift = overskrift;
            this.UpVotes = upvotes;
            this.DownVotes = downvotes;
            this.Dato = dato;
            this.Indhold = indhold;
            this.KommentarListe = kommentarListe;
        }
        public Tråd(long trådID, Bruger bruger, string overskrift, long upvotes, long downvotes, DateTime dato, string indhold)
        {
            this.TrådID = trådID;
            this.Bruger = bruger;
            this.Overskrift = overskrift;
            this.UpVotes = upvotes;
            this.DownVotes = downvotes;
            this.Dato = dato;
            this.Indhold = indhold;
        }

        //Felter
        public long TrådID { get; set; }
        public Bruger Bruger { get; set; }
        public string Overskrift { get; set; }
        public long UpVotes { get; set; }
        public long DownVotes { get; set; }
        public DateTime Dato { get; set; } = DateTime.Now;
        public string Indhold { get; set; }
        public List<Kommentar> KommentarListe { get; set; } = new List<Kommentar>();
        
        //Tom kontruktor
        public Tråd()
        {

        }
      
    }

}
