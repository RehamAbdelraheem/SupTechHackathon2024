﻿using Microsoft.AspNetCore.Mvc;
using SupTechHackathon2024.Services.Interfaces;
using System.Data;

namespace SupTechHackathon2024.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : Controller
{

    private readonly ICallService _CBECustumerSupportService;
    public CustomerController(ICallService CBECustumerSupportService)
    {
        _CBECustumerSupportService = CBECustumerSupportService;
    }

    /// <summary>
    ///       Get CBE Custumer Reports
    /// </summary>
    /// <returns>array of CBE Custumer report </returns>
    ///<response code="200">return CBE Custumer report  successfully</response>
    [HttpGet]
    [Route("CBECustomerReports")]  
    public async Task<IActionResult> GetCallReport()
    {
        var Data = await _CBECustumerSupportService.GetCallReport();
        return Ok(new { results = Data });
    }

}