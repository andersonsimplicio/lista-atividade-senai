class Program{
    static void Main(){
        int[] elementos = new int[10];
        int maior,menor;


        for(int i=0; i < elementos.GetLength(0); i ++){

            Console.Write("Digite um valor: ");
            elementos[i] = int.Parse(Console.ReadLine());
        }

        maior = elementos[0];
        menor = elementos[0];

        for(int i=0; i < elementos.GetLength(0); i ++){
            maior = (maior>elementos[i])?maior:elementos[i];
            menor = (menor<elementos[i])?menor:elementos[i];
        }
        Console.WriteLine($"O maior elemento {maior} e o menor {menor} ");
    }
}