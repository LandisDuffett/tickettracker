using System;
namespace TicketTracker.Models
{
  class Ticket
  {
    public string Title { get; private set; }
    private string Description { get; set; }
    public void PrintDescription()
    {
      Console.WriteLine(Description);
    }

    public Ticket(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}