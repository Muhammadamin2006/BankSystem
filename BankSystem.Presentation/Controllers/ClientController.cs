using AutoMapper;
using BankSystem.Application.Dtos;
using BankSystem.Application.IService;
using BankSystem.Web.RequestModels;
using BankSystem.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Web.Controllers;

public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;
    
    public ClientController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }


    [HttpPost("{createClientrequest}")]
    public async Task<ActionResult<ResponseCreateClient>> CreateClient(RequestCreateClient createClientrequest)
    {
        var map = _mapper.Map<CreateClientDto>(createClientrequest);
        var createclient = await _clientService.RegisterClientAsync(map);
        return Ok(_mapper.Map<ResponseCreateClient>(createclient));
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<ResponseCreateClient>> GetClientById(Guid id)
    {
        var getclientbyid = await _clientService.GetClientByIdAsync(id);
        return Ok(_mapper.Map<ResponseCreateClient>(getclientbyid));
    }
    
}