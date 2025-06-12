#load tools\Atlas.BuildScript\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\demo_5.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\demo_5\demo_5.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
