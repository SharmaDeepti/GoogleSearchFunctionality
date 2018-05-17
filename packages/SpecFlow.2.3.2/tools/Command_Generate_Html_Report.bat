start \NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe --labels=All --out=TestResult.txt "--result=\SpecFlow.2.3.2\tools\TestResult.xml;format=nunit2" \GoogleSearchProject\bin\Debug\GoogleSearchProject.dll

pause

\SpecFlow.2.3.2\tools\specflow.exe nunitexecutionreport  \GoogleSearchProject\GoogleSearchProject.csproj /out:TestExecutionResult.html