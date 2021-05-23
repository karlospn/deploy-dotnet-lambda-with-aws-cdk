using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;

namespace NetCore31ExistingZipFileLambdaCdk
{
    public class NetCore31LambdaCdkStack : Stack
    {
        internal NetCore31LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {

            Function function = new Function(this,
                "zip-lambda-function",
                new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Code = Code.FromAsset("./src/My.NetCore31.Lambda.zip"),
                Handler = "My.NetCore31.Lambda::My.NetCore31.Lambda.Function::FunctionHandler"

            });
        }
    }
}
