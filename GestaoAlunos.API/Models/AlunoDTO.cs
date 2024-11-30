namespace GestaoAlunos.API.Models
{
    public class AlunoDTO
    {
        // Classe "anemica" que ficará por conta de receber os dados de fora e jogar pra dentro
        public string nome { get;  set; }
        public string email { get;  set; }
        public string telefone { get;  set; }
        public string cpf { get;  set; }
    }
}
