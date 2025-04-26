namespace Engrana.Configuration;

public class CorsConfiguration
{
    public string Policy { get; set; } = string.Empty;
    public string[] Origins { get; set; } = [];
}
