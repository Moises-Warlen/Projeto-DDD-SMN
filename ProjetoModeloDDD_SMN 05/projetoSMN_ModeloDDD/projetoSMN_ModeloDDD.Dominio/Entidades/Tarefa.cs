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
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
        public int IdStatusTarefa { get; set; }

    }
}
