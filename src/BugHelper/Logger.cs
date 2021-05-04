using System;
using System.Diagnostics;

namespace Dash{
  public class Logger {
    public string Directory;
    public Stopwatch ElapsedTime;
    public Log(string directory){
      Directory = directory;
    }
    public void LoggerStartTime(){
      ElapsedTime = new Stopwatch();
      Stopwatch.Start();
    }
    public void Log(string FileFrom, string Log){
      var Et = ElapesedTime.Elapsed;
      using (StreamWriter writer = new StreamWriter(fullPath))  
      {  
        writer.WriteLine(Et.Hours + " : " + Et.Minutes + " : " + Et.Seconds);
      }  
    }
  }
}
