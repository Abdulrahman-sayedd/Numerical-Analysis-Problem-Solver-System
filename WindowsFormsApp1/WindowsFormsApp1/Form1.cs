using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace WindowsFormsApp1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Formbisection bisection;
        Formfalseposition falseposition;
        Formsimplefixedpoint simplefixedpoint;
        Formnewton newton;
        formscant scant;
        formGauss gauss;
        formLU lu;
        Formcarmers carmers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(newton==null)
            {
                newton = new Formnewton();
                newton.FormClosed += newton_FormClosed;
                newton.MdiParent = this;
                newton.Dock=DockStyle.Fill;
                newton.Show();

            }
            else
            {
                newton.Activate();
            }
        }

        private void newton_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(falseposition==null)
            {
                falseposition=new Formfalseposition();
                falseposition.FormClosed += falseposition_FormClosed; 
                falseposition.MdiParent = this;
                falseposition.Dock= DockStyle.Fill;
                falseposition.Show();
            }
            else
            {
                falseposition.Activate();
            }
        }

        private void falseposition_FormClosed(object sender, FormClosedEventArgs e)
        {
            falseposition =null;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool ch1expand = false; // Start with the container being collapsed
        private const int expandHeight = 230; // Maximum height for expansion
        private const int collapseHeight = 43; // Minimum height for contraction
        private const int heightChange = 10; // Amount to change the height in each tick
        private void ch1timer_Tick(object sender, EventArgs e)
        {
            // Expand the container
            if (ch1expand)
            {
                chapter1container.Height += heightChange;

                if (chapter1container.Height >= expandHeight)
                {
                    ch1transition.Stop();
                    ch1expand = true;
                }
            }
            // Collapse the container
            else
            {
                chapter1container.Height -= heightChange;

                if (chapter1container.Height <= collapseHeight)
                {
                    // Stop the timer and update the state
                    ch1transition.Stop();
                    ch1expand = false;
                }
            }
        }

        private void chapter1btn_Click(object sender, EventArgs e)
        {
            // Toggle the state of ch1expand
            ch1expand = !ch1expand;
            // Start the timer to expand or contract the container
            ch1transition.Start();
        }
        bool sidebarexpand = true;
        private void sidebartransition_Tick(object sender, EventArgs e)
        {
            if(sidebarexpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <=0)
                { 
                    sidebarexpand=false;
                sidebartransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width>=150)
                {
                    sidebarexpand = true; 
                    sidebartransition.Stop();
                }

            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartransition.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            if(bisection==null) // to see wheter the sup form is open or not and null means it's closed
            {
                bisection = new Formbisection();//create new instance from form
                //The method handles the closure of the form by resetting the bisection variable to null, allowing for a new instance of the form to be created and shown again when needed.
                bisection.FormClosed += bisection_FormClosed;//event
                bisection.MdiParent = this;// sets the MDI parent of the bisection form to the current form (mainform)
                bisection.Dock = DockStyle.Fill;
                bisection.Show();
            }
            else
            {
                //if it's not null means the form is already open;
                bisection.Activate();
            }
        }

        private void bisection_FormClosed(object sender, FormClosedEventArgs e)//event handler
        {
            bisection=null;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool ch2expand = false; // Start with the container being collapsed
        private const int expand2Height = 150; // Maximum height for expansion
        private const int collapse2Height = 50; // Minimum height for contraction
        private const int height2Change = 10; // Amount to change the height in each tick
        private void ch2tranition_Tick(object sender, EventArgs e)
        {
            if (ch2expand)
            {
                Ch2container.Height += height2Change;

                if (Ch2container.Height >= expand2Height)
                {
                    ch2transition.Stop();
                    ch2expand = true;
                }
            }
            // Collapse the container
            else
            {
                Ch2container.Height -= height2Change;

                if (Ch2container.Height <= collapse2Height)
                {
                    // Stop the timer and update the state
                    ch2transition.Stop();
                    ch2expand = false;
                }
            }
        }

         private void button6_Click(object sender, EventArgs e)
        {
            // Toggle the state of ch1expand
            ch2expand = !ch2expand;
            // Start the timer to expand or contract the container
            ch2transition.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gauss == null)
            {
                gauss = new formGauss();
                gauss.FormClosed += gauss_FormClosed;
                gauss.MdiParent = this;
                gauss.Dock = DockStyle.Fill;
                gauss.Show();
            }
            else { gauss.Activate(); }
        }

        private void gauss_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SFbtn_Click(object sender, EventArgs e)
        {
            if(simplefixedpoint==null)
            {
                simplefixedpoint = new Formsimplefixedpoint();
                simplefixedpoint.MdiParent = this;
                simplefixedpoint.FormClosed += simplefixedpoint_FormClosed;
                simplefixedpoint.Dock = DockStyle.Fill;
                simplefixedpoint.Show();
            }
            else
            {
                simplefixedpoint.Activate();
            }
        }

        private void simplefixedpoint_FormClosed(object sender, FormClosedEventArgs e)
        {
            simplefixedpoint = null;
        }

        private void scantbtn_Click(object sender, EventArgs e)
        {
            if(scant==null)
            {
                scant = new formscant();
                scant.FormClosed += scant_FormClosed;
                scant.MdiParent= this;
                scant.Dock = DockStyle.Fill;    
                scant.Show();    

            }
            else { scant.Activate(); }
        }

        private void scant_FormClosed(object sender, FormClosedEventArgs e)
        {
            scant=null;
        }

        private void LUbtn_Click(object sender, EventArgs e)
        {
            if (lu==null)
            {
                lu= new formLU();
                lu.FormClosed += lu_FormClosed;
                lu.MdiParent= this;
                lu.Dock = DockStyle.Fill;
                lu.Show();
            }else { lu.Activate(); }
        }

        private void lu_FormClosed(object sender, FormClosedEventArgs e)
        {
           lu=null;
        }

        private void CRbtn_Click(object sender, EventArgs e)
        {
            if(carmers==null)
            {
                carmers= new Formcarmers();
                carmers.FormClosed += carmers_FormClosed;
                carmers.MdiParent= this;
                carmers.Dock = DockStyle.Fill;
                carmers.Show();
            }
            else {  carmers.Activate(); }
        }

        private void carmers_FormClosed(object sender, FormClosedEventArgs e)
        {
            carmers = null;
        }
    }
}
