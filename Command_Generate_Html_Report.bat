start packages\NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe --labels=All --out=TestResult.txt "--result=TestResult.xml;format=nunit2" GoogleSearchProject\bin\Debug\GoogleSearchProject.dll

pause

packages\SpecFlow.2.3.2\tools\specflow.exe nunitexecutionreport  GoogleSearchProject\GoogleSearchProject.csproj /out:TestExecutionResult.html
