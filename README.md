# 5 ways to deploy a .NET Lambda using AWS CDK

This git repository contains a few examples about how you can deploy a dotnet lambda when using AWS CDK.

> This repository is tied to this post from my blog: https://www.mytechramblings.com/posts/deploy-dotnet-lambdas-with-aws-cdk/

- The ``/src/My.Net6.Lambda`` and the  ``/src/My.Net7.Lambda`` folders contain a .NET 6 and a .NET 7 lambda function. Both functions will be used in the following examples.
   
- The ``/src/Net7BundlingContainerLambdaCdk`` folder contains an example about how you can deploy a .NET 7 lambda using a container image and the AWS CDK ``FromImageAsset`` method.  

- The ``/src/Net7ExistingContainerLambdaCdk`` folder contains an example about how you can deploy a .NET 7 lambda using a container image that has already been pushed into an ECR registry.   

- The ``/src/Net6BundlingZipFileLambdaCdk`` folder contains an example about how you can deploy a .NET 6 lambda using a .zip file and the AWS CDK ``FromAsset`` method with bundling options.   

- The ``/src/Net6ExistingZipFileLambdaCdk`` folder contains an example about how you can deploy a .NET 6 lambda using an existing .zip file and the AWS CDK ``FromAsset`` method.   

- The ``/src/Net6UsingDotNetFunctionLambdaCdk`` folder contains an example about how you can deploy a .NET 6 lambda using the ``XaasKit.CDK.AWS.Lambda.DotNet`` package.   
(_This is experimental. Right now there is an ongoing [RFC proposal](https://github.com/aws/aws-cdk-rfcs/issues/469) discussing the adoption of this implementation_). 

