using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.ModuloCategorias
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string titulo;
        public Categoria(string titulo)
        {
            this.titulo = titulo;
        }

        public override void AtualizarInformacoes(Categoria registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.titulo = registroAtualizado.titulo;
        }

        public override bool Equals(object? obj)
        {
            return obj is Categoria categoria &&
                   id == categoria.id &&
                   titulo == categoria.titulo;
        }

        public override string? ToString()
        {
            return $"Titulo: {titulo}";
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo \"titulo\" é obrigatório");

            return erros;
        }


    }
}
