namespace Dweb_Aula.Models
{
    public class Professores{

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
