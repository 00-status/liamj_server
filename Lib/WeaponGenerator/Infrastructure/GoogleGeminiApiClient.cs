using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoogleGeminiApiClient
{
    private string URI = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=";
    private string BODY = "{ \"contents\": [{\"parts\": [{\"text\": \"Generate an evocative fantasy name for a {{weapon-type}}-type weapon. It should be 1-5 words. Use some of the following tags: {{weapon-tags}}. Do not generate a preamble or explanation - just generate the name itself. Thanks!\" }] }] }";
    private string? GAK;

    public GoogleGeminiApiClient(IConfiguration configuration)
    {
        GAK = configuration.GetValue<string>("GAK");
    }

    // TODO: Handle non-success statuses more gracefully.
    public async Task<string> GenerateWeaponName(string weaponType, List<string> weaponTags)
    {
        if (GAK == null) {
            throw new DomainException("Cannot send Google API request!");
        }

        string bodyWithWeaponName = BODY.Replace("{{weapon-type}}", weaponType);
        string bodyWithTags = bodyWithWeaponName.Replace("{{weapon-tags}}", string.Join(", ", weaponTags.ToArray()));

        HttpRequestMessage request = new()
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(URI + GAK),
            Content = new StringContent(bodyWithTags, Encoding.UTF8, "application/json")
        };

        HttpClient httpClient = new();
        HttpResponseMessage response = await httpClient.SendAsync(request);

        string stringResponse = await response.Content.ReadAsStringAsync();

        Root? root = JsonSerializer.Deserialize<Root>(stringResponse);

        if (root == null) {
            return "";
        }

        return root.Candidates[0].Content.Parts[0].Text;
    }
}

public class Root
{
    [JsonPropertyName("candidates")]
    public required List<Candidate> Candidates { get; set; }
}

public class Candidate
{
    [JsonPropertyName("content")]
    public required Content Content { get; set; }
}

public class Content
{
    [JsonPropertyName("parts")]
    public required List<Part> Parts { get; set; }
}

public class Part
{
    [JsonPropertyName("text")]
    public required string Text { get; set; }
}
