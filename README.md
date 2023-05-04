# super-system
The C# Super System is a collection of implementation studies used to develop a deeper understanding of the C# languages functionality and capabilities.


# Study1.cs - First Iteration
This is the first iteration of the study: this study focuses on adding valid input logic to the classes child parameter set directive, during assignment; and, allowing the assigned logic functionality to be generically reused for subsequent parameter setters.

Why is this important? Publicly accessible value setters may lead to private method execution depending on program design and using raw public inputs may pose a security risk (once again depending on program design) -- depending on who has access and under what circumstances.

Summation: This allows us to execute generic data types on privately pre-defined generic methods without sacrificing type enforcement; while also, allowing us to perform other necessary checks prior to actually setting and using a publicly defined value within our program.
