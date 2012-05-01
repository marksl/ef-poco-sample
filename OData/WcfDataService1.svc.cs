using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.Services;
using System.Data.Services.Common;
using Model;

namespace OData
{
    public class WcfDataService1 : DataService<ObjectContext>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("Contacts", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("ContactGroups", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("Users", EntitySetRights.AllRead);

            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
            config.UseVerboseErrors = true;
        }

        protected override ObjectContext CreateDataSource()
        {
            var ctx = new servicestackEntities();
            var objectContext = ((IObjectContextAdapter)ctx).ObjectContext;
            objectContext.ContextOptions.ProxyCreationEnabled = false;
            return objectContext;
        }

    }
}
