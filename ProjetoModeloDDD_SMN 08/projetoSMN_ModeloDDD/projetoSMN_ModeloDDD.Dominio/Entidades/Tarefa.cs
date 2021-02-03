using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoSMN_ModeloDDD.Dominio.Entidades
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int StatusTarefaId { get; set; }
        public string Descricao { get; set; }
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
        public string URL { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual StatusTarefa StatusTarefa { get; set; }
    }
}
