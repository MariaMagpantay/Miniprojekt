namespace Model
{
    public class Kommentar
    {
        //Konstrukterer
        public Kommentar(long kommentarID, string tekst, Bruger bruger, long upvotes, long downvotes, DateTime dato = new DateTime())
        {
            this.KommentarID = kommentarID;
            this.Tekst = tekst;
            this.Bruger = bruger;
            this.UpVotes = upvotes;
            this.DownVotes = downvotes;
            this.Dato = dato;
        }
        public Kommentar(long kommentarID , string tekst, Bruger bruger, long upvotes, long downvotes)
        {
            this.KommentarID = kommentarID;
            this.Tekst = tekst;
            this.Bruger = bruger;
            this.UpVotes = upvotes;
            this.DownVotes = downvotes;
        }

        //Felter
        public long KommentarID { get; set; }   
        public string Tekst { get; set; }
        public Bruger Bruger { get; set; }
        public long UpVotes { get; set; }
        public long DownVotes { get; set; }
        public DateTime Dato { get; set; } = DateTime.Now; 
       

        //Tom konstrukter
        public Kommentar ()
        {

        }

    }
}
