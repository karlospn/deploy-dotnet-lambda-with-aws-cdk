using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;

namespace Net5BundlingContainerLambdaCdk
{
    public class Net5LambdaCdkStack : Stack
    {
        internal Net5LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {
            DockerImageCode dockerImageCode = DockerImageCode.FromImageAsset("../My.Net5.Lambda");

            DockerImageFunction dockerImageFunction = new DockerImageFunction(this, 
                "container-image-lambda-function",
                new DockerImageFunctionProps()
            {
                Code = dockerImageCode,
                Description = ".NET 5 Docker Lambda function",
                
            });
        }
    }
}
