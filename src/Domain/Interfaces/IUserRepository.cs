using System;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository:IGenericRepository<User>
{
Task<User?> GetUserByEmailAsync(string email);
Task<List<string>> GetUserRoleByEmailAsync( string email);
}
