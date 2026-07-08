class Program{
    static void Main(){
        double[,] alunos = new double[5,2];
        int posicao_mais_alto = 0;
        int posicao_mais_baixo = 0;
        for(int k=0;k < alunos.GetLength(0); k++){
             Console.Write("Digite o Codigo do Aluno: ");
              alunos[k,0] = int.Parse(Console.ReadLine());   
              Console.Write("Digite a altura do Aluno (m) : ");   
              alunos[k,1] = double.Parse(Console.ReadLine());      
        }
        for(int k=0;k < alunos.GetLength(0); k++){
            posicao_mais_alto = (alunos[k,1] > alunos[posicao_mais_alto,1])?k:posicao_mais_alto;
            posicao_mais_baixo = (alunos[k,1] < alunos[posicao_mais_baixo,1])?k:posicao_mais_baixo;
        }
        Console.Write($"\nO aluno com maior altura \nCodigo:{alunos[posicao_mais_alto,0]} Altura:{alunos[posicao_mais_alto,1]:F2} ");
        Console.Write($"\nO aluno com menor altura \nCodigo:{alunos[posicao_mais_baixo,0]} Altura:{alunos[posicao_mais_baixo,1]:F2} ");
        
    }
}