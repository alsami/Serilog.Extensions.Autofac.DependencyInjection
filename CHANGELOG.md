# [3.0.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/3.0.0) (2020-10-15)

## Breaking changes

* `Autofac` has been updated to version `6.0.0`. This release contains many new features but also breaking-changes. Check out this [blog-post](https://alistairevans.co.uk/2020/09/28/autofac-6-0-released/) for more information.

## Chore
* Update `Microsoft.Extensions.Logging` to version `3.1.9`
* Update `Serilog` to version `2.10.0`

# [2.1.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/2.1.0) (2020-06-15)

## Chore

* Update `Autofac` to version `5.2.0`
* Update `Microsoft.Extensions.Logging` to version `3.1.5`

# [2.0.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/2.0.0) (2020-02-02s)

## Breaking changes

* `Autofac` has been updated to `5.0.0`. The release of `Autofac` contains breaking changes, mostly making the container immutable. You can read more about the changes [here](https://www.paraesthesia.com/archive/2020/01/27/autofac-5-released/).

## Chore

* Update `Serilog` to version `2.9.0`

# [1.4.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.4.0) (2019-12-11)

## Chore

* Update deps to latest version

# [1.3.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.3.0) (2019-10-07)

## Chore

* Update Serilog.Extensions.Logging
* Serilog.Sinks.RollingFile
* Serilog.Sinks.Console

## Features

* Initialize logger immediately rather than waiting for Autofac to call the module. Fixes [#1](https://github.com/alsami/Serilog.Extensions.Autofac.DependencyInjection/issues/1)

# [1.2.1](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.2.1) (2019-05-05)

## Chore

Update Serilog.Extensions.Logging to 2.0.4

# [1.2.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.2.0) (2019-03-24)

## Chore

* Update Autofac to 4.9.2
* Update Serilog to 2.8.0

# [1.1.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.1.0) (2019-03-17)

## Chore

* Update Autofac to 4.9.1
* Update Autofac.Extensions.DependencyInjection to 4.4.0

# [1.0.0](https://www.nuget.org/packages/Serilog.Extensions.Autofac.DependencyInjection/1.0.0) (2018-12-10)

## Features

* Allow adding serilog logging provider in combination with microsoft's logging abstractions by either using a default logger-configuration or by providing a custom configuration