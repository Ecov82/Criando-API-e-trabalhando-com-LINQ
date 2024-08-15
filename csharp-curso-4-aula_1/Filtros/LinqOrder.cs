using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistaOrdenados(List <Musica> musicas)
        {
            var artistaOrdenados = musicas.OrderBy(musica => musica.Artista).
                Select(musica => musica.Artista).
                Distinct().ToList();
            Console.WriteLine("Lista de Artistas Ordenados"); 
            foreach(var artista in artistaOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }
        }   
    }
}
