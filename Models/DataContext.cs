namespace aplicacao_controle_de_tarefas.Models
{
    public class DataContext : DbContext
    {
        public Data Context(DbContextOptions<DataContext> options)
            : base(options)
            { }

            public DbSet<Tarefa> Acao { get; set; }
    }
}