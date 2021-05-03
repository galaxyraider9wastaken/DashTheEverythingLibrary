using System;

namespace Dash{
  public class Vector {
    public static Vector2 AddVec2(Vector2 V1, Vector2, V2){
      var VecA = new Vector2(0, 0)
      V1.X +=V2.X;
    }
  }
}
namespace Dash{
  public class Vector2 {
    public float X;
    public float Y;
    public Vector2(float x, float y){
      X = x;
      Y = y;
    }
  }
}
namespace Dash{
  public class Vector3 {
    public float X;
    public float Y;
    public float Z;
    public Vector3(float x, float y, float z){
      X = x;
      Y = y;
      Z = z;
    }
  }
}
namespace Dash{
  public class Vector4 {
    public float X;
    public float Y;
    public float Z;
    public float W;
    public Vector4(float x, float y, float w){
      X = x;
      Y = y;
      Z = z;
      W = w;
    }
  }
}
