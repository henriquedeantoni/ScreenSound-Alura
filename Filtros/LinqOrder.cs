using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaArtistasOrdenado(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("Lista de Artistas Ordenados: \n");

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
