using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;


namespace WindowsFormsApp1
{
    public partial class Formbisection : System.Windows.Forms.Form
    {
        public Formbisection()
        {
            InitializeComponent();
        }

        private void Formbisection_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            string functionInput = functionTextBox.Text;
            double xl, xu, epsilon;

            // Parse xl, xu, and epsilon from text boxes
            if (!double.TryParse(xlTextBox.Text, out xl) || !double.TryParse(xuTextBox.Text, out xu) || !double.TryParse(epsilonTextBox.Text, out epsilon))
            {
                MessageBox.Show("Please enter valid values for xl, xu, and epsilon.");
                return;
            }

            // Parse and evaluate the function
            try
            {
                // Parse the function input
                Func<double, double> function = ParseFunction(functionInput);

                // Perform bisection method and display results
                PerformBisectionMethod(function, xl, xu, epsilon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Method to parse the function input and return a lambda function
        private Func<double, double> ParseFunction(string functionInput)
        {
            // Create a parameter expression for 'x'
            var parameterX = Expression.Parameter(typeof(double), "x");

            // Parse the function input and create an expression
            var lambdaExpression = System.Linq.Dynamic.DynamicExpression.ParseLambda(
                new[] { parameterX },
                typeof(double),
                functionInput);

            // Compile the lambda expression to a delegate
            return (Func<double, double>)lambdaExpression.Compile();
        }

        // Method to perform bisection method and display results in a grid view
        private void PerformBisectionMethod(Func<double, double> function, double xl, double xu, double epsilon)
        {
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("Iteration", typeof(int));
            resultsTable.Columns.Add("xl", typeof(double));
            resultsTable.Columns.Add("f(xl)", typeof(double));
            resultsTable.Columns.Add("xu", typeof(double));
            resultsTable.Columns.Add("f(xu)", typeof(double));
            resultsTable.Columns.Add("xr", typeof(double));
            resultsTable.Columns.Add("f(xr)", typeof(double));
            resultsTable.Columns.Add("Error (%)", typeof(double));

            int iteration = 0;
            double xr = 0;
            double xrOld = 0;
            double error = double.MaxValue;

            while (error > epsilon)
            {
                iteration++;
                xrOld = xr;
                xr = (xl + xu) / 2;

                double f_xl = function(xl);
                double f_xu = function(xu);
                double f_xr = function(xr);

                // Calculate error percentage
                error = Math.Abs((xr - xrOld) / xr) * 100;

                // Add results to the table
                resultsTable.Rows.Add(iteration, xl, f_xl, xu, f_xu, xr, f_xr, error);

                // Update xl or xu based on f(xl) * f(xr)
                if (f_xl * f_xr < 0)
                {
                    xu = xr;
                }
                else
                {
                    xl = xr;
                }
            }

            // Bind the data table to the data grid view
            resultsDataGridView.DataSource = resultsTable;
        }
   

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

 