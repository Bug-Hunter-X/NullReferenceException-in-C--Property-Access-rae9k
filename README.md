# C# NullReferenceException Example

This repository demonstrates a common C# error: the `NullReferenceException`.  The `Bug.cs` file contains code that throws this exception.  The solution, in `BugSolution.cs`, shows how to prevent the exception using null checking.

## Problem

In `Bug.cs`, the `MyProperty` is not explicitly initialized.  When `MyMethod()` attempts to access it, it could be null, leading to a `NullReferenceException`. 

## Solution

`BugSolution.cs` provides a solution by incorporating null checks.  This ensures that the code will not crash even if `MyProperty` is null.