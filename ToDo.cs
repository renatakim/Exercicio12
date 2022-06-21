namespace Exercicio12
{
    internal class ToDo
    {
        List<string> Tarefas = new List<string>();
        public void AdicionarTarefa()
        {
            Console.WriteLine("Adicione uma tarefa");
            Tarefas.Add(Console.ReadLine());
        }
        public void RemoverTarefa()
        {
            Console.WriteLine("Remova uma tarefa");
            Tarefas.Remove(Console.ReadLine());
        }
        public void AtualizarTarefa()
        {
            Console.WriteLine("Qual tarefa deseja atualizar?");
            string atualizandoTarefa = Console.ReadLine();
            if (Tarefas.Contains(atualizandoTarefa))
            {
                Console.WriteLine("Qual a nova tarefa?");
                int index = Tarefas.IndexOf(atualizandoTarefa);
                Tarefas[index] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tarefa inexistente, remova outra tarefa");
            }
        }
        public void ListarTodasAsTarefas()
        {
            Console.WriteLine("-----------------------------");
            foreach (string item in Tarefas)
            {
                Console.WriteLine(item);
            }

        }
        public void ApresentarTarefa(int index)
        {
            Console.WriteLine(Tarefas[index]);
        }

    }
}
