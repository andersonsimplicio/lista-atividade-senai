
namespace exemplo.Model{


class Aluno{
    private String matricula;
    private String nome;
    private double[] notas;

    public Aluno(String matricula){
        //nota1 nota2 trabalho e media
        this.notas =  new double[4];
        this.matricula = matricula;
        this.nome = "";

    }
    public void setNome(String nome){
                String teste ="";
                teste = String.IsNullOrWhiteSpace(nome)?throw new ArgumentException("Nome não vazio seu animal!", nameof(nome)):nome;
                this.nome = teste.All(char.IsDigit)?throw new ArgumentException("Não conter numeral", nameof(nome)):teste;


    }



}


}