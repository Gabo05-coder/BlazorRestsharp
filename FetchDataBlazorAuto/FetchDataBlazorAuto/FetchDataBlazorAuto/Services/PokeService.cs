namespace FetchDataBlazorAuto.Services;

using RestSharp;
using System.Threading.Tasks;
using FetchDataBlazorAuto.Client.Services;


public class PokeService : IPokeService
{
    public async Task<string> GetPokemonDataAsync(string pokemonName)
    {
        var client = new RestClient("https://pokeapi.co/api/v2/");
        var request = new RestRequest($"pokemon/{pokemonName}", Method.Get);
        var response = await client.ExecuteAsync<PokemonResponse>(request);

        if (response.IsSuccessful)
        {
            return response.Data.Name;
        }

        return null;
    }

    private class PokemonResponse
    {
        public string Name { get; set; }
    }
}