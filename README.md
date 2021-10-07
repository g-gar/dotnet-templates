# dotnet-templates

## INSTALL
```
dotnet new --install <template_path>
```

## UNINSTALL
Requires a bit of work. Listing with `dotnet new --uninstall` will present all the available templates in the system, having the complete path for uninstallation (usually at the end). The `<template_path>` param is just a key that dotnet uses to register the templates.
```
dotnet new --uninstall <original_template_path>
```

## TEMPLATES

### library_git_test
Creates an empty library project with no source files (.cs), base folders (`src\` and `test\`) and following NuGet packages:

| PACKAGE                	| VERSION 	|
|------------------------	|---------	|
| Microsoft.NET.Test.Sdk 	| 16.11.0 	|
| NUnit                  	| 3.13.2  	|
