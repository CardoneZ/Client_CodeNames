using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNamesClientSide.Utilities
{
    internal class Player
    {
        private int idUserAccount;
        private string nickname;
        private string password;
        private string email;
        private bool isGuest;

        #region Singletone

        private static Player playerClient;

        public static Player PlayerClient { get { return playerClient; } set { playerClient = value; } }

        #endregion

        public int IdUserAccount { get { return idUserAccount; } set { idUserAccount = value; } }
        public string Nickname { get { return nickname; } set { nickname = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public bool IsGuest { get { return isGuest; } set { isGuest = value; } }

    }
}
