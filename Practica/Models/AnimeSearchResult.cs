using System.Text.Json.Serialization;

namespace Practica.Models
{
    public class AnimeSearchResult
    {
        [JsonPropertyName("data")]
        public List<Anime> Animes { get; set; } = new();
    }

    public class Anime
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("score")]
        public double? Score { get; set; }

        [JsonPropertyName("images")]
        public AnimeImages Images { get; set; } = new();
    }

    public class AnimeImages
    {
        [JsonPropertyName("jpg")]
        public ImageUrls Jpg { get; set; } = new();
    }

    public class ImageUrls
    {
        [JsonPropertyName("image_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
