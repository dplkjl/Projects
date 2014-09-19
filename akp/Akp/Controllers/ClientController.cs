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
                var currentClients = uow.Clients.Where(w => w.Status == "On the Programme").ToList();
                return currentClients;
            }
        }

        // Get: api/Client
        [HttpGet]
        public IEnumerable<Client> FindbyName(string LastName, string FirstName)
        {
            using (var uow = Context.CreateUnitOfWork())
            {
                var foundClient = uow.Clients.Where(w => w.LastName == LastName && w.FirstNames == FirstName);
                return foundClient;
            }
        }
        // Get: api/Client
        [HttpGet]
        public IEnumerable<Client> FindbyId(int clientId)
        {
            using (var uow = Context.CreateUnitOfWork())
            {
                var foundClient = uow.Clients.Where(w => w.Id == clientId);
                return foundClient;
            }
        }
        // POST: api/Client
        [HttpPost]
        public void AddNewClient(Client newClient)
        {
            using (var uow = Context.CreateUnitOfWork())
            {
                Client _newClient = new Client();
                _newClient = newClient;
                uow.Add(_newClient);
                uow.SaveChanges();

            }
        }
    }
}
