using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaMedica.Models
{
    public class Agendamento
    {
        public Agendamento()
        {
            Id = Guid.NewGuid();
        }

        /// <summary>
        /// Id do item na agenda.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        /// <summary>
        /// Horário do agendamento.
        /// </summary>
        public DateTimeOffset HorarioAgendamento { get; set; }

        /// <summary>
        /// Tempo da consulta.
        /// </summary>
        public TimeSpan TempoConsulta { get; set; }

        /// <summary>
        /// Horário final do atendimento previsto.
        /// </summary>
        public DateTimeOffset HorarioFinalAtendimento { get; set; }
    }
}
