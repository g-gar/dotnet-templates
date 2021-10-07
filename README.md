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