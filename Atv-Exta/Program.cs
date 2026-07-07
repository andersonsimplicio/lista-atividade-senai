class Program{
     public static void Main(){
        const int tam = 60;
        int[] vetor_orig = new int[tam] {5,5,8,9,9,9,7,9,6,4,5,9,8,9,9,5,7,8,6,4,5,5,8,9,9,5,7,8,6,4,5,5,8,9,9,5,7,8,6,4,5,5,8,9,9,5,7,8,6,4,5,5,8,9,9,5,7,8,6,4};
        int[] memoria = new int[tam];
        int pos = 0,contador = 0,find=0;
        bool existe=false;
        for(int i=0; i< tam; i++){
            find = vetor_orig[i];
            for(int k=0;k<pos;k++){
                if(find==memoria[k]){
                    existe=true;
                    break;
                }else{
                    existe=false;
                }
            }
            if(!existe){         
                for(int x=0; x< tam; x++){
                    contador+= (find ==vetor_orig[x])?1:0;
                }
                memoria[pos] = find;
                Console.Write($"\n {find} {((double)contador / tam)*100:F1}%");
                 pos++;
                }
            contador = 0;
           
            
        }
     }
     
}