using BMO.Api.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Encodings.Web;

namespace BMO.Api
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
            if(!AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out var _))
            {
                return await Task.FromResult(AuthenticateResult.NoResult());
            }

            if (_unitOfWork.Devices.Where(x => x.SerialNumber == Request.Headers["Authorization"].ToString()).Count() > 0)
            {
                var claims = new[] {
                    new Claim(ClaimTypes.Name, "StandardUser"),
                    new Claim(ClaimTypes.Role, "Administrator")
                };

                var identity = new ClaimsIdentity(claims, Scheme.Name);

                var principal = new ClaimsPrincipal(identity);

                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return await Task.FromResult(AuthenticateResult.Success(ticket));
            }

            return await Task.FromResult(AuthenticateResult.NoResult());
        }
    }
}
