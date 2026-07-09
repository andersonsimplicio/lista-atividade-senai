class Program{
    static void Main(){
        double[,] matriz = new double[3,4];
        int contador = 0;
        Console.Write($" {matriz.GetLength(0)} ");
        Console.Write($" {matriz.GetLength(1)} ");

        for(int j = 0;j < matriz.GetLength(0);j++ ){
            for(int k = 0;k < matriz.GetLength(1);k++){
                Console.Write($"\nEntre com valor na posicao matriz[{j},{k}]: ");
                matriz[j,k] = double.Parse(Console.ReadLine());
                contador += (matriz[j,k] > 10)? 1:0;
            }
        }
        Console.Write($"\nTotal de numeros maiores que 10:{contador} ");
    }
}