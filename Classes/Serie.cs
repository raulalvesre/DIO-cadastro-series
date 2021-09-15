using Raulflix.Enum;

namespace Raulflix.Classes
{
    public class Serie : EntidadeBase
    {
		public Genero Genero { get; private set; }
		public string Titulo { get; private set; }
		public string Descricao { get; private set; }
		public int Ano { get; private set; }
        public bool Excluido {get; private set;}

		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			Id = id;
			Genero = genero;
			Titulo = titulo;
			Descricao = descricao;
			Ano = ano;
            Excluido = false;
		}

        public void Excluir() {
            this.Excluido = true;
        }

        public override string ToString()
		{
            return $@"
            Gênero: {Genero}
            Titulo: {Titulo}
            Descrição: {Descricao}
            Ano de Início: {Ano}
            Excluído: {Excluido}";
        }
    }
}