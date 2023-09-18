using BMO.Api.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace BMO.Api.Authentication
{
    internal class BasicAuthenticationHandler : AuthenticationHandler<BasicAuthenticationOption>
    {
        private readonly IUnitOfWork _unitOfWork;

        public BasicAuthenticationHandler(IOptionsMonitor<BasicAuthenticationOption> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IUnitOfWork unitOfWork) : base(options, logger, encoder, clock)
        {
            _unitOfWork = unitOfWork;
        }

        protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out var _))
            {
                return await Task.FromResult(AuthenticateResult.NoResult());
            }

            var claims = Array.Empty<Claim>;
            var isGuid = Guid.TryParse(Request.Headers["Authorization"].ToString(), out var authenticationKey);

            //Checks if the device is a registered bmo-device with a working serial
            if (isGuid && _unitOfWork.Devices.Where(x => x.Id == authenticationKey).Count() > 0)
            {
                return await CreateAuthenticationIdentity(new List<Claim> { new Claim(ClaimTypes.Role, "User") });

            }
            else if (Request.Headers["Authorization"].ToString() == "super-secret-admin-key")
            {
                return await CreateAuthenticationIdentity(new List<Claim> { new Claim(ClaimTypes.Role, "Administrator")});
            }

            return await Task.FromResult(AuthenticateResult.NoResult());
        }

        protected async Task<AuthenticateResult> CreateAuthenticationIdentity(List<Claim> claims)
        {
            var identity = new ClaimsIdentity(claims, Scheme.Name);

            var principal = new ClaimsPrincipal(identity);

            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return await Task.FromResult(AuthenticateResult.Success(ticket));
        }
    }
}
