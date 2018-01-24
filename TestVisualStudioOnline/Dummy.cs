using System.Diagnostics;

namespace TestVisualStudioOnline
{
    public class Dummy
    {
        public Dummy()
        {
            Debug.WriteLine("Test code");
        }

        public string Hello(string input)
        {
            return $"Hello {input}";
        }
    }
}
