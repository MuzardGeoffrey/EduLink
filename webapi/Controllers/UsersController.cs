namespace webapi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using webapi.Business;
    using webapi.IBusiness;
    using webapi.Object;

    public class UsersController : Controller
    {
        private readonly IUserBusiness userBusiness;

        public UsersController(UserBusiness userBusiness)
        {
            this.userBusiness = userBusiness;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return Ok(await userBusiness.List());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var user = await this.userBusiness.Details(id);
            return user == null ? NotFound() : Ok(user);
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Email,Password,Pseudo,CreatedDate,LastUpdateDate")] User user)
        {
            if (ModelState.IsValid)
            {
                user = await this.userBusiness.CreateOrUpdate(user);
                return Ok(user);
            }
            return NoContent();
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("Id,FirstName,LastName,Email,Password,Pseudo,CreatedDate,LastUpdateDate")] User user)
        {
            if (!ModelState.IsValid)
            {
                user = await this.userBusiness.CreateOrUpdate(user);
                return user == null ? NotFound(user) : Ok(user);
            }
            return NotFound(user);
        }

        // POST: Users/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            bool confirm = await this.userBusiness.Delete(id);
            return confirm ? Ok() : NotFound();
        }

        // POST: Users/Verify
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Password")] User user)
        {
            var IsAutenticate = await this.userBusiness.Login(user.Email, user.Password);
            return IsAutenticate ? NotFound() : Ok();
        }
    }
}