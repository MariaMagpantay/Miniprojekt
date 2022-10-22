namespace Model
{
    public class Bruger
    {
        //Konstrukter
        public Bruger (long brugerID, string brugernavn)
        {
            this.BrugerID = brugerID;
            this.BrugerNavn = brugernavn;
        }

        //Felter
        public long BrugerID { get; set; }
        public string BrugerNavn{ get; set; }
    
       //Tom konstrukter
       public Bruger()
        {

        }
      
    }

}
