using Business.Concrete;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            NetStatManager netStatManager = new NetStatManager();
            string result = netStatManager.GetPortAndIP();
            netStatManager.SetJsonFile(result);

        }
    }
}
