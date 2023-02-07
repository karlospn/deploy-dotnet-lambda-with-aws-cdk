using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace Net7BundlingContainerLambdaCdk
{
    public class Net7LambdaCdkStack : Stack
    {
        internal Net7LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {
            DockerImageCode dockerImageCode = DockerImageCode.FromImageAsset("../My.Net7.Lambda");

            _  = new DockerImageFunction(this, 
                "container-image-lambda-function",
                new DockerImageFunctionProps()
            {
                Code = dockerImageCode,
                Description = ".NET 7 Docker Lambda function"
            });
        }
    }
}
