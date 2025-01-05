using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

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

    public static void ExibirQuantidadesDeMusicaPorTonalidade(List<Musica> musicas)
    {
        int rangeTonalidades = tonalidades.Length;

        Dictionary<string, int> quantidadeTonalidade = new Dictionary<string, int>();

        Console.WriteLine("A quantidade de músicas por tonalidade: \n");

        foreach (var tom in tonalidades)
        {
            var quantidade = musicas.Count(musica => musica.Tonalidade.Equals(tom));

            quantidadeTonalidade[tom] = quantidade;

            Console.WriteLine($"A tonalidade {tom} possui {quantidade} musicas.");
        }

    }
}
