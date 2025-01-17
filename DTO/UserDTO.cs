﻿using System.ComponentModel.DataAnnotations;

namespace FinanceWebApi.DTO
{
    public class UserDTO
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int RoleId { get; set; }
    }
}
