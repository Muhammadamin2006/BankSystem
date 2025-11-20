using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Domain.Entities;
using BankSystem.Presentation.RequestModels;
using BankSystem.Presentation.ViewModels;

namespace BankSystem.Presentation.Mappers;

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