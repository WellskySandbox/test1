#load tools\Atlas.BuildScript\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\demo_12.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\demo_12\demo_12.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
