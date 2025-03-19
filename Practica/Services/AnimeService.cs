namespace Practica.Services;
    using Practica.Models;


    public class AnimeService
    {
        private readonly HttpClient _httpClient;

        public AnimeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AnimeSearchResult?> SearchAnime(string query)
        {
            return await _httpClient.GetFromJsonAsync<AnimeSearchResult>(
                $"https://api.jikan.moe/v4/anime?q={query}");
        }
    }

