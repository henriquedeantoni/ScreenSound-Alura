using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

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

        public void CriarArquivoJson()
        {
            string jsonInfo = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaMusicasFavoritas
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

            File.WriteAllText(nomeDoArquivo, jsonInfo);
            Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
        }

        public void CriarArquivoTXTmusicasFavoritas()
        {
            string nomeArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
            {
                arquivo.WriteLine($"músicas favoritas do {Nome}\n");
                foreach (var musica in ListaMusicasFavoritas )
                {
                    arquivo.WriteLine($"- {musica.Nome}\n");
                }
            }
            Console.WriteLine("\ntxt gerado com sucesso!");
        }

    }
}
