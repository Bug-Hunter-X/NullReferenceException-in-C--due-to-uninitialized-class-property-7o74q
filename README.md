# NullReferenceException in C# due to uninitialized class property

This repository demonstrates a common C# error: a `NullReferenceException` caused by accessing an uninitialized class property.

## Bug Description
The `bug.cs` file contains a class with a property that is not initialized.  Attempting to use this property before assigning a value results in a `NullReferenceException`.

## Solution
The `bugSolution.cs` file shows how to fix this problem by either assigning a default value to the property or adding a check to ensure it is initialized before access.

## How to Reproduce
1. Clone this repository.
2. Compile and run `bug.cs`. Observe the `NullReferenceException`.
3. Compile and run `bugSolution.cs`. Observe that the exception is handled.
