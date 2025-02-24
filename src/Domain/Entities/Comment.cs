using System;

namespace Domain.Entities;

public class Comment
{
public int Id { get; set;}
  public required string Content { get; set;}
  public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
  public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
    public int UserId { get; set; }
  public User User{ get; set; }
    public int BlogId { get; set; }
  public Blog Blog{ get; set; }
}
