using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class FilmeRepositorio : IRepositorioFilme<Filme>
	{
        private List<Filme> listaFilme = new List<Filme>();
		public void AtualizaFilme(int id, Serie objeto)
		{
			listaFilme[id] = objeto;
		}

		public void ExcluiFilme(int id)
		{
			listaFilme[id].Excluir();
		}

		public void InsereFilme(Serie objeto)
		{
			listaFilme.Add(objeto);
		}

		public List<Filme> ListaFilme()
		{
			return listaFilme;
		}

		public int ProximoIdFilme()
		{
			return listaFilme.Count;
		}

		public Serie RetornaPorIdFilme(int id)
		{
			return listaFilme[id];
		}
	}
}