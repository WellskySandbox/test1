#load tools\Atlas.BuildScript\Content\main.cake

Build.Settings = new BuildSettings 
{
  SolutionPath = @"..\demo_4.sln",

  TestProjectFilePattern = @"../Tests/**/*.csproj",

  WebServicePath = @"..\demo_4\demo_4.csproj",

  UseDotNetCoreBuild = true,

  VersionFormat = "1.0.0.{0}"
};

var target = Argument("target", "Default");
RunTarget(target);
