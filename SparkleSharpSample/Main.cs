using AppKit;

namespace SparkleSharpSample
{
    static class MainClass
    {
        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);
            var s = new EmptyClass();
        }
    }
}
