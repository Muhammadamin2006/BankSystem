using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Application.IRepository;
using BankSystem.Application.IService;
using BankSystem.Domain.Entities;

namespace BankSystem.Application.Service;

public class ClientService :  IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IMapper _mapper;

    public ClientService(IClientRepository clientRepository, IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<ClientDto> RegisterClientAsync(CreateClientDto createClientDto)
    {
        // var idexist = await _clientRepository.PassportNumberExistAsync(createClientDto.PassportNumber);
        // if (idexist) throw new Exception("Passport number already exist");

        var createclient = new Client()
        {
            ClientId = Guid.NewGuid(),
            //SurName = createClientDto.SurName,
            Name = createClientDto.Name,
            // FathersName = createClientDto.FathersName,
            // ClientStatus = "Standard",
            PassportNumber = createClientDto.PassportNumber,
            // IssuedDate = createClientDto.IssuedDate,
            // ExpiryDate = createClientDto.ExpiryDate,
            // PlaceOfBirth = createClientDto.PlaceOfBirth,
            // Address = createClientDto.Address,
            // Gender = createClientDto.Gender,
            // Nationality = createClientDto.Nationality,
            // Email = createClientDto.Email,
            // PhoneNumber = createClientDto.PhoneNumber,
            // IsActive = true,
            // UpdatedDate = DateTime.Now
            
        };

        await _clientRepository.CreateAsync(createclient);
        return _mapper.Map<ClientDto>(createclient);
    
    }

    public async Task<ClientDto> GetClientByIdAsync(Guid id)
    {
        var clienidexist = await _clientRepository.IdExistAsync(id);
        if (!clienidexist) throw new Exception("Id already exist");
        
        var getclientbyid = await _clientRepository.GetByIdAsync(id);
        return _mapper.Map<ClientDto>(getclientbyid);
    }

    public async Task<IEnumerable<ClientDto>> GetAllClientsAsync()
    {
        var getall = await _clientRepository.GetAllAsync();
        return _mapper.Map<List<ClientDto>>(getall);
    }

    // public async Task<ClientDto> GetClientByEmailAsync(string email)
    // {
    //     var emailexist = await _clientRepository.EmailExistAsync(email);
    //     if (!emailexist) throw new Exception("Email already exist");
    //     
    //     var getclientbyemail = await _clientRepository.GetClientByEmailAsync(email);
    //     return _mapper.Map<ClientDto>(getclientbyemail);
    // }
    //
    // public async Task<ClientDto> GetClientsByPhoneNumberAsync(string phoneNumber)
    // {
    //     var phonenumberexist = await _clientRepository.PhoneNumberExistAsync(phoneNumber);
    //     if (!phonenumberexist) throw new Exception("Phone number already exist");
    //     
    //     var getclientbyphone = await _clientRepository.GetClientByPhoneNumberAsync(phoneNumber);
    //     return _mapper.Map<ClientDto>(getclientbyphone);
    // }

    public async Task<ClientDto> UpdateClientAsync(CreateClientDto createClientDto)
    {
        var existclientid = await _clientRepository.PassportNumberExistAsync(createClientDto.PassportNumber);
        if (existclientid) throw new Exception("Client doesn't exist");

        var updateclient = new Client()
        {
            ClientId = Guid.NewGuid(),
            //SurName = createClientDto.SurName,
            Name = createClientDto.Name,
            // FathersName = createClientDto.FathersName,
            // ClientStatus = "Standard",
            PassportNumber = createClientDto.PassportNumber,
            // IssuedDate = createClientDto.IssuedDate,
            // ExpiryDate = createClientDto.ExpiryDate,
            // PlaceOfBirth = createClientDto.PlaceOfBirth,
            // Address = createClientDto.Address,
            // Gender = createClientDto.Gender,
            // Nationality = createClientDto.Nationality,
            // Email = createClientDto.Email,
            // PhoneNumber = createClientDto.PhoneNumber,
            // IsActive = true,
            // UpdatedDate = DateTime.Now
        };
        
        await _clientRepository.UpdateAsync(updateclient);
        return _mapper.Map<ClientDto>(updateclient);
    }


    public async Task DeleteClientByIdAsync(Guid id)
    {
        var idexist = await _clientRepository.IdExistAsync(id);
        if (!idexist) throw new Exception("Client doesn't exist");

        await _clientRepository.DeleteClientByIdAsync(id);
    }
    

    // public async Task DeleteClientByEmailAsync(string email)
    // {
    //     var emailexist = await _clientRepository.EmailExistAsync(email);
    //     if(!emailexist) throw new Exception("Email already exist");
    //     
    //     await _clientRepository.DeleteClientByEmailAsync(email);
    // }
}