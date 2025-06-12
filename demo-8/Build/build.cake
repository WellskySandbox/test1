#load tools\Atlas.BuildScript\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\demo_8.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\demo_8\demo_8.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
