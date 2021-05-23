using Amazon.CDK;

namespace NetCore31BundlingZipFileLambdaCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

            new NetCore31LambdaCdkStack(app, "NetCore31BundlingZipFileLambdaCdk", new StackProps
            {
                Env = new Amazon.CDK.Environment
                {
                    Account = System.Environment.GetEnvironmentVariable("CDK_AWS_ACCOUNT"),
                    Region = System.Environment.GetEnvironmentVariable("CDK_AWS_REGION")
                }
            });

            app.Synth();
        }
    }
}
