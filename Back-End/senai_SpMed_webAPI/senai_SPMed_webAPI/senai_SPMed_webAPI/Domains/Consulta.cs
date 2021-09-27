using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_SPMed_webAPI.Domains
{
    public partial class Consulta
    {
        public short IdConsulta { get; set; }

        [Required(ErrorMessage = "O Paciente é necessário para o Cadastro de Consultas")]
        public short? IdPaciente { get; set; }

        [Required(ErrorMessage = "O Médico é necessário para o Cadastro de Consultas")]
        public short? IdMedico { get; set; }

        public DateTime DataConsulta { get; set; }
        public string Situacao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
