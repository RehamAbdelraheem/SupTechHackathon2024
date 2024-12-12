using Microsoft.AspNetCore.Mvc;
using SupTechHackathon2024.EFCore.DTOs;
using SupTechHackathon2024.Services.Interfaces;
using System.Collections.Generic;
using System.Data;

namespace SupTechHackathon2024.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : Controller
{

    private readonly ICallService _cbeCustumerSupportService;
    private readonly ICbeCustomerService _cbeCustomerService;

    public CustomerController(ICallService CBECustumerSupportService, ICbeCustomerService cbeCustomerService)
    {
        _cbeCustumerSupportService = CBECustumerSupportService;
        _cbeCustomerService = cbeCustomerService;
    }

    /// <summary>
    ///       Get call for AI analysis
    /// </summary>
    /// <returns>A single call with relevant customer data</returns>
    ///<response code="200">Return SingleCallDto successfully</response>
    [HttpGet]
    [Route("GetCallForAiAnalysis")]
    public async Task<IActionResult> GetCallForAiAnalysis()
    {
        var data = await _cbeCustumerSupportService.GetCallForAiAnalysis();
        return Ok(new { results = data });
    }

    /// <summary>
    ///       Get all calls of a single year for AI analysis
    /// </summary>
    /// <returns>An object with a list of categories and financial services/ products along with all the calls of the specified year</returns>
    ///<response code="200">return CBE Custumer report  successfully</response>
    [HttpGet]
    [Route("GetCallsByYear")]
    public async Task<IActionResult> GetCallsByYear([FromQuery] short year)
    {
        var data = await _cbeCustumerSupportService.GetCallsByYear(year);
        return Ok(new { results = data });
    }
    /// <summary>
    ///      Update Call Analysis
    /// </summary>
    /// <returns> updated status </returns>
    ///<response code="200">return update call successfully</response>
    ///<response code="400">return No Call found for this  key</response>
    [HttpPost]
    [Route("UpdateCallAnalysis")]
    public async Task<IActionResult> UpdateCallAnalysis([FromBody] CallAnalysisDto callAnalysis)
    {


        var data = await _cbeCustumerSupportService.UpdateCallAnalysis(callAnalysis);
        if (data == true)
        {
            return Ok("Call Updated successfully.");

        }
        else
        {
            return BadRequest("No Call found for this  key !");

        }
    }
    /// <summary>
    /// Add Customers Year Financial Report
    /// </summary>
    /// <returns>boolean state </returns>
    ///<response code="200">return addind data    successfully</response>
    ///<response code="400">return No  data hasbeen added</response>
    [HttpPost]
    [Route("AddCustomersYearFinancialReport")]
    public async Task<IActionResult> AddCustomersYearFinancialReport(int bankId, short year, List<CustomerYearFinancialReportDto> CustomerYearFinancialReport)
    {
        var data = await _cbeCustomerService.AddCustomercYearFinancialReport(bankId, year, CustomerYearFinancialReport);
        if (data == true)
        {
            return Ok("Call Updated successfully.");

        }
        else
        {
            return BadRequest("No  data hasbeen added !");

        }
    }

}
