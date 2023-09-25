using HealthChecksAPI_6.Dto;
using HealthChecksAPI_6.Models;

namespace HealthChecksAPI_6.Services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
    }
}
