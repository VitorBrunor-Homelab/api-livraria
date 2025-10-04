using Microsoft.EntityFrameworkCore;
using API_Livraria.Models;

namespace API_Livraria.Data
{
    public class LivrariaDbContext : DbContext
    {
        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options) : base(options) { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroComAutor> LivrosComAutores { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("AUTORES", "PROJECT_API");

                entity.Property(e => e.ID).HasColumnName("ID");
                entity.Property(e => e.Nome).HasColumnName("NOME");
            });

            modelBuilder.Entity<Livro>(entity => 
            {
                entity.ToTable("LIVROS", "PROJECT_API");

                entity.Property(e => e.ID).HasColumnName("ID"); 
                entity.Property(e => e.Titulo).HasColumnName("TITULO");
                entity.Property(e => e.AnoPublicacao).HasColumnName("ANOPUBLICACAO");
                entity.Property(e => e.AutorID).HasColumnName("AUTORID");
                entity.Property(e => e.Genero).HasColumnName("GENERO");
            });

            modelBuilder.Entity<LivroComAutor>(entity =>
            {
                entity.ToView("VW_LIVROS_COM_AUTORES", "PROJECT_API");
                entity.HasNoKey();

                entity.Property(e => e.LivroID).HasColumnName("LIVROID");
                entity.Property(e => e.Titulo).HasColumnName("TITULO");
                entity.Property(e => e.AnoPublicacao).HasColumnName("ANOPUBLICACAO");
                entity.Property(e => e.Genero).HasColumnName("GENERO");
                entity.Property(e => e.AutorID).HasColumnName("AUTORID");
                entity.Property(e => e.NomeAutor).HasColumnName("NOMEAUTOR");
            });
        }   
        
    }
}
