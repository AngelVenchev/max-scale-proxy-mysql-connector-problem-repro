## Entity Framework - MySQL Connector - MaxScale proxy issue reproduction

This repo reproduces the issue of inserting records into a MySQL/MariaDB using the [EntityFrameworkCore MySQL connector](https://www.nuget.org/packages/Pomelo.EntityFrameworkCore.MySql);

### Requirements
* [dotnet core 2.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.1)
  * To use a different SDK version, edit the `TargetFramework` property in `/MaxScaleProxyProblem/MaxScaleProxyProblem.csproj`
* dotnet cli
* aws cli (https://aws.amazon.com/cli/)

### Repro steps
1. Go into the project folder `/MaxScaleProxyProblemData`
2. Create the test table using the provided `insertScript.sql` SQL script:

```
mysql -u ${USER} -p ${DB} < insertScript.sql
```
3. edit `MaxScaleProxyDbContext.cs` to add the db credentials on lines 10-13
4. Go into the project folder `/MaxScaleProxyProblem`
5. Restore project dependencies using [dotnet restore](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x):

```
dotnet restore
```
6. Run the project using [dotnet run](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run?tabs=netcore21):
```
dotnet run
```

### Repro steps in Lambda
1. Do steps 1-3 from "Repro steps" section
2. [configure aws](https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-configure.html) cli with credentials for AWS
```
aws configure
```
3. Go into the project folder `/MaxScaleProxyProblemLambda`
4. Restore project dependencies using [dotnet restore](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-restore?tabs=netcore2x):

```
dotnet restore
```
5. deploy the function to AWS Lambda by running the command and following the instructions
```
dotnet lambda deploy-function
```

