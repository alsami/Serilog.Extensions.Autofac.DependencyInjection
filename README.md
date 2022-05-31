# Serilog.Extensions.Autofac.DependencyInjection

[![Build Application](https://github.com/alsami/Serilog.Extensions.Autofac.DependencyInjection/actions/workflows/push.yml/badge.svg?branch=main)](https://github.com/alsami/Serilog.Extensions.Autofac.DependencyInjection/actions/workflows/push.yml)
[![codecov](https://codecov.io/gh/alsami/Serilog.Extensions.Autofac.DependencyInjection/branch/master/graph/badge.svg)](https://codecov.io/gh/alsami/Serilog.Extensions.Autofac.DependencyInjection)

[![NuGet](https://img.shields.io/nuget/dt/Serilog.Extensions.Autofac.DependencyInjection.svg)](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection) 
[![NuGet](https://img.shields.io/nuget/vpre/Serilog.Extensions.Autofac.DependencyInjection.svg)](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection)

This is a cross platform library, written in .netstandard 2.0, that serves as an extension for [autofac's containerbuilder](https://autofac.org/).
It will register all necessary classes and interfaces of Serilog using Microsoft's logging extensions

## Installation

This package is available via nuget. You can install it using Visual-Studio-Nuget-Browser or by using the dotnet-cli

```
dotnet add package Serilog.Extensions.Autofac.DependencyInjection
```

If you want to add a specific version of this package

```
dotnet add package Serilog.Extensions.Autofac.DependencyInjection --version 1.0.0
```

For more information please visit the official [dotnet-cli documentation](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-add-package).

## Usage

For more information about the usage, please have a look at the 
[samples](https://github.com/alsami/Serilog.Extensions.Autofac.DependencyInjection/tree/master/samples).
