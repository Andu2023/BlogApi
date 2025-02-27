using System;

namespace Domain.Entities;

public class Blog
{

public int Id { get; set;}
  public required string Title { get; set;}
  public required string Content { get; set;}
 
  public required string Image { get; set;}
 public DateTime CreatedAt { get; set; }= DateTime.UtcNow;
  public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
  public List<Comment> Comments{ get; set; } =[];
  public int UserId { get; set; }
  public User? User{ get; set; }
}
