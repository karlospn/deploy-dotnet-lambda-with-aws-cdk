using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace Net6ExistingZipFileLambdaCdk
{
    public class Net6LambdaCdkStack : Stack
    {
        internal Net6LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {

            Function function = new Function(this,
                "zip-lambda-function",
                new FunctionProps
            {
                Runtime = Runtime.DOTNET_6,
                Code = Code.FromAsset("./src/My.Net6.Lambda.zip"),
                Handler = "My.Net6.Lambda::My.Net6.Lambda.Function::FunctionHandler"

            });
        }
    }
}
