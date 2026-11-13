# VB.NET Calculator

A simple Windows Forms calculator built using **Visual Basic .NET (VB.NET)** and **.NET Framework 4.8**.

This project is shared as a free learning resource for students and beginners who want to explore VB.NET programming, Windows Forms, event handling, variables, and mathematical operations.

## Features

| Operation | Description |
|---|---|
| Addition | Adds two numbers |
| Subtraction | Subtracts the second number from the first |
| Multiplication | Multiplies two numbers |
| Division | Divides two numbers and returns a decimal result |
| Integer Division | Returns the integer quotient |
| Modulus | Returns the remainder of a division |
| Power | Raises a number to a specified power |
| Square Root | Calculates the square root |
| Ceiling | Rounds a number up |
| Floor | Rounds a number down |
| Clear | Clears all input and result fields |
| Exit | Closes the application |

## Requirements

- Windows operating system
- Visual Studio
- .NET Framework 4.8 Developer Pack
- Visual Studio's .NET desktop development workload

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/Heratics/Vb.net4.8Calculator.git
```

### 2. Open the project

Navigate to the `solncalculator` folder and open `solncalculator.slnx` in Visual Studio.

Alternatively, open `calculator/calculator.vbproj` directly from that folder.

### 3. Run the application

Press **F5** or click the **Start** button in Visual Studio to build and launch the calculator.

## How to Use

1. Enter your first number in the first input field.
2. Enter your second number when the selected operation requires it.
3. Click the corresponding operation button.
4. View the calculated result in the result field.
5. Click **Clear** to reset the calculator or **Exit** to close it.

Some operations, such as square root, ceiling, and floor, only require the first number.

## Learn from the Source Code

The main application logic is located in:

`solncalculator/calculator/Form1.vb`

This project is a good starting point for learning several VB.NET concepts:

| Concept | What you can learn |
|---|---|
| Variables | Declaring and using `Integer` and `Decimal` |
| Data Types | Understanding numerical data types |
| Events | Handling button clicks using `Handles` |
| Windows Forms | Working with buttons and text boxes |
| Operators | Performing mathematical calculations |
| Conditional Statements | Using `If...Then...Else` |
| Exception Handling | Understanding `Try...Catch` |
| Math Functions | Using built-in functions such as `Math.Sqrt`, `Math.Ceiling`, and `Math.Floor` |

**Learning suggestion:** Open `Form1.vb`, find the addition button's click event, and follow how the application reads the input, calculates the result, and displays it. Then try implementing another mathematical operation yourself!

## Project Structure

```text
Vb.net4.8Calculator/
└── solncalculator/
    ├── solncalculator.slnx
    └── calculator/
        ├── Form1.vb
        ├── Form1.Designer.vb
        ├── Form1.resx
        ├── calculator.vbproj
        ├── App.config
        └── My Project/
```

- `Form1.vb`: Main calculator logic and button events.
- `Form1.Designer.vb`: Windows Forms interface and controls.
- `Form1.resx`: Form resources.
- `calculator.vbproj`: Project configuration.
- `App.config`: Application configuration.

## Important Notes

This is a basic educational project, not a production-ready scientific calculator.

The original implementation has some limitations, including basic input validation and missing division-by-zero handling. Some operations also use integer values, meaning fractional results may be lost.

You are encouraged to explore the code, identify these limitations, and improve the implementation as part of your learning.

## Contributing

Feel free to fork this repository, experiment with the source code, fix bugs, and introduce new mathematical operations.

Whether you are a beginner learning VB.NET or a student looking for a practical Windows Forms example, you are welcome to learn from this project.

## License

No license is currently specified. Please contact the repository owner regarding permissions for redistribution or reuse.

---

**Created by [Heratics](https://github.com/Heratics)**

*Sharing code. Encouraging learning.*
