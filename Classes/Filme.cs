using System;

namespace DIO.Series
{
    public class Filme : EntidadeBase
    {
           // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

          // Métodos
		public Filme(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
        }

        public string retornaTituloFilme()
		{
			return this.Titulo;
		}

		public int retornaIdFilme()
		{
			return this.Id;
		}
        public bool retornaExcluidoFilme()
		{
			return this.Excluido;
		}
        public void ExcluirFilme() {
            this.Excluido = true;
        }
}