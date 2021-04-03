using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
   public  class AluguelDataModel
    {
        public int Id { get; set; }

        public int  ClienteId { get; set; }

        public int CarroId { get; set; }

        public DateTime Datatransacao { get; set; }

        public DateTime DataReserva { get; set; }

        public Boolean Efetivado { get; set; }
    }
}
