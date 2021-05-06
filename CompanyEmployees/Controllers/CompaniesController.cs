using System;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        //private readonly ILoggerManager _logger;

        public CompaniesController(IRepositoryManager repositoryManager/*, ILoggerManager logger*/)
        {
            _repositoryManager = repositoryManager;
            //_logger = logger;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            var companies = _repositoryManager.Company.GetAllCompanies(trackChanges: false);
            return Ok(companies);
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action {ex}");
            //    return StatusCode(500, "Internal server error");
            //    throw;
            //}
        }
    }
}