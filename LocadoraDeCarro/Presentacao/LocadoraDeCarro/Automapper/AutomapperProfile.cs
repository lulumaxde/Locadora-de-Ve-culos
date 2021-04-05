using AutoMapper;
using Dados.Models;
using LocadoraDeCarro.Models;
using Negocio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LocadoraDeCarro.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();

            CreateMap<Cliente, ClienteDataModel>().ReverseMap();
        }
    }
}
