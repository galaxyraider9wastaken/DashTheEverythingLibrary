using System;
using System.Diagnostics;

namespace Dash{
  public class Logger {
    public string Directory;
    public Stopwatch ElapsedTime;
    public Log(string directory){
      Directory = directory;
    }
    public void LoggerStart(){
      ElapsedTime = new Stopwatch();
      Stopwatch.Start();
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine(|| + " Log started " + ||);
      }  
    }
    public void Log(string FileFrom, int Line, string Log){
      var Et = ElapesedTime.Elapsed;
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine(Et.Hours + " : " + Et.Minutes + " : " + Et.Seconds + " || " + FileFrom + " | " + Line + " || " + Log);
      }  
    }
    public void LoggerEnd(){
      Stopwatch.End();
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine(|| + " Log Ended " + || + " { Elapsed Time } " + Et.Hours + " : " + Et.Minutes + " : " + Et.Seconds);
      }  
    }
  }
}
