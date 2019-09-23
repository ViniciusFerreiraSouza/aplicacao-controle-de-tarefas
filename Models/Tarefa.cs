namespace aplicacao_controle_de_tarefas.Models
{
    public class Tarefa
    {
        public Tarefa( ){}

        public Tarefa(float numero, string nome, DataTime limite, int percentual = 1)
        {
            this.numero = numero;
            this.nome = nome;
            DataTime limite = new DataTime;
            this.percentual = percentual;
        }
        public float numero { get; set; }

        public string nome { get ; set; }

        public DataTime limite { get ; set; }

        public int percentual { get ; set; }

        switch (percentual)
        {
            case 1;
                Console.WriteLine("10%")
                break;
            case 2;
                Console.WriteLine("20%")
                break;
            case 3;
                Console.WriteLine("30%")
                break;
            case 4;
                Console.WriteLine("40%")
                break;
            case 5;
                Console.WriteLine("50%")
                break;
            case 6;
                Console.WriteLine("60%")
                break;
            case 7;
                Console.WriteLine("70%")
                break;
            case 8;
                Console.WriteLine("80%")
                break;
            case 9;
                Console.WriteLine("90%")
                break;
            case 10;
                Console.WriteLine("100%")
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }

    }
}