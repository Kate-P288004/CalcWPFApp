using System;

using System.IO;

using System.Windows;

namespace CalcWPFApp

{

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)

        {

            try

            {

                double num1 = Convert.ToDouble(Input1.Text);

                double num2 = Convert.ToDouble(Input2.Text);

                double result = num1 * num2;

                ResultText.Text = $"Result: {result}";
                // Save the result to a file

                string path = @"C:\Users\p288004\Desktop\calc.txt";

                File.WriteAllText(path, $"Multiplication Result: {result}");

            }

            catch

            {

                ResultText.Text = "Please enter valid numbers!";

            }

        }

    }

}
