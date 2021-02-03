﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoSMN_ModeloDDD.Dominio.Entidades;

namespace projetoSMN_ModeloDDD.Infra.Dados.EntityConfig
{
   public class TarefaConfiguration:EntityTypeConfiguration<Tarefa>
    {
        public TarefaConfiguration()
        {
            HasKey(t => t.Id);
            Property(t => t.Descricao)
                .IsRequired()
                .HasMaxLength(100);

           
        }


    }
}