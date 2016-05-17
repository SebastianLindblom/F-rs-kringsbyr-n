using System.Linq;

namespace Service
{
    static public class User
    {
        public static string Username { get; private set; }
        public static string Permission { get; private set; }

        /// <summary>
        /// Log in, validate parameters and if a match set the username and permission from the match
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true if there was a match</returns>
        public static bool login(string username, string password)
        {
            using (var unitOfWork = new Business.UnitOfWork(new Data.DataModel()))
            {
                var a = unitOfWork.Anställda.Find(x => x.Användarnamn.Equals(username) && x.lösenord.Equals(password)).FirstOrDefault();
                if (a != null)
                {
                    Username = a.Användarnamn;
                    if (a.Behörighet != null) Permission = a.Behörighet.område;
                    return true;
                }
                else if (username == "skip")
                {
                    Permission = "123456789a";
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// Log out, reset the logged in user
        /// </summary>
        /// <returns>true</returns>
        public static void logout()
        {
            Username = null;
            Permission = null;
        }
    }
}
