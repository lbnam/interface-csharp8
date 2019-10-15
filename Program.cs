using System;

namespace interface_csharp8
{
    public interface ICallable
    {
        string GetPlatform();
        void Call()
        {
            Console.WriteLine("Calling..");
        }
    }

    interface IAndroidCallable: ICallable
    {
        void Call()
        {
            Console.WriteLine("Calling from AndroidCallable");
        }
    }

    interface IiPhoneCallable: ICallable
    {
        void Call()
        {
            Console.WriteLine("Calling from iPhoneCallable");
        }
    }

    public class Android : IAndroidCallable
    {
        public string GetPlatform()
        {
            return "Android";
        }
    }

    public class Ios : IiPhoneCallable
    {
        public string GetPlatform()
        {
            return "IOS";
        }

        public void Call()
        {
           Console.WriteLine("Calling IOS");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICallable phone = new Android();
            phone.Call();

            (phone as IAndroidCallable).Call();
            (phone as ICallable).Call();
            
            phone = new Ios();
            phone.Call();

            (phone as IiPhoneCallable).Call();
            (phone as ICallable).Call();    
        }
    }
}
