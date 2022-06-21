namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matriz = new Matriz();
            matriz.Print();

            var toDo = new ToDo();
            toDo.AdicionarTarefa();
            toDo.AdicionarTarefa();
            toDo.AdicionarTarefa();
            toDo.AdicionarTarefa();
            toDo.AdicionarTarefa();
            toDo.RemoverTarefa();
            toDo.AtualizarTarefa();
            toDo.ListarTodasAsTarefas();
            toDo.ApresentarTarefa(3);

        }
    }
}
