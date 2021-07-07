using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();  
        }
        [NotMapped]
        public string NomePropriedade  { get; set; }
        [NotMapped]
        public string mensagem { get; set; }
        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }

        public bool ValidarPropriedadeString( string valor, string nomeDaPropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomeDaPropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "Campo obrigatório",
                    NomePropriedade = nomeDaPropriedade,

                });
                return false;
            }
            return true;
        }
        public bool ValidarPropriedadeInt(int valor, string nomeDaPropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomeDaPropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomeDaPropriedade,

                });
                return false;
            }
            return true;
        }
        public bool ValidarPropriedadeDecimal(decimal valor, string nomeDaPropriedade)
        {
            if (valor < 1 || string.IsNullOrWhiteSpace(nomeDaPropriedade))
            {
                Notitycoes.Add(new Notifies
                {
                    mensagem = "Valor deve ser maior que 0",
                    NomePropriedade = nomeDaPropriedade,

                });
                return false;
            }
            return true;
        }
    }
}
