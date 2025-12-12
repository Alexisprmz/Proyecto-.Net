using Microsoft.AspNetCore.Mvc;
using Distribuidos.Api.Models.Pipedream;
using Distribuidos.Api.Services.Pipedream;

namespace MyApp.Namespace // ayuda a organización lógica del código
{
    [Route("api/pipedream")]
    [ApiController]
    public class PipedreamController : ControllerBase
    {
        private readonly IPipedreamService _pipedreamService;

        public PipedreamController(IPipedreamService pipedreamService)
        {
            // Inicialización
            _pipedreamService = pipedreamService;
        }

        [HttpPost("welcome")]
        public async Task<IActionResult> WelcomeEmail([FromBody] WelcomeModel body)
        {
            try
            {
                bool res = await _pipedreamService.SendWelcome(body);

                return Ok(new
                {
                    error = false,
                    msj = res
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    msj = ex.Message
                });
            }
        }

        [HttpPost("sendcode")]

        public async Task<IActionResult> SendCode([FromBody] WelcomeModel body)
        {
            try
            {
                bool res = await _pipedreamService.SendCode(body);

                return Ok(new
                {
                    error = false,
                    msj = res
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    msj = ex.Message
                });
            }
        }

        [HttpPost("checkcode")]
        public async Task<IActionResult> CheckCode([FromBody] CheckModel body)
        {
            try
            {
                bool res = await _pipedreamService.CheckCode(body);

                return Ok(new
                {
                    error = false,
                    msj = res
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    error = true,
                    msj = ex.Message
                });
            }

        }

    }    
}
