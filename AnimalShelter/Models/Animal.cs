using System;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public string Name { get; set; }

    public DateTime ArrivalDate { get; set; } 

  }
}