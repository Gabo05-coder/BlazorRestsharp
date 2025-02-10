namespace DefaultNamespace;


public class PokeInfoService
{
    private RestClient pokeClient;
    
    public void SetUpRestSharpClient()
    {
        pokeClient = new RestClient("https://pokeapi.co/api/v2/");
    }
    
    Public async Task PokeGetInfo()
    {
        RestRequest request = new RestRequest("", Method.GET);
    }

    
}