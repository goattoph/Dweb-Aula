using System.ComponentModel.DataAnnotations.Schema;

namespace Dweb_Aula.Models
{
    public class Alunos : Utilizadores{

        //um Aluno é um objeto do tipo Utilizadores
        //um Aluno é um caso do tipo Utilizadores
        public Alunos() {
            ListaInscricoes = new HashSet<Inscricoes>(); 
        }
        public int NumAluno { get; set; }

        public decimal Propinas { get; set;}

        public DateTime DataMatricula { get; set;}

        /* ****************************************
             * Construção dos relacionamentos
        * ***************************************/

        //relacionamento 1-N

        //esta anotação informa a Entity Framework que o atributo 'CursoFK' é uma FK em conjunto com o atributo'Curso'
        [ForeignKey(nameof(Curso))]
        public int CursoFK { get; set; } //Foreign Key para o Curso
        public Cursos Curso { get; set; } //Foreign Key para o Curso

        // relacionamento N-M, com atributos no relacionamento
        public ICollection<Inscricoes> ListaInscricoes { get; set; }     
    }
}
