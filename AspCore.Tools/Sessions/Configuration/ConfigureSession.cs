using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCore.Tools.Sessions.Configuration
{
    public static  class ConfigureSession
    {
     
        /// <summary>
        /// PErmet de configure la session avec un cookie
        /// </summary>
        /// <param name="services">La collection <see cref="IServiceCollection"/> envoyée par le startup.cs</param>
        /// <param name="CookieName">LE nom du cookie pour votre application</param>
        /// <param name="SessionTimeOut">LA durée en minute de la session</param>
        /// <example>
        ///  public void ConfigureServices(IServiceCollection services)
        ///{
        ///    services.AddControllersWithViews();
        ///    ConfigureSession.Configure(services, "Adopt1DevCookie", 25);
        ///}
        /// </example>
        /// <remarks>
        /// NE pas oublier UseSession(); dans la section Configure de votre startup
        /// </remarks>
    public static void Configure(IServiceCollection services, string CookieName, int SessionTimeOut)
        {
            services.AddDistributedMemoryCache(); //Fortement recommandé 
            //Permet de s'assurer d'une implémentation de mise en cache mémoire 
            //sur l'hébergement !!!! Ne fonctione qu'en single server !!!
            //Sessions
            services.AddSession(
                options =>
                {
                    options.IdleTimeout = TimeSpan.FromMinutes(SessionTimeOut); //Durée de vie
                    options.Cookie.Name = CookieName;
                    options.Cookie.HttpOnly = true;//Important!!Empêche les script client de
                                                   //lire/ecrire dans le cookie
                }

                );
            //Injection IHttpContextAccessor pour permettre l'utilisation des sessions dans les classes non mvc
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        
    }
}
