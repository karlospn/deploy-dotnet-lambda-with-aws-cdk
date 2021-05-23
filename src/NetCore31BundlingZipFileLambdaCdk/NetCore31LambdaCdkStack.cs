using System.Collections.Generic;
using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using AssetOptions = Amazon.CDK.AWS.S3.Assets.AssetOptions;

namespace NetCore31BundlingZipFileLambdaCdk
{
    public class NetCore31LambdaCdkStack : Stack
    {
        internal NetCore31LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {
            IEnumerable<string?> commands = new[]
            {
                "cd /asset-input",
                "export DOTNET_CLI_HOME=\"/tmp/DOTNET_CLI_HOME\"",
                "export PATH=\"$PATH:/tmp/DOTNET_CLI_HOME/.dotnet/tools\"",
                "dotnet tool install -g Amazon.Lambda.Tools",
                "dotnet lambda package -o output.zip",
                "unzip -o -d /asset-output output.zip"
            };


            Function function = new Function(this,
                "zip--lambda-function",
                new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("../My.NetCore31.Lambda", new AssetOptions
                {
                    Bundling = new BundlingOptions
                    {
                      Image  = Runtime.DOTNET_CORE_3_1.BundlingImage,
                      Command = new []
                      {
                          "bash", "-c", string.Join(" && ", commands)
                      }
                    }
                }),
                Handler = "My.NetCore31.Lambda::My.NetCore31.Lambda.Function::FunctionHandler"

            });
        }

    }
}
