using UserWithRolesMvc.Models;

namespace UserWithRolesMvc.ViewModels
{
    public class UserListViewModel
    {
        public IEnumerable<User> Users { get; set; } = new List<User>();
        public string SelectedRole { get; set; }=string.Empty;
        public List<string> Roles { get; set; } = new List<string> { "Admin", "Manager", "Salesman" };
    }

}
