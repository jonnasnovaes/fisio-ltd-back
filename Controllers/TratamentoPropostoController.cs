using Microsoft.AspNetCore.Mvc;
using fisio_ltd_back.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace fisio_ltd_back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TratamentoPropostoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TratamentoPropostoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTratamentoProposto(TratamentoProposto tratamento)
        {
            try
            {
                // Salvando no banco de dados
                _context.TratamentoProposto.Add(tratamento);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(CreateTratamentoProposto), new { id = tratamento.Id }, tratamento);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, "Erro ao salvar no banco de dados: " + ex.Message);
            }
        }

        // [HttpGet]
        // public async Task<IActionResult> GetTratamentoProposto()
        // {
        //     try
        //     {
        //         var tratamento = await _context.TratamentoProposto.Include(e => e.DadosBasicos).ToListAsync();
        //         return Ok(tratamento);
        //     }
        //     catch (DbUpdateException ex)
        //     {
        //         return StatusCode(500, "Erro ao recuperar dados do banco de dados: " + ex.Message);
        //     }
        // }
    }
}
