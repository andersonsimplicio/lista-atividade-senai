

class Program{
    public static void Main(){
        int[] vetor = new int[10];
        int contador_par = 0;

        for(int i=0;i < vetor.GetLength(0); i++){
            Console.Write($"Digite o valor: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        for(int i=0;i < vetor.GetLength(0); i++){
           contador_par += vetor[i]%2==0?1:0; 
        }
        Console.Write($"A quantidade de numeros que são pares :{contador_par}\n vetor_par: ");
        
        for(int i=0;i < vetor.GetLength(0); i++){
            if(vetor[i]%2==0)
                 Console.Write($"{vetor[i]}, ");
        }
    } 
}