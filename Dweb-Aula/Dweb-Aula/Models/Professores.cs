namespace Dweb_Aula.Models
{
    public class Professores : Utilizadores{

        //um Professor é um objeto do tipo Utilizadores
        //um Professor é um caso do tipo Utilizadores
        public Professores() { 
            ListaUCs = new HashSet<UnidadesCurriculares>();
        }

        /* ****************************************
         * Construção dos relacionamentos
         * ***************************************/

        //relacionamento N-M
        public ICollection<UnidadesCurriculares> ListaUCs { get; set; }
    }
}
