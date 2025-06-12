#load tools\Atlas.BuildScript\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\demo_19.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\demo_19\demo_19.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
