using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;
using System.Text.Json;
using System.Text.Json.Nodes;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaArtistasOrdenado(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Will Smith");

        var musicasPreferidasCliente = new MusicasPreferidas("Cliente");

        musicasPreferidasCliente.AdicionarMusicasFavoritas(musicas[41]);
        musicasPreferidasCliente.AdicionarMusicasFavoritas(musicas[324]);
        musicasPreferidasCliente.AdicionarMusicasFavoritas(musicas[851]);
        musicasPreferidasCliente.AdicionarMusicasFavoritas(musicas[1101]);
        musicasPreferidasCliente.AdicionarMusicasFavoritas(musicas[1745]);

        musicasPreferidasCliente.ExibirMusicasFavoritas();

        musicasPreferidasCliente.CriarArquivoJson();
        musicasPreferidasCliente.CriarArquivoTXTmusicasFavoritas();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message} ");
    }
    
}

