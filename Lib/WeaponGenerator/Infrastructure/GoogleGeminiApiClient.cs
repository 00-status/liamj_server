using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoogleGeminiApiClient
{
    private string URI = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=";
    private string BODY = "{ \"contents\": [{\"parts\": [{\"text\": \"Generate a single, evocative fantasy name for a {{weapon-type}}-type weapon. It should be 1-5 words. Do not include newlines in your response. Use some of the following tags: {{weapon-tags}}. Do not generate a preamble or explanation - just generate the name itself. Thanks!\" }] }] }";
    private string? GAK;

    public GoogleGeminiApiClient(IConfiguration configuration)
    {
        GAK = configuration.GetValue<string>("GAK");
    }

    public async Task<string?> GenerateWeaponName(string weaponType, List<string> weaponTags)
    {
        if (GAK == null)
        {
            throw new DomainException("Cannot send Google API request!");
        }

        HttpClient httpClient = new();
        HttpRequestMessage request = CreateRequest(weaponType, weaponTags);
        HttpResponseMessage response = await httpClient.SendAsync(request);

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        string stringResponse = await response.Content.ReadAsStringAsync();
        Root? parsedJsonResponse = JsonSerializer.Deserialize<Root>(stringResponse);

        if (parsedJsonResponse == null
            || parsedJsonResponse.Candidates == null
            || parsedJsonResponse.Candidates.Count == 0
        ) {
            return null;
        }

        List<Part>? parts = parsedJsonResponse.Candidates[0].Content.Parts;
        if (parts == null || parts.Count == 0) {
            return null;
        }

        return parts[0].Text;
    }

    private HttpRequestMessage CreateRequest(string weaponType, List<string> weaponTags)
    {
        string bodyWithWeaponName = BODY.Replace("{{weapon-type}}", weaponType);
        string bodyWithTags = bodyWithWeaponName.Replace("{{weapon-tags}}", string.Join(", ", weaponTags.ToArray()));

        HttpRequestMessage request = new()
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(URI + GAK),
            Content = new StringContent(bodyWithTags, Encoding.UTF8, "application/json")
        };
        
        return request;
    }
}

public class Root
{
    [JsonPropertyName("candidates")]
    public required List<Candidate>? Candidates { get; set; }
}

public class Candidate
{
    [JsonPropertyName("content")]
    public required Content Content { get; set; }
}

public class Content
{
    [JsonPropertyName("parts")]
    public required List<Part>? Parts { get; set; }
}

public class Part
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }
}
