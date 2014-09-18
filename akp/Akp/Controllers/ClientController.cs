using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Http;
using Mindscape.LightSpeed;
using Akp.Models;
using Mindscape.LightSpeed.Logging;


namespace Akp.Controllers
{
    public class ClientController : ApiController
    {

        private readonly Lazy<LightSpeedContext<LightSpeedModelUnitOfWork>> _lazyContext = new Lazy<LightSpeedContext<LightSpeedModelUnitOfWork>>(
            () => new LightSpeedContext<LightSpeedModelUnitOfWork>
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString,
                IdentityMethod = IdentityMethod.IdentityColumn,
                AutoTimestampMode = AutoTimestampMode.Utc,
                QuoteIdentifiers = true,
                Logger = new TraceLogger()
            });

        public LightSpeedContext<LightSpeedModelUnitOfWork> Context
        {
            get { return _lazyContext.Value; }
        }


        // GET: api/Client
        public IEnumerable<Client> Get()
        {
            using (var uow = Context.CreateUnitOfWork())
            {
              var allClients = uow.Clients.ToList();
                return allClients;
            }
        }



    }
}
