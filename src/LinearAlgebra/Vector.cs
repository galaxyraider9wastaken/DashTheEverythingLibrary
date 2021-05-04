using System;

namespace Dash{
  public class Vector {
    public static Vector2 AddVec2(Vector2 V1, Vector2 V2){
      var VecA = new Vector2(0, 0)
      VecA.X = V1.X +=V2.X;
      VecA.Y = V1.Y +=V2.Y;
      return VecA;
    }
    public static Vector3 AddVec3(Vector3 V1, Vector3 V2){
      var VecA = new Vector3(0, 0, 0)
      VecA.X = V1.X +=V2.X;
      VecA.Y = V1.Y +=V2.Y;
      VecA.Z = V1.Z +=V2.Z;
      return VecA;
    }
    public static Vector4 AddVec4(Vector4 V1, Vector4 V2){
      var VecA = new Vector4(0, 0, 0, 0)
      VecA.X = V1.X +=V2.X;
      VecA.Y = V1.Y +=V2.Y;
      VecA.Z = V1.Z +=V2.Z;
      VecA.W = V1.Z +=V2.W;
      return VecA;
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
