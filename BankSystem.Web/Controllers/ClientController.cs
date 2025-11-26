using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Application.IService;
using BankSystem.Web.RequestModels;
using BankSystem.Web.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Web.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;
    
    public ClientController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }
    
    
    
    [HttpPost]
    public async Task<ActionResult<ResponseCreateClient>> CreateClient(RequestCreateClient createClientrequest)
    {
        var map = _mapper.Map<CreateClientDto>(createClientrequest);
        var createclient = await _clientService.RegisterClientAsync(map);
        return Ok(_mapper.Map<ResponseCreateClient>(createclient));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ResponseCreateClient>> GetClientById([FromRoute] Guid id)
    {
        var getclientbyid = await _clientService.GetClientByIdAsync(id);
        return Ok(_mapper.Map<ResponseCreateClient>(getclientbyid));
    }

    [HttpPut]
    public async Task<ActionResult<ResponseCreateClient>> UpdateClient(Guid clientId, string newName)
    {
        var updateClient = await _clientService.UpdateClientAsync(clientId, newName);
        return Ok(_mapper.Map<ResponseCreateClient>(updateClient));
    }

    [HttpGet(Name = "GetAllClients")]
    public async Task<ActionResult<IEnumerable<ResponseCreateClient>>> GetAllClients()
    {
        var clients = await _clientService.GetAllClientsAsync();
        return Ok(_mapper.Map<IEnumerable<ResponseCreateClient>>(clients));
    }


}