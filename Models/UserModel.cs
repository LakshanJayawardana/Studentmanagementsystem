﻿namespace Studentmanagementsystem.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public virtual StudentModel? Student { get; set; }
    }
}
