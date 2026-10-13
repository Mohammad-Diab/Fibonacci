# Fibonacci

A small Windows app that finds the n-th Fibonacci number and shows how long it took. Written in C# with WPF on .NET Framework 4.0; the interface is in Arabic.

## Features

- Type a whole number n (1 or more, up to 19 digits) and pick how to compute F(n):
  - **الحساب بشكل عودي** (recursive form): F(n) = F(n-1) + F(n-2).
  - **الحساب بشكل خطي** (linear): a simple loop from F(1) up to F(n).
- Uses `BigInteger`, so the result is exact however many digits it has.
- Shows the result and the time taken in milliseconds.
- Offers to save the number to a `.txt` file, handy when it is too long to read in the message box.

## Requirements

Windows with .NET Framework 4.0 or later. Windows 8, 10 and 11 already include it.

## Usage

Download `Fibonacci-v1.0.0.7z` from [Releases](https://github.com/Mohammad-Diab/Fibonacci/releases), extract it, and run `Fibonacci.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Fibonacci.git
```

Open `Fibonacci.sln` in Visual Studio and build, or run:

```
MSBuild Fibonacci.sln /p:Configuration=Release
```

The exe is written to `Fibonacci\bin\Release`.

The project targets .NET Framework 4.0. Recent Visual Studio versions don't ship its reference assemblies; if the build stops with `MSB3644`, extract the [Microsoft.NETFramework.ReferenceAssemblies.net40](https://www.nuget.org/packages/Microsoft.NETFramework.ReferenceAssemblies.net40) NuGet package and point MSBuild at its `build` folder:

```
MSBuild Fibonacci.sln /p:Configuration=Release /p:TargetFrameworkRootPath=<package>\build
```

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)
