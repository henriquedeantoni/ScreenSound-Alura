﻿using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista} ");
        Console.WriteLine($"Música: {Nome} ");
        Console.WriteLine($"Duração: {(int)Duracao/1000} segundos");
        Console.WriteLine($"Gênero Musical: {Genero} ");
    }
}

