namespace aplicacao_controle_de_tarefas.Models
{
    public class TarefaRepository
    {
        public static List<Tarefa> acao = new List<Tarefa>();

        public TarefaRepository()
        {

        }
        public void Create(Tarefa tarefa)
        {
            acao.Add(tarefa);
        }

        public List<Tarefa> GetALL()
        {
            return acao;
        }

        public Tarefa GetByNumero(int numero)
        {
            return acao.Find(i=>i.numero == numero);
        }

        public void Delete(int numero)
        {
            acao.Remove(GetByIdNumero)
        }

        public void Update(Tarefa tarefa)
        {
            var index = acao.FindIndex(x=>x.numero == tarefa.numero);
            acao[index].nome = tarefa.nome;
            acao[index].limite = tarefa.limite;
            acao[index].percentual = tarefa.percentual;
        }
    }
}