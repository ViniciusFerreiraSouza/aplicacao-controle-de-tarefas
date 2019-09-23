namespace aplicacao_controle_de_tarefas.Models
{
    public class ITarefaRepository
    {
        Tarefa GetbyNumero(int numero);

        List<Tarefa>GetALL();

        void Save(Tarefa tarefa);

        void Delete(int numero);

        void Update(Tarefa tarefa);
    }
}