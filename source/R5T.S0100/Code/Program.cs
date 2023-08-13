using System;
using System.Threading.Tasks;


namespace R5T.S0100
{
    class Program
    {
        static async Task Main()
        {
            //await Demonstrations.Instance.In_SampleProjectFileContext();
            await Demonstrations.Instance.Create_SampleRazorClassLibraryProjectFile();
        }
    }
}