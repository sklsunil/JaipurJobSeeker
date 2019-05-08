using Web.Api.Core.Dto.UseCaseResponses;
using Web.Api.Core.Interfaces;

namespace Web.Api.Core.Dto.UseCaseRequests
{
    public class LoginRequest : IUseCaseRequest<LoginResponse>
    {
        public string Email { get; }
        public string Password { get; }
        public string RemoteIpAddress { get; }

        public LoginRequest(string email, string password, string remoteIpAddress)
        {
            Email = email;
            Password = password;
            RemoteIpAddress = remoteIpAddress;
        }
    }
}
