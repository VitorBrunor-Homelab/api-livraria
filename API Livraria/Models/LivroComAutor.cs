namespace API_Livraria.Models
{
    public class LivroComAutor
    {
        public int LivroID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int? AnoPublicacao { get; set; }
        public string Genero { get; set; } = string.Empty;
        public int AutorID { get; set; }
        public string NomeAutor { get; set; } = string.Empty;
    }
}
