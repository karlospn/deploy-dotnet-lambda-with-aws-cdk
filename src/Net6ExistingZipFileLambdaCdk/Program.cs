﻿using Amazon.CDK;

namespace Net6ExistingZipFileLambdaCdk
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();

            new Net6LambdaCdkStack(app, "Net6ExistingZipFileLambdaCdk", new StackProps
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
