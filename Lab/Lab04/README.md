# Lab 04 - Mathematical Operations GUI

## Description
This C# program provides a graphical user interface (GUI) for performing various mathematical operations. It includes functionality to calculate factorial, generate prime numbers, and generate Fibonacci series based on user input.

## Instructions
1. Run the program.
2. Enter a number into the text box provided.
3. Click on one of the buttons to perform the corresponding mathematical operation.
4. The result will be displayed in the adjacent text box.

## Usage
Simply run the program and interact with the graphical user interface.

## Features
- Factorial Calculation: Click the "Calculate Factorial" button to compute the factorial of the entered number.
- Prime Number Generation: Click the "Generate Prime Numbers" button to generate prime numbers up to the entered number.
- Fibonacci Series Generation: Click the "Generate Fibonacci Series" button to generate Fibonacci series up to the entered number.

## Source Code
```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, i = 1, fact = 1;
            num = int.Parse(textBox1.Text);
            while (i <= num)
            {
                fact = fact * i;
                i++;
            }
            textBox2.Text = fact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, c;
            int num = int.Parse(textBox1.Text);
            textBox2.Text = "";
            for(j = 2; j <= num; j++) {
                c = 0; i = 1;
                while(i <= j)
                {
                    if(j % i == 0)
                    {
                        c++;
                    }i++;
                }
                if (c <= 2) 
                {
                    textBox2.Text += j.ToString() + ", ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int prev = 0, cur = 1, next;
            int num = int.Parse(textBox1.Text);
            textBox2.Text = prev.ToString() +cur.ToString();
            next = prev + cur;
            while (next <= num)
            {
                textBox2.Text += next.ToString();
                prev = cur;
                cur = next;
                next = prev + cur;
            }
        }
    }
}
```

## Example
![Mathematical Operations GUI](math_operations_gui.png)

Enter a number and click on one of the buttons to perform the corresponding mathematical operation. The result will be displayed in the adjacent text box.