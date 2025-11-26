using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Domain.Entities;
using BankSystem.Web.RequestModels;
using BankSystem.Web.ResponseModels;

namespace BankSystem.Web.Mappers;

public class ClientMappers : Profile
{
    public ClientMappers()
    {
        CreateMap<RequestCreateClient, CreateClientDto>();
        CreateMap<CreateClientDto, RequestCreateClient>();
        
        CreateMap<ResponseCreateClient, CreateClientDto>();
        CreateMap<CreateClientDto, ResponseCreateClient>();
        
        CreateMap<ClientDto, ResponseCreateClient>();
        CreateMap<ResponseCreateClient, ClientDto>();

    }
    
}