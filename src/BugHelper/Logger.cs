using System;
using System.Diagnostics;
using System.IO;

namespace Dash{
  public class Logger {
    public string Directory;
    public Stopwatch ElapsedTime = new Stopwatch();
    public Logger(string directory){
      Directory = directory;
    }
    public void LoggerStart(){
      ElapsedTime.Start();
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine("<|" + " Log started " + "|>");
      }  
    }
    public void Log(string FileFrom, int Line, string LogMsg){
      var Et = ElapsedTime.Elapsed;
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine(Et.Hours + " : " + Et.Minutes + " : " + Et.Seconds + " <|> " + FileFrom + " |^| " + Line + " <|> " + LogMsg);
      }  
    }
    public void LoggerEnd(){
      ElapsedTime.Stop();
      var Et = ElapsedTime.Elapsed;
      using (StreamWriter writer = new StreamWriter(Directory, true))  
      {  
        writer.WriteLine("<|" + " Log Ended " + "|>" + " { Elapsed Time } " + Et.Hours + " : " + Et.Minutes + " : " + Et.Seconds);
      }  
    }
  }
}
