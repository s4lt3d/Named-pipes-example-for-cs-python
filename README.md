# Cross-Application Data Exchange using Named Pipes

This guide demonstrates how to use named pipes to exchange data between a C# application and a Python script. Named pipes provide a mechanism for inter-process communication using a server-client approach.

## Prerequisites:

- .NET SDK (for the C# example).
- Python (Tested with Python 3.x).
- `pywin32` library for Python, which provides an interface to many of the Windows API functions. You can install it using `pip`:
  ```bash
  pip install pywin32

How to use it:
Start the C# program, then run the python script. The C# program will wait for python to start and connect. 
