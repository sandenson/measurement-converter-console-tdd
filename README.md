# Instructions

## Collect test coverage

Run `cd MeasurementConverter.Test && dotnet test --collect:"XPlat Code Coverage"`

If everything worked fine, a file with the path `TestResults/{UUID}/coverage.cobertura.xml`. The `{UUID}` should look like "2615a93d-aa7c-4480-b01e-f3130e1a0094" or other similar.

## Generate test reports

Change to the test directory by running `cd MeasurementConverter.Test` from the project root, then run the following command:

```cmd
reportgenerator -reports:"TestResults\{UUID}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

Where `{UUID}` has to be replaced with the same UUID of the test data previously generated, which is the name of the directory that your `coverage.cobertura.xml` file is in.

If that doesn't work, use the following command to install the ReportGenerator NuGet tool globally on your machine, then run the command above again:

```cmd
dotnet tool install -g dotnet-reportgenerator-globaltool
```

If you get an error with a message that reads "command not found" or similar and you're running on a Linux machine, add `$HOME/.dotnet/tools/` to the start of the command to directly reference its executables, as seen below:

```cmd
$HOME/.dotnet/tools/reportgenerator -reports:"TestResults\{uuid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
```

If everything went right, your coverage report has been generated within a new "coveragereport" directory created within the MeasurementConvertar.Test project.

You can change the name of the directory by setting a new value to the `targetDir` attribute used in the command.
