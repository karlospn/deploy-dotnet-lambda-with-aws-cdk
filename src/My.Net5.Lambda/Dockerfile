FROM public.ecr.aws/lambda/dotnet:5.0 as base

FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-image
WORKDIR /app

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish --no-restore -c Release -o /publish

FROM base AS final
WORKDIR /var/task
COPY --from=build-image /publish .
CMD ["My.Net5.Lambda::My.Net5.Lambda.Function::FunctionHandler"]