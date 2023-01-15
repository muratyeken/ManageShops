using ManageShops.Application.Models.DTOs;
using ManageShops.Application.Models.VMs;
using ManageShops.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManageShops.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenagerControllerAPI : ControllerBase
    {
        private readonly IAdminService _adminService;

        public MenagerControllerAPI(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet("GetManagers")]
        public async Task<ActionResult<List<ManagersListVM>>> GetAllManagers()
        {
            var managers = await _adminService.GetManagers();
            if (managers == null)
            {
                return NotFound();
            }
            return Ok(managers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UpdateMenagerDTO>> GetManager([FromRoute] Guid id)
        {
            var manager = await _adminService.GetManager(id);
            if (manager == null)
            {
                return NotFound();
            }
            return Ok(manager);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UpdateMenagerDTO>> DeleteManager([FromRoute] Guid id)
        {
            await _adminService.DeleteManager(id);
            return Ok();
        }

        [HttpPost("PostManager")]
        public async Task<ActionResult> CreateManager(IFormFile images, [FromBody] AddManagerDTO addManagerDTO)
        {
            addManagerDTO.UploadPath = images;
            if (ModelState.IsValid)
            {
                try
                {
                    await _adminService.CreateManager(addManagerDTO);
                }

                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return Ok(addManagerDTO);
        }
    }
}
