<<<<<<< HEAD
﻿using AutoMapper;
using Picpay.Application.Models;
using Picpay.Domain.Entities;
using System;
=======
﻿using System;
>>>>>>> e6da564af281f9048cfdacb512d67e78beeba950
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picpay.Application.Mappings
{
<<<<<<< HEAD
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<UsuarioEntity, UsuarioModel>().ReverseMap();
            CreateMap<TransferenciaEntity, TransferenciaModel>().ReverseMap();
            CreateMap<CarteiraEntity, CarteiraModel>().ReverseMap();

        }
=======
    internal class MappingProfile
    {
>>>>>>> e6da564af281f9048cfdacb512d67e78beeba950
    }
}
