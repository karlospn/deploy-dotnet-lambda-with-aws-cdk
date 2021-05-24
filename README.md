# deploy-dotnet-lambda-with-aws-cdk

This git repository contains a few examples about how you can deploy a dotnet lambda when using AWS CDK.

> This repository is tied to this post from my blog. //TODO: Add URL

The ``/src/My.Net5.Lambda`` and the  ``/src/My.NetCore31.Lambda`` folder contains a NET 5 and a NET Core 3.1 lambda function. Both functions will be used in the following examples.

- The ``/src/Net5BundlingContainerLambdaCdk`` folder contains an example about how you can deploy a NET 5 lambda using a container image and the AWS CDK ``FromImageAsset`` option.

- The ``/src/Net5ExistingContainerLambdaCdk`` folder contains an example about how you can deploy a NET 5 lambda using a container image that has already been pushed into an ECR registry.

-  The ``/src/NetCore31BundlingZipFileLambdaCdk`` folder contains an example about how you can deploy a NET Core 3.1 lambda using a .zip file and the AWS CDK ``FromAsset`` with bundling options.

- The ``/src/NetCore31ExistingZipFileLambdaCdk`` folder contains an example about how you can deploy a NET Core 3.1 lambda using an existing .zip file and the AWS CDK ``FromAsset`` option.

