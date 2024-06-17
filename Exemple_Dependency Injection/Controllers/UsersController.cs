using Exemple_Dependency_Injection.IRepo__Interfaces_;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exemple_Dependency_Injection.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IRepoUsers repoUsers;

		public UsersController(IRepoUsers repoUsers)
		{
			this.repoUsers = repoUsers;
		}
		[HttpGet ("GetAllUsers")]
		public IActionResult GetAllUser()
		{
			return Ok(repoUsers.GetUsers());
		}
		[HttpGet("GetUserById")]
		public IActionResult GetUserById([FromHeader] int id)
		{
			return Ok(repoUsers.GetUsers().FirstOrDefault(x=> x.Id== id));
		}
	}
}
