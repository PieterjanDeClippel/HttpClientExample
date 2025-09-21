using MintPlayer.Http;
using System.Diagnostics;
using System.Text.Json.Serialization;

using var httpClient = new HttpClient();

var (artists, statusCode, headers) = await httpClient
    .FromJsonWithMetaAsync<List<Artist>>(new HttpRequestMessage(HttpMethod.Get, "https://mintplayer.com/api/v1/artist")
    .AcceptJson());

Debugger.Break();

class Artist
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("yearStarted")] public int? YearStarted { get; set; }
    [JsonPropertyName("yearQuit")] public int? YearQuit { get; set; }
}