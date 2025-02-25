using System;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
  void Commit();
  Task CommitAsync();

}
