using System.ComponentModel.DataAnnotations.Schema;

namespace Dweb_Aula.Models
{
    public class Inscricoes{
        //tabela fo relacionamento
        public DateTime DataInscricao { get; set; }

        //relacionamento N-M, com atributos no relacionamento
        [ForeignKey(nameof(UnidadesCurriculares))]
        public int ÚnidadeCurricularFK { get; set; }

        public UnidadesCurriculares UnidadesCurriculares { get; set; }

        [ForeignKey(nameof(Aluno))]
        public int AlunoFK { get; set; }

        public Alunos Aluno { get; set; }
    }
}
