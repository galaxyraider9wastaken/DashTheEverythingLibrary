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
    public static void AddData(object Data2Add)
      if(AddedData < MaxData){
        Data[AddedData] = Data2Add;
        AddedData += 1;
      }
    }
  }
}
