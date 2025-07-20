# PhonePadDecoder

A C# console application that simulates typing on an old mobile phone keypad.  
It translates sequences of keypresses into text, with support for:
- Backspace (`*`)
- Pauses (` `)
- End of input (`#`)

---

##  Features

- Multi-tap decoding (e.g. `2`, `22`, `222` → `A`, `B`, `C`)
- Space (`' '`) used to separate same-key presses (e.g. `222 2 22#` -> `CAB`)
- `*` backspace support, used to remove the last character (e.g. `227*#` -> `B`)
- Processing ends with `#`
- Fully unit-tested with `xUnit`

---

## Project Structure

Phone__Pad/
    
  --> PhonePad.cs //Main console app
PhhonePad.Tests/
  --> PhonePadTests.cs //Contains Unit Tests

---

## Getting Started

### Prerequisites

- [.NET SDK 8 or later](https://dotnet.microsoft.com/download)
- Visual Studio Code or Visual Studio
- C# Extension for VS Code (if using VS Code)

---

### Setup Instructions

1. Clone the Repository
     `1. git clone https://github.com/avinashkumar56/PhonePadDecoder.git`
     `2. cd PhonePadDecoder`
2. Build the Main App
     `1. cd ../Phone_Pad`
     `2. dotnet build`
3. Run the Console App
     `dotnet run`
4. You'll be prompted to
     `Enter the Key (end it with #):4433555 555666#
      Output: HELLO`
---

### Sample Input/Output

("33#", "E")
("227*#", "B")
("4433555 555666#", "HELLO")

---

### Running Unit Tests
1. Goto the test project
     `cd ../PhonePad.Tests`
2. Run the tests
     `dotnet test`
3. Output
     `total: 11, failed: 0, succeeded: 11, skipped: 0`
