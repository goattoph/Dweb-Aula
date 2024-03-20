using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dweb_Aula.Models
{
    public class UnidadesCurriculares{

        public UnidadesCurriculares() { 
            ListaProfessores = new HashSet<Professores>();
            ListaInscricoes = new HashSet<Inscricoes>();
        }

        [Key] // PK
        public int Id { get; set; }

        public string Nome { get; set; }

        public int AnoCurricular {  get; set; } 

        public int Semestre { get; set; }

        /* ****************************************
         * Construção dos relacionamentos
         * ***************************************/

        //relacionamento 1-N

        //esta anotação informa a Entity Framework que o atributo 'CursoFK' é uma FK em conjunto com o atributo'Curso'
        [ForeignKey(nameof(Curso))]
        public int CursoFK { get; set; } //Foreign Key para o Curso
        public Cursos Curso { get; set; } //Foreign Key para o Curso

        //relacionamento N-M
        public ICollection<Professores> ListaProfessores { get; set; }

        //relacionamento N-M, com atributos no relacionamento
        public ICollection<Inscricoes> ListaInscricoes { get; set; }
    }
}
