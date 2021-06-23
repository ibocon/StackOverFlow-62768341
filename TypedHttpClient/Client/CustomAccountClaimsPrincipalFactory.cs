using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TypedHttpClient.Client
{
    public class CustomAccountClaimsPrincipalFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>
    {
        private readonly WeatherForecastClient _httpClient;
        public CustomAccountClaimsPrincipalFactory(IAccessTokenProviderAccessor accessor, WeatherForecastClient httpClient) : base(accessor)
        {
            _httpClient = httpClient;
        }

        public async override ValueTask<ClaimsPrincipal> CreateUserAsync(
            RemoteUserAccount account,
            RemoteAuthenticationUserOptions options)
        {
            var initialUser = await base.CreateUserAsync(account, options);

            // ...

            return initialUser;
        }
    }
}
