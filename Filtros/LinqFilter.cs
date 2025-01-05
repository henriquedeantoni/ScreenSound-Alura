using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;
internal class LinqFilter
{

    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musica)
    {
        var todosGenerosMusicais = musica.Select(generos => generos.Genero ).Distinct().ToList();

        foreach( var genero in todosGenerosMusicais )
        {
            Console.WriteLine($"- {genero}");
        }

    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas
            .Where(musica => musica.Genero!.Contains(genero))
            .Select(musicas => musicas.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Exibindo os artistas por gênero musical {genero} \n");

        foreach(var artista in artistasPorGeneroMusical )
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        var musicasArtista = musicas
            .Where(musica => musica.Artista!.Equals(nomeArtista))
            .ToList();
        Console.WriteLine($"Exibindo As músicas do artista {nomeArtista} \n");

        foreach(var musica in musicasArtista )
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string ano)
    {
        var musicasAno = musicas.Where(musica => musica.Ano!.Equals(ano)).ToList();
        Console.WriteLine($"Exibindo as músicas do ano {ano} \n");

        foreach (var musica in musicasAno)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string nomeTonalidade)
    {
        var musicasTonalidade = musicas.Where(musica => musica.Tonalidade!.Equals(nomeTonalidade)).ToList();

        Console.WriteLine($"\nExibindo as músicas que possuem a tonalidade {nomeTonalidade}: \n");

        foreach(var musica in musicasTonalidade )
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
