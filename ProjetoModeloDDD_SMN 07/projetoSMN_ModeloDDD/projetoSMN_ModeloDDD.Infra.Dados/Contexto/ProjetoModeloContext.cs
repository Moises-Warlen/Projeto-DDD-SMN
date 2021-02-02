using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Infra.Dados.Contexto
{
    public class ProjetoModeloContext:DbContext
    {
        public ProjetoModeloContext()
            :base("projetoModeloDDD")
        {
                
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Imagem> Imagems { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<StatusTarefa> StatusTarefas { get; set; }

    }
}
