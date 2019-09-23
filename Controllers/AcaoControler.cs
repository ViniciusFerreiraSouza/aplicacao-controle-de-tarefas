namespace aplicacao_controle_de_tarefas.Controllers

{
    public class AcaoControler : Controller
    {
        private readonly ITarefaRepository acao;

        public TarefaController(ITarefaController tarefaRepository)
        {
            acao = tarefaRepository;
        }
        TarefaRepository _repository =
        new TarefaRepository();

        public IActionResult Index()
        {
            var acao = _repository.GetAll();

            return View(acao);
        }

        [HttpGet]

        public IActionResult Create(Tarefa tarefa)
    }
}