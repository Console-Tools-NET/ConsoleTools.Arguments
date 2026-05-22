// This namespace must remain the same as the one in System.Runtime.CompilerServices to allow the use
// of record types in C# 9.0 and later without requiring a reference to the System.Runtime.CompilerServices package.
// This is a common workaround for using record types in projects that target older versions of .NET
// or do not want to add additional dependencies.
namespace System.Runtime.CompilerServices;

internal static class IsExternalInit {}