
using System.Numerics;

class Program{
    static void Main(){
        int[,] matrix = new int[10,20]{
            {12, 85, 43, 67, 9, 21, 54, 78, 33, 90, 15, 62, 8, 47, 71, 29, 84, 50, 18, 96},
            {37, 11, 59, 24, 81, 66, 3, 45, 92, 14, 70, 57, 88, 31, 76, 40, 99, 6, 53, 27},
            {64, 19, 82, 13, 91, 39, 74, 2, 56, 87, 30, 68, 41, 97, 10, 52, 25, 79, 35, 60},
            {44, 95, 5, 73, 28, 80, 17, 63, 49, 86, 22, 58, 93, 34, 69, 1, 77, 46, 83, 20},
            {51, 7, 98, 36, 72, 16, 61, 89, 26, 55, 42, 94, 4, 65, 32, 75, 23, 48, 84, 18},
            {79, 14, 57, 90, 11, 67, 38, 82, 5, 53, 96, 20, 71, 43, 87, 29, 62, 8, 34, 99},
            {24, 76, 41, 58, 13, 85, 31, 69, 47, 92, 17, 54, 0, 63, 88, 36, 72, 15, 50, 27},
            {66, 10, 81, 33, 94, 46, 19, 78, 59, 7, 97, 28, 64, 12, 83, 39, 55, 91, 21, 74},
            {35, 60, 2, 73, 44, 86, 18, 95, 52, 30, 68, 9, 77, 25, 93, 48, 61, 14, 80, 37},
            {56, 89, 23, 65, 40, 1, 84, 32, 70, 16, 98, 49, 6, 75, 27, 62, 11, 57, 45, 90},
        };
        int maior_elemento =0;
        double media=0;
        BigInteger produto=1;
        int[] dados;

        
        Console.Write($" \n|Letra A) O maior elemento de cada linha da matriz.  \n");
        for(int i = 0; i < matrix.GetLength(0);i++){
            for(int j = 0; j < matrix.GetLength(1);j++){
                maior_elemento = (maior_elemento > matrix[i,j]) ? maior_elemento : matrix[i,j];
                produto*= (matrix[i,j]!=0)? matrix[i,j] : 1;
            }
            Console.Write($" \n| Maio Elemento - {maior_elemento}  - linha :{i}|\n");
            maior_elemento = matrix[0,0];
        }
      
      Console.Write($" \n| Letra B) A média dos elementos de cada coluna. |\n");
        for(int i = 0; i < matrix.GetLength(1);i++){
            for(int j = 0; j < matrix.GetLength(0);j++){
                Console.Write($" {matrix[j,i]} ");
                media+=matrix[j,i];
            }
             media /= matrix.GetLength(0);
             Console.Write($" \n| Media - {media:F2} |\n");
             media = 0;
        }

       
        foreach (var item in matrix)
        {
           produto*=(item!=0)?item:1;
        }
         Console.Write($" \n| Letra C) O produto de todos os elementos diferentes de zero. {produto} |\n");

         Console.Write($" \n| Letra D) A posição ocupada (linha-coluna) por um elemento: ");
         dados = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
         Console.Write($"Conteúdo da Matrix: {matrix[dados[0],dados[1]]} |\n");
         
    }
}