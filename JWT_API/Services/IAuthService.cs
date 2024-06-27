using JWT_API.Dtoes;

namespace JWT_API.Services
{
    public interface IAuthService
    {
        Task<AuthModelDto> RegisterAsync(RegisterModelDto model);
        Task<AuthModelDto> LoginAsync(LoginModelDto model);
        Task<AuthModelDto> RefreshTokenAsync(string token);
        Task<bool> RevokeTokenAsync(string token);
    }
}
