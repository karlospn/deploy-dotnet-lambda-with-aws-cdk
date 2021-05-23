using Amazon.CDK;
using Amazon.CDK.AWS.ECR;
using Amazon.CDK.AWS.Lambda;

namespace Net5ExistingContainerLambdaCdk
{
    public class Net5LambdaCdkStack : Stack
    {
        internal Net5LambdaCdkStack(Construct scope, 
            string id,
            IStackProps props = null) : base(scope, id, props)
        {

            var ecrRepo = Repository.FromRepositoryName(this, 
                "ecr-image-repository", 
                "net5.container.lambda");

            DockerImageCode dockerImageCode = DockerImageCode.FromEcr(ecrRepo);
            
            DockerImageFunction dockerImageFunction = new DockerImageFunction(this, 
                "container-image-lambda-function", 
                new DockerImageFunctionProps()
            {
                Code = dockerImageCode,
                Description = ".NET 5 Docker Lambda function"
            });
        }
    }
}
