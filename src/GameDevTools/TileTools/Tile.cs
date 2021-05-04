  
using System;
namespace Dash{
  public class Tile {
    public int Id;
    public bool Collidable;
    public Tile(int id, bool collidable){
      Id = id;
      Collidable = collidable;
    }
  }
}
