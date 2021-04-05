using Negocio.Models;
using Dados.Models;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Negocio.RepositorioDados;

namespace Dados.Repositorio
{
   public  class ClienteRepositorio : IClienteRepositorio
    {

        private readonly IMapper _mapper;
            public ClienteRepositorio(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Cliente ObterCliente(int id) {

            ClienteDataModel clienteDM = new ClienteDataModel();

            //Lógica acesso a dados

            return _mapper.Map<Cliente>(clienteDM);

        }
    }
}
