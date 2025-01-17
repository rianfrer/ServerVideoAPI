using Microsoft.AspNetCore.Mvc;
using ServerVideoAPI.Dtos;
using ServerVideoAPI.Entity;
using ServerVideoAPI.Infra;

namespace ServerVideoAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly AppDbContext _context;
        private IEnumerable<Video> retarn;

        public ServerController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(200), ProducesResponseType(400), ProducesResponseType(404), ProducesResponseType(500)]
        public async Task<IActionResult> InserServer([FromBody] ServerDTO request)
        {
            try
            {

                // Adicionando a entidade Server no contexto
                _context.Servers.Add(request);
                await _context.SaveChangesAsync();

                return Ok();

            }
            catch (Exception ex)
            {
                // Em caso de erro, retorna BadRequest
                return BadRequest($"Erro ao criar servidor: {ex.Message}");
            }
        }


        [HttpPost]
        [Route("video")]
        public async Task<IActionResult> InserVideo([FromBody] VideoDTO request)
        {
            try
            {

                _context.Videos.Add(request);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception)
            {
                // Em caso de erro, retorna throw
                throw;
            }
        }

        [HttpGet]
        [Route("video")]
        public async Task<IActionResult> ListarVideoporServer(int serverid)
        { 
           IEnumerable<Video> result = _context.Videos.Where(x=>x.ServerId == serverid).ToList();

            List<ServerResponse> Listadevideo = new List<ServerResponse>();
            foreach (var item in result)
            {
                ServerResponse response = new ServerResponse();
                response.Id = item.ServerId;
                response.FileName = item.FileName;
                response.UploadDate = item.UploadDate;

                Listadevideo.Add(response);

            }

            return Ok(Listadevideo);
        }

    }
}
