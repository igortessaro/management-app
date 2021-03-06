﻿using Management.Domain.ValueObjects;

namespace Management.Domain.Dtos.User
{
    public class UserSystemDto : IDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public UserType UserType { get; set; }
    }
}
