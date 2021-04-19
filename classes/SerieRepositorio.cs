using System;
using DIO.Series.interfaces;
using System.Collections.Generic;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
       
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualizar(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornarId(int id)
        {
            return listaSerie[id];
        }
    }
}