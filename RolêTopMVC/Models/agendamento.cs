using System;

namespace RolêTopMVC.Models
{
    public class agendamento : Produto
    {
        public agendamento(string data, string horario)
        {
            this.data = data;
            this.horario = horario;
        }

    }
}