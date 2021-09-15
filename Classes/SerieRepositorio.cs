using System.Linq;
using Raulflix.Interfaces;
using System.Collections.Generic;

namespace Raulflix.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> _series = new List<Serie>();

        public List<Serie> Lista()
        {
            return _series;
        }

        public Serie RetornaPorId(int id)
        {
            return _series.FirstOrDefault(x => x.Id == id);
        }

        public void Insere(Serie serie)
        {
            _series.Add(serie);
        }

        public void Exclui(int id)
        {
            _series[id].Excluir();
        }

        public void Atualizar(int id, Serie serie)
        {
            _series[id] = serie;
        }

        public int ProximoId()
        {
            return _series.Count;
        }
    }
}
