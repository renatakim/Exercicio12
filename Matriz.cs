namespace Exercicio12
{
    public class Matriz
    {
        char[,] Coordenada = new char[3, 3]
        {
            { '7', '8', '9' },
            { '6', '5', '4' },
            { '3', '2', '1' },
        };
        
        public void Print()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(Coordenada[i,j]);
                }
            }
        }
    }

}
