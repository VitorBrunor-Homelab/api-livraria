namespace API_Livraria.Models
{
    public class Autor
    {
        public int ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ICollection<Livro> Livros { get; set; } = new List<Livro>();
    }
}
