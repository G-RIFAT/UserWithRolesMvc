﻿namespace UserWithRolesMvc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
