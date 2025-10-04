namespace API_Livraria.Models
{
    public class Livro
    {
        public int ID { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int? AnoPublicacao { get; set; }
        public string Genero { get; set; } = string.Empty;
        public int AutorID { get; set; }
        public Autor? Autor { get; set; }
    }
}
