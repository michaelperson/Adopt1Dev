using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCore.Tools.Sessions
{
    /// <summary>
    /// Classe de base permettant la mise n place d'un classe gérant les sessions de manière centralisée dans l'ASP
    /// </summary>
    /// <remarks>
    /// Vous devez ajouter les lignes suivantes dans votre startup :
    ///   - Dans ConfigureService
    ///             services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // /Injection IHttpContextAccessor pour permettre l'utilisation des sessions dans les classes non mvc
    ///   - Dans Configure 
    ///        //Permet à notre classe de gestion de session de résoudre les services
    ///        [VotreClasseFille].Services = app.ApplicationServices;
    /// </remarks>
    public abstract class BaseSessionUtils
    {
        static IServiceProvider services = null;

        /// <summary>
        /// Fournit un accès statique au service provider du framework
        /// </summary> 
        public static IServiceProvider Services
        {
            private get { return services; }
            set
            {
                if (services != null)
                {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        /// <summary>
        /// Fournit un accès à l'httpContaxt courrant
        /// </summary>
        protected static HttpContext Current
        {
            get
            {
                IHttpContextAccessor httpContextAccessor = services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
                return httpContextAccessor?.HttpContext;
            }
        }
    }
}
