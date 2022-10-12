namespace Model
{
    public class Bruger
    {
        public Bruger (long brugerID, string brugernavn)
        {
            this.BrugerID = brugerID;
            this.BrugerNavn = brugernavn;
        }

        public long BrugerID { get; set; }
        public string BrugerNavn{ get; set; }
    
       public Bruger()
        {

        }
      
    }

}
