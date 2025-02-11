using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;
using Antlr.Runtime.Tree;
using FParsec;

namespace WindowsFormsApp1
{
    public partial class Formfalseposition : Form
    {
        public Formfalseposition()
        {
            InitializeComponent();
        }

        private void Formfalseposition_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Retreive user input
            string functionInput=functionTextBox.Text;
            double xl, xu, epsilon;

            //parse xl,xu,and epslion from text boxes 
            if (!double.TryParse(xlTextBox.Text, out xl) || !double.TryParse(xuTextBox.Text, out xu) || !double.TryParse(epsilonTextBox.Text, out epsilon))
            {
                MessageBox.Show("Please enter valid values for xl, xu, and epsilon.");
                return;
            }

            //parse and evaluate the function
            try
            {
                //parse the function input
                Func<double, double> function = parseFunction(functionInput);


                // Perform bisection method and display results
                performBisectionMethod(function, xl, xu, epsilon);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured:{ex.Message}");
            }
            

           
        }
        // Method to parse the function input and return a lambda function
        private Func<double, double> parseFunction(string functionInput)
        {
            //create a parameter experression for x
            var paremeterX = Expression.Parameter(typeof(double), "x");

            // Parse the function input and create an expression
            // the array specify that the function takes one paremeter type of x
            //lambdaExpression is an expression tree representing the mathematical function input by the user 
            //The expression tree is a structured representation of the function in the form of nodes, each representing an operation, parameter, or value.
            var lambdaExpression = System.Linq.Dynamic.DynamicExpression.ParseLambda(
                new[] { paremeterX },
                typeof(double),
                functionInput);

            // Compile the lambda expression to a delegate
            //You can pass input values to the compiled function and get the output.
            return (Func<double, double>)lambdaExpression.Compile();

        }
        // Method to perform bisection method and display results in a grid view
        private void performBisectionMethod(Func<double,double> function , double xl, double xu, double epsilon)
        {
            DataTable resultsTable = new DataTable();
            resultsTable.Columns.Add("iteration", typeof(int));
            resultsTable.Columns.Add("xl", typeof(double));
            resultsTable.Columns.Add("f(xl)",typeof(double));
            resultsTable.Columns.Add("xu", typeof(double));
            resultsTable.Columns.Add("f(xu)", typeof(double));
            resultsTable.Columns.Add("xr", typeof(double));
            resultsTable.Columns.Add("f(xr)", typeof(double));
            resultsTable.Columns.Add("Error (%)", typeof(double));

            int iteration = 0;
            double xr = 0;
            double xrOld = 0;
            double error = double.MaxValue;

            while(error>epsilon)
            {
                iteration++;
                xrOld = xr;
                xr = xu - (function(xu) * (xl - xu)) / (function(xl) - function(xu));
                double f_xl = function(xl);
                double f_xu = function(xu);
                double f_xr = function(xr);

                //calculate error

                error = Math.Abs((xr - xrOld) / xr) * 100;

                //add results to the table
                resultsTable.Rows.Add(iteration,xl,f_xl,xu,f_xu,xr,f_xr,error);
                // Update xl or xu based on f(xl) * f(xr)
                if (f_xl * f_xr < 0)
                {
                    xu = xr;
                }
                else
                {
                    xl = xr;
                }

                // Bind the data table to the data grid view
                resultsDataGridView.DataSource = resultsTable;
            }
        }
    }
}
