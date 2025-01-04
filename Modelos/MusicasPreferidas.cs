using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    class MusicasPreferidas
    {
        public string Nome { get; set; }
        public List<Musica> ListaMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas {Nome}");

            foreach(var musica in ListaMusicasFavoritas)
            {
                Console.WriteLine($"{musica.Nome} - {musica.Artista }");
            }
        }
    }
}
