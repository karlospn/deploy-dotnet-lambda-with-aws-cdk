using Amazon.CDK;

namespace Net5BundlingContainerLambdaCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

            new Net5LambdaCdkStack(app, "Net5BundlingContainerLambdaCdk", new StackProps
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
