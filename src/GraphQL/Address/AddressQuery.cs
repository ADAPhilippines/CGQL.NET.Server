using System.Threading;
using System.Threading.Tasks;
using CGQL.NET.Models;
using CGQL.NET.Server.GraphQL.DataLoaders;
using HotChocolate.Types;

namespace CGQL.NET.Server.GraphQL
{
    [ExtendObjectType(Name = "Query")]
    public class AddressQuery
    {
        public Task<Address> GetAddressAsync(
            string hash,
            AddressByHashDataLoader dataLoader,
            CancellationToken cancellationToken) => dataLoader.LoadAsync(hash, cancellationToken);
    }
}