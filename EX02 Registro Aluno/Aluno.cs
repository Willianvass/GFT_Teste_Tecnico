namespace EX02_Registro_Aluno
{
    public class Aluno
    {
        public Aluno(string nome, decimal nota, decimal frequencia)
        {
            this.nome = nome;
            this.nota = nota;
            this.frequencia = frequencia;
        }

        public string nome {get; set; }
    public decimal nota {get; set; }
    public decimal frequencia {get; set; }
    }
}