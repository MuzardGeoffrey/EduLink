namespace webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using webapi.IBusiness;
    using webapi.Object;

    [Route("[controller]")]
    public class UserController(IUserBusiness userBusiness) : Controller
    {
        private readonly IUserBusiness _userBusiness = userBusiness;

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            Console.WriteLine("List");
            return Ok(await _userBusiness.List());
        }

        // GET: User/Details/5
        [HttpGet("detail/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var user = await this._userBusiness.Details(id);
            return user == null ? NotFound() : Ok(user);
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody][Bind("Email,Password")] User user)
        {
            if (user != null)
            {
                user = await this._userBusiness.Create(user);
                return Ok(user);
            }
            return NoContent();
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut("edit/{id}")]
        public async Task<IActionResult> Edit([FromBody][Bind("Id,FirstName,LastName,Email,Password,Pseudo,CreatedDate,LastUpdateDate")] User user)
        {
            if (!ModelState.IsValid)
            {
                user = await this._userBusiness.CreateOrUpdate(user);
                return user == null ? NotFound(user) : Ok(user);
            }
            return NotFound(user);
        }

        // POST: User/Delete/5
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool confirm = await this._userBusiness.Delete(id);
            return confirm ? Ok() : NotFound();
        }

        // POST: User/Verify
        [HttpPost("verify")]
        public async Task<IActionResult> Login([FromBody][Bind("Email,Password")] User user)
        {
            var IsAutenticate = await this._userBusiness.Login(user.Email, user.Password);
            return IsAutenticate ? Ok(true): Unauthorized();
        }
    }
}