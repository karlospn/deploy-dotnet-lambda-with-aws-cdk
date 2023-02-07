FROM public.ecr.aws/lambda/dotnet:7 as base

FROM mcr.microsoft.com/dotnet/sdk:7.0 as build-image
WORKDIR /app

COPY . .
RUN dotnet publish -c Release -o /publish

FROM base AS final
WORKDIR /var/task
COPY --from=build-image /publish .
CMD ["My.Net7.Lambda::My.Net7.Lambda.Function::FunctionHandler"]