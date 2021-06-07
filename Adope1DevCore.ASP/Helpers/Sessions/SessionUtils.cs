using AspCore.Tools.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adopte1DevCore.ASP.Helpers.Sessions
{
    /// <summary>
    /// Classe permettant de gérer de manière centralisée les variables de sessions
    /// </summary>
    public class SessionUtils : BaseSessionUtils
    {
        /// <summary>
        /// Session d'exemple pour l'utilisation de SessionUtils
        /// </summary>
        public static string AppVersion
        {
            get
            {

                if (Current.Session == null) return "";                
                return Current.Session.Get<string>("AppVersion");
            }
            set { Current.Session.Set<string>("AppVersion", value); }
        }
    }
}
