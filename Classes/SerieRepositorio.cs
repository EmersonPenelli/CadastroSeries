using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCadastroSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }
        public void Exclui(int id)
        {
            throw new NotImplementedException();
        }
        public void Insere(int entidade)
        {
            throw new NotImplementedException();
        }
        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }
        public int ProximoId()
        {
            throw new NotImplementedException();
        }
        public Serie RetornaId(int id)
        {
            throw new NotImplementedException();
        }
    }


}