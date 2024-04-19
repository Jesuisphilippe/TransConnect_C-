namespace TransConnect
{
    internal class Client : Personne
    {
        public Client(int noSS, string nom, string prénom, DateTime dateNaissance, string adresse, string email, string telephone)
            : base(noSS, nom, prénom, dateNaissance, adresse, email, telephone)
        {
        }
    }
}
