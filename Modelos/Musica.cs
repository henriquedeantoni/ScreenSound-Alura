using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"};

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("popularity")]
    public string? Popularidade { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade {

        get
        {
            return tonalidades[Key];
        }
                
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista} ");
        Console.WriteLine($"Música: {Nome} ");
        Console.WriteLine($"Duração: {(int)Duracao/1000} segundos");
        Console.WriteLine($"Gênero Musical: {Genero} ");
        Console.WriteLine($"Ano: {Ano} ");
        Console.WriteLine($"Popularidade: {Popularidade} ");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }
}

