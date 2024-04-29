using Eletricista.models;
using Eletricista.Models.Enuns;
using Microsoft.EntityFrameworkCore;

namespace Eletricista.Data
{

    public class DataContext : DbContext
    {
      
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {

        }

     public DbSet<Trabalho> TB_TRABALHOS {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Trabalho>().ToTable("TB_TRABALHOS");

            modelBuilder.Entity<Trabalho>().HasData
            (
                    new Trabalho() { Id = 1, NomeCliente = "Gustavo", Rua="italia", Endereço=793, ValorTrabalho=640, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 2, NomeCliente = "Alberto", Rua="Londres", Endereço=203, ValorTrabalho=800, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 3, NomeCliente = "Carlos", Rua="Japão", Endereço=399, ValorTrabalho=350, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 4, NomeCliente = "Nicolas", Rua="Almirante Abreu", Endereço=81, ValorTrabalho=2200, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 5, NomeCliente = "Julia", Rua="Hungria", Endereço=507, ValorTrabalho=200, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 6, NomeCliente = "Henrique", Rua="Getulio", Endereço=153, ValorTrabalho=3000, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 7, NomeCliente = "Daniel", Rua="Castelo Branco", Endereço=41, ValorTrabalho=400, Classe=ClasseEnum.Cliente},
                     new Trabalho() { Id = 8, NomeCliente = "Maria", Rua="Império", Endereço=906, ValorTrabalho=1000, Classe=ClasseEnum.Cliente}
            );
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }


    }
}