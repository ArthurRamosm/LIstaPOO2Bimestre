using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Competicao
    {
        public string Nome { get; set; }
        public List<Competidor> ListaDeCompetidores { get; set; }

        public void AdicionarCompetidor(Competidor competidor)
        {
            if (competidor == null)
            {
                throw new ArgumentNullException(nameof(competidor), "O competidor não pode ser nulo.");
            }
            ListaDeCompetidores.Add(competidor);
        }
    }
}
