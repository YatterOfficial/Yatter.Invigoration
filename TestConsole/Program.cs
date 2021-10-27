using System;
using System.Threading.Tasks;
using TestConsole.Helpers;

namespace TestConsole
{
    public class TOCreateUserApplication : Yatter.Invigoration.ObjectBase
    {
        public string DataType { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string MobileCountryCode { get; set; }
        public string MobileNumber { get; set; }

        public TOCreateUserApplication()
        {
            DataType = "TOCreateUserApplication";
        }
    }

    public class TACreateUserName : Yatter.Invigoration.ActionBase
    {
        public TOCreateUserApplication TOCreateUserApplication
        {
            get
            {
                Console.WriteLine($"XXXq {((TOCreateUserApplication)base.Object).FirstName}");
                return (TOCreateUserApplication)base.Object;
            }
        }

        public TACreateUserName() { }

        public void AddTOCreateUserApplication(TOCreateUserApplication application)
        {
            Console.WriteLine("|" + application.FirstName);
            base.Object = application;
            Console.WriteLine("|" + application.FirstName);
        }

        public async override Task ActionAsync()
        {
            Console.WriteLine("Starting ActionAsync()");
            if (TOCreateUserApplication == null)
            {
                IsSuccess = false;
                Message = "TACreateUserName has identified that the TOCreateUserApplication is null";
                Console.WriteLine(Message);
            }
            else
            {
                /*
                base.Object = new TOCreateUserApplication
                {
                    FirstName = "Anthony",
                    LastName = "Harrison",
                    EmailAddress = "a@elspic.com",
                    Password = "1234",
                    UserName = "chatter",
                    MobileCountryCode = "United Kingdom +44",
                    MobileNumber = "07885421140"
                };
                */

                Console.WriteLine("||" + TOCreateUserApplication.FirstName);
                Console.WriteLine("Test");
            }
        }

        public override void Dispose()
        {
            if (base.Object != null)
            {
                ((TOCreateUserApplication)base.Object).Dispose();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var toCreateUserApplication = new TOCreateUserApplication
            {
                FirstName = "Anthony",
                LastName = "Harrison",
                EmailAddress = "a@elspic.com",
                Password = "1234",
                UserName = "chatter",
                MobileCountryCode = "United Kingdom +44",
                MobileNumber = "07885421140"
            };

            Console.WriteLine(StringHelpers.SerializeBase64Encode(toCreateUserApplication));

            Init(toCreateUserApplication);

            Console.ReadKey();
        }

        private static async Task Init(TOCreateUserApplication toCreateUserApplication)
        {
            using (TACreateUserName taCreateUserName = new TACreateUserName())
            {
                taCreateUserName.AddTOCreateUserApplication(toCreateUserApplication);
                Console.WriteLine("Invigorating <TOCreateUserApplication,TACreateUserName>");
                TACreateUserName acted = await Yatter.Invigoration.Invigorator.ActAsync<TOCreateUserApplication, TACreateUserName>(taCreateUserName);

                Console.WriteLine($"Finished: {acted.TOCreateUserApplication.FirstName}");
            }

            Console.ReadKey();
        }
    }
}
