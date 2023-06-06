
namespace ChallengeApp
{
    internal class User
    {

        private List<int> score = new List<int>();
        // konstruktory
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;

        }
        // pola w klasach 
        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get { return this.score.Sum(); }
        }

        // Metody 
        public void AddScore(int addscore)
        {
            this.score.Add(addscore);
        }
    }
}
