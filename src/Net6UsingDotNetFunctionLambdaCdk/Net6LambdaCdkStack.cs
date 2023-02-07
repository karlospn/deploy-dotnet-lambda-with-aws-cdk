using Amazon.CDK;
using Constructs;
using XaasKit.CDK.AWS.Lambda.DotNet;

namespace Net6UsingDotNetFunctionLambdaCdk
{
    public class Net6LambdaCdkStack : Stack
    {
        internal Net6LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {
            _ = new DotNetFunction(this, 
                "my-net6-function", 
                new DotNetFunctionProps
            {
                ProjectDir = "../My.Net6.Lambda",
                Handler = "My.Net6.Lambda::My.Net6.Lambda.Function::FunctionHandler"
            });
        }
    }
}
