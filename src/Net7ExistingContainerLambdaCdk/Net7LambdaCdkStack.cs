using Amazon.CDK;
using Amazon.CDK.AWS.ECR;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace Net7ExistingContainerLambdaCdk
{
    public class Net7LambdaCdkStack : Stack
    {
        internal Net7LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {

            var ecrRepo = Repository.FromRepositoryName(this, 
                "ecr-image-repository", 
                "net7.container.lambda");

            DockerImageCode dockerImageCode = DockerImageCode.FromEcr(ecrRepo);
            
            _ = new DockerImageFunction(this, 
                "container-image-lambda-function", 
                new DockerImageFunctionProps()
            {
                Code = dockerImageCode,
                Description = ".NET 7 Docker Lambda function"
            });
        }
    }
}
