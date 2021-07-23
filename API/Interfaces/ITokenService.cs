using API.Entities;

namespace API.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser user, System.IO.BinaryReader JwtRegisteredClaimNames);
        string CreateToken(AppUser user);
    }
}