using Microsoft.AspNetCore.Mvc;
using UserWithRolesMvc.Services.Interfaces;
using UserWithRolesMvc.ViewModels;

namespace UserWithRolesMvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index(string role)
        {
            var users = await _userService.GetUsersAsync(role);
            var vm = new UserListViewModel
            {
                Users = users,
                SelectedRole = role
            };
            return View(vm);
        }
    }
}
