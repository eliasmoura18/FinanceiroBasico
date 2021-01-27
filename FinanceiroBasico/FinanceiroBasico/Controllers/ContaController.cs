using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceiroBasico.Model;
using FinanceiroBasico.Business;
using FinanceiroBasico.Business.Implementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FinanceiroBasico.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ContaController : ControllerBase
    {
        private readonly ILogger<ContaController> _logger;
        private IContaBusiness _contaBusiness;

        public ContaController(ILogger<ContaController> logger, IContaBusiness contaBusiness)
        {
            _logger = logger;
            _contaBusiness = contaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_contaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var conta = _contaBusiness.FindById(id);

            if (conta == null)
                return NotFound();

            return Ok(conta);
        }

        [HttpPost("{id}")]
        public IActionResult Post([FromBody] Conta conta)
        {
            if (conta == null)
                return BadRequest();

            return Ok(_contaBusiness.Create(conta));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Conta conta)
        {
            if (conta == null)
                return BadRequest();

            return Ok(_contaBusiness.Update(conta));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contaBusiness.Delete(id);
            return NoContent();
        }

    }
}
