using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Application.Dtos.Create;
using BankSystem.Domain.Entities;
using BankSystem.Domain.Entities.Branch;

namespace BankSystem.Application.Mappers;

public class RequestResponseMapper : Profile
{
    public RequestResponseMapper()
    {
        CreateMap<Client, CreateClientDto>()
            // .ForMember(dest => dest.SurName, opt => opt.MapFrom(src => src.SurName))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            // .ForMember(dest => dest.FathersName, opt => opt.MapFrom(src => src.FathersName))
            .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PassportNumber))
            // .ForMember(dest => dest.IssuedDate, opt => opt.MapFrom(src => src.IssuedDate))
            // .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
            // .ForMember(dest => dest.PlaceOfBirth, opt => opt.MapFrom(src => src.PlaceOfBirth))
            // .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
            // .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
            // .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality))
            // .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            // .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            ;
        CreateMap<CreateClientDto, Client>()
            .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => Guid.NewGuid()))
            // .ForMember(dest => dest.SurName, opt => opt.MapFrom(src => src.SurName))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            // .ForMember(dest => dest.FathersName, opt => opt.MapFrom(src => src.FathersName))
            .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PassportNumber))
            // .ForMember(dest => dest.IssuedDate, opt => opt.MapFrom(src => src.IssuedDate))
            // .ForMember(dest => dest.ExpiryDate, opt => opt.MapFrom(src => src.ExpiryDate))
            // .ForMember(dest => dest.PlaceOfBirth, opt => opt.MapFrom(src => src.PlaceOfBirth))
            // .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
            // .ForMember(dest => dest.Gender, opt => opt.MapFrom(src => src.Gender))
            // .ForMember(dest => dest.Nationality, opt => opt.MapFrom(src => src.Nationality))
            // .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            // .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
            ;

        CreateMap<ClientDto, Client>()
            // .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            // .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => Guid.NewGuid()))
            // .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PassportNumber))
            ;
        CreateMap<Client, ClientDto>()
            // .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            // .ForMember(dest => dest.PassportNumber, opt => opt.MapFrom(src => src.PassportNumber))
            ;
    }
}