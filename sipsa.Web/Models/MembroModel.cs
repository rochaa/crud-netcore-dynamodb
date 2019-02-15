using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sipsa.Web.Models {
    public class MembroModel {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Naturalidade { get; set; }
        public string EstadoCivil { get; set; }
        public string Escolaridade { get; set; }
        public string Profissao { get; set; }
        public string Titulo { get; set; }
        public string Igreja { get; set; }
        public List<string> Telefones { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public DateTime Data { get; set; }
        public int Ata { get; set; }
        public string Recepcao { get; set; }
    }
}