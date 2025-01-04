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
        Console.WriteLine(nomeArtista);

        foreach(var musica in musicasArtista )
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
