using Amazon.CDK;

namespace Net5ExistingContainerLambdaCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

            new Net5LambdaCdkStack(app, "Net5ExistingContainerLambdaCdkStack", new StackProps
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
