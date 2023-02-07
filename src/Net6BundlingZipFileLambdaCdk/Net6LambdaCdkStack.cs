using System.Collections.Generic;
using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;
using AssetOptions = Amazon.CDK.AWS.S3.Assets.AssetOptions;

namespace Net6BundlingZipFileLambdaCdk
{
    public class Net6LambdaCdkStack : Stack
    {
        internal Net6LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {
            IEnumerable<string> commands = new[]
            {
                "cd /asset-input",
                "export XDG_DATA_HOME=\"/tmp/DOTNET_CLI_HOME\"",
                "export DOTNET_CLI_HOME=\"/tmp/DOTNET_CLI_HOME\"",
                "export PATH=\"$PATH:/tmp/DOTNET_CLI_HOME/.dotnet/tools\"",
                "dotnet tool install -g Amazon.Lambda.Tools",
                "dotnet lambda package -o output.zip",
                "unzip -o -d /asset-output output.zip"
            };


            _ = new Function(this,
                "zip-lambda-function",
                new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                Code = Code.FromAsset("../My.Net6.Lambda", new AssetOptions
                {
                    Bundling = new BundlingOptions
                    {
                      Image  = Runtime.DOTNET_6.BundlingImage,
                      Command = new []
                      {
                          "bash", "-c", string.Join(" && ", commands)
                      }
                    }
                }),
                Handler = "My.Net6.Lambda::My.Net6.Lambda.Function::FunctionHandler"

            });
        }

    }
}
