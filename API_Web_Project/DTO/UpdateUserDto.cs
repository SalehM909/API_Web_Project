﻿namespace API_Web_Project.DTO
{
    public class UpdateUserDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Role { get; set; }
    }
}