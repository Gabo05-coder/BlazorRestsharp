namespace FetchDataBlazorAuto.Services;

using RestSharp;
using System.Threading.Tasks;

public class PokeService
{
    private readonly RestClient _client;

    public PokeService()
    {
        _client = new RestClient("https://pokeapi.co/api/v2/");
    }

    public async Task<PokemonData> GetPokemonDataAsync(string pokemonName)
    {
        var request = new RestRequest($"pokemon/{pokemonName}", Method.Get);
        var response = await _client.ExecuteAsync<PokemonData>(request);
        if (response.IsSuccessful)
        {
            return response.Data;
        }
        else
        {
            return null;
        }
    }
}

public class PokemonData
{
    public string Name { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public PokemonSprite sprites { get; set; }
}

public class PokemonSprite
{
    public string Front_Default { get; set; }
}