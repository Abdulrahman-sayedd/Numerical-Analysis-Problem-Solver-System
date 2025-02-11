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
    public partial class Formsimplefixedpoint : Form
    {
        public Formsimplefixedpoint()
        {
            InitializeComponent();
        }

        private void Formsimplefixedpoint_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve user inputs
            string functionInput = functionTextBox.Text;
            double x0, epsilon;

            // Parse xl, xu, and epsilon from text boxes
            if (!double.TryParse(x0TextBox.Text, out x0)  || !double.TryParse(epsilonTextBox.Text, out epsilon))
            {
                MessageBox.Show("Please enter valid values for x0 and epsilon.");
                return;
            }

            // Parse and evaluate the function
            try
            {
                // Parse the function input
                Func<double, double> function = ParseFunction(functionInput);

                // Perform bisection method and display results
                PerformFixedpointMethod(function, x0, epsilon);
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
        private void PerformFixedpointMethod(Func<double, double> function, double x0, double epsilon)
        {
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("Iteration", typeof(int));
            resultsTable.Columns.Add("xi", typeof(double));
            resultsTable.Columns.Add("f(xi)", typeof(double));
            resultsTable.Columns.Add("Error (%)", typeof(double));

            int iteration = 0;
            double xi = x0;
            double xiplus1 = function(xi);
            double error = Math.Abs((xiplus1 - xi) / xiplus1) * 100;

            while (error > epsilon)
            {
                
                xi = xiplus1;
                xiplus1=function(xi);


                error = Math.Abs((xiplus1 - xi) / xiplus1) * 100;

               
                
                // Add results to the table
                resultsTable.Rows.Add(iteration, xi,function(xi), error);
                iteration++;

               
            }

            // Bind the data table to the data grid view
            resultsDataGridView.DataSource = resultsTable;
        }
    }
}
