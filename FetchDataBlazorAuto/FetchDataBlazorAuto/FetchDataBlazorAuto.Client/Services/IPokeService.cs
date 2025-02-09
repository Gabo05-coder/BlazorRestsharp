

namespace FetchDataBlazorAuto.Client.Services;

public interface IPokeService
{
    Task<String> GetPokemonDataAsync(string pokemonName);
}