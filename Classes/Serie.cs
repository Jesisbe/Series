using System;

namespace Series
{
    public class Serie : EntidadeBase
    {
      // Atributos
        //public Serie(Genero genero, string titulo, string descricao, int ano) 
        //{
         //   this.Genero = genero;
         //       this.Titulo = titulo;
         //       this.Descricao = descricao;
         //       this.Ano = ano;
               
        //}

        //Atributo novo    
      private Genero Genero { get; set; } 
      private string Titulo { get; set; } 
      private string Descricao { get; set; }
      private int Ano { get; set; }

      // Coloco nuevo si aqui mi registro esta excluido o no bool si es asi falso
      private bool Excluido { get; set; }

      // Métodos

      public Serie(int id, Genero genero, string titulo, string descricao, int ano)
      {
          this.Id = id;
          this.Genero = genero;
          this.Titulo = titulo;
          this.Descricao = descricao;
          this.Ano = ano;
          //agrego novo por o boll de antes
          this.Excluido = false;
      }

        public override string ToString()
        {
            //Environment.NewLine 
            string retorno = "";
            retorno += "Género: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido + Environment.NewLine;

            return retorno;
            //return base.ToString();
        }

        //Agora encapsulamento vai retorna titulo

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        //A idea es ter 2 metodos que retornan para no ficar alterando
        public int retornaId()
        {
            return this.Id;
        }

        // criar por o boll un novo metodo. marca ponto excluido como true
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }


    }
}