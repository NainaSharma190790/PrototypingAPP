using System;
namespace oPOP.Data.Logging
{
  public static class LogManager
  {
    public static void Log(Exception e)
    {
#if DEBUG
      Console.WriteLine("----- Exception -----");

      WriteException(e, 0);

      var innerException = e.InnerException;

      var count = 0;
      while(innerException != null){
        count++;
        WriteException(innerException, count);
        innerException = innerException.InnerException;
      }

      Console.WriteLine("---------------------");
#endif
    }

    private static void WriteException(Exception e, int depth)
    {
      string tab = string.Empty;
      int count = Math.Min(0, depth);
      while(count < depth)
      {
        tab += "\t";
		count++;
      }

      Console.WriteLine("{0}Exception: {1}", tab, e.ToString());
      Console.WriteLine("{0}Message: {1}", tab, e.Message);
      Console.WriteLine("{0}Source: {1}", tab, e.Source);
      Console.WriteLine("{0}Stack Trace: {1}", tab, e.StackTrace);
    }

    public static void Log(string message){
#if DEBUG
      Console.WriteLine(message);
#endif  
    }

    public static void Log(string format, params object[] inputs){
#if DEBUG
      Console.WriteLine(string.Format(format, inputs));
#endif
    }
  }
}

