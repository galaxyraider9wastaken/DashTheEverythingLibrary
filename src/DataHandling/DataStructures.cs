using System;

namespace Dash {
  public class DataStructure {
    public static Object[] Data;
    public static int AddedData;
    public static int MaxData;
    public static void CreateDataStructure(int maxdata){
      MaxData = maxdata;
      Data = new Object[MaxData];
      
    }
    public static void AddData(Object Data2Add)
      if(AddedData < MaxData){
        Data[AddedData] = Data2Add;
        AddedData += 1;
      }
    }
    public static bool CompareData(Object Data1, Object Data2){
      if(Data1 == Data2){
        return true;
      } else {
        return false;
      }
    }
  }
}
