using System;

namespace HackerNews.Models
{
  public class Article
  {
    public int Id { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }
    public DateTime DateSubmitted { get; set; } = DateTime.Now;

    // navigation property
    public int UserId { get; set; }
    public User User { get; set; }

  }
}