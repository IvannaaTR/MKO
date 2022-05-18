using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using org.mariuszgromada.math.mxparser;


namespace Trybulovych_MFE
{
    public partial class Form1 : Form
    {
        private int reload = 0;
        public Function ux;
        public Function Tx;
        public Function bx;
        public Function sx;
        public Function fx;
        
        public Form1()
        {
            InitializeComponent();
            functionGraphics.ChartAreas[0].AxisX.Minimum = 0;
            functionGraphics.ChartAreas[0].AxisX.Maximum = 1;
            functionGraphics.Series[0].ChartType = SeriesChartType.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void Initialize()
        {
            functionGraphics.Series[0].Points.Clear();
            allGraphics.Series.Clear();
            dataGridView.Rows.Clear();
   
        }
       
        public double ai_i(double previous_x, double x, double next_x, double h, Function Tx, Function bx, Function sx)
        {
            double previous_half = (previous_x + x) / 2.0;
            double next_half = (next_x + x) / 2.0;
            double result = (1 / h) * (Tx.calculate(previous_half) + Tx.calculate(next_half)) + 0.5*(bx.calculate(previous_half) - bx.calculate(next_half))+ (h/3)*(sx.calculate(previous_half) + sx.calculate(next_half));
            return result;
        }
        public double ai_inext(double x, double next_x, double h, Function Tx, Function bx, Function sx)
        {
            double next_half = (next_x + x) / 2;
            double result = (-1/h)*Tx.calculate(next_half)+ 0.5* bx.calculate(next_half)+(h/6)* sx.calculate(next_half);
            return result;
        } 
        public double ainext_i(double x, double next_x, double h, Function Tx, Function bx, Function sx)
        {
            double next_half = (next_x + x) / 2;
            double result = (-1 / h) * Tx.calculate(next_half)  -0.5 * bx.calculate(next_half) + (h / 6) * sx.calculate(next_half);
            return result;
        }
        public double l_i(double previous_x, double x, double next_x, double h, Function fx)
        {
            double previous_half = (previous_x + x) / 2;
            double next_half = (next_x + x) / 2;
            double result = (h/2)*(fx.calculate(previous_half)+ fx.calculate(next_half));
            return result;
        }

        public List<double> SLAR(List<double> x, Function Tx, Function bx, Function sx, Function fx, double h, int n)
        {
            List<double> c_upper = new List<double>();
            List<double> b_middle = new List<double>();
            List<double> a_lower = new List<double>();
            List<double> l = new List<double>();
            List<double> q = new List<double>();

            for (int i=1; i<n-1; i++)
            {
                a_lower.Add(ainext_i(x[i], x[i+1], h, Tx, bx, sx));
                b_middle.Add(ai_i(x[i - 1], x[i], x[i + 1],h, Tx, bx, sx));
                c_upper.Add(ai_inext(x[i], x[i + 1], h, Tx, bx, sx));
            }
            b_middle.Add(ai_i(x[x.Count()-3], x[x.Count() - 2], x[x.Count() - 1], h, Tx, bx, sx));
         
            for (int i = 1; i < n; i++)
            {
                l.Add(l_i(x[i - 1], x[i], x[i+1], h, fx));
            }

            

            for (int i = 0; i < n; i++)
            {
                q.Add(0);
            }
            n = b_middle.Count();
            a_lower.Insert(0,0);
            c_upper.Add(0);
            c_upper[0] /= b_middle[0];
            l[0] /= b_middle[0];
            for (int i = 1; i < n; i++)
            {
                double temporary = 1 / (b_middle[i] - c_upper[i-1] * a_lower[i]);
                c_upper[i] *= temporary;
                l[i] = (l[i] - l[i - 1] * a_lower[i]) * temporary;
            }
            q[n - 1] = l[n - 1];

            for(int i=n-2; i>=0; i--)
            {
                q[i] = l[i] - (c_upper[i]*q[i+1]);
            }
            q.Insert(0, 0);
            
            return q;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (reload != 0)
            {
                Initialize();
            }
            reload++;

            ux = new Function("f(x) = " + uxTextBox.Text);
            Tx = new Function("f(x) = " + txTextBox.Text);
            bx = new Function("f(x) = " + bxTextBox.Text);
            sx = new Function("f(x) = " + sxTextBox.Text);
            fx = new Function("f(x) = " + fxTextBox.Text);
         
            int N= 4;
            int N_max = 100;

            while (N <= N_max)
            {
                
                var xi = new List<double>();
                for (double i = 0; i <= N; i++)
                {
                    xi.Add((1.0 / N) * i);
                }
                var h = xi[1] - xi[0];
                var qi = SLAR(xi, Tx, bx, sx, fx, h, N);
                var uh = new List<double>();


                uh.Add(0);
                for (int i = 1; i < N; i++)
                {
                    var kurant = 0.0;
                    var x = xi[i];

                    if (x > xi[i - 1] && x <= xi[i])
                    {
                        kurant = (x - xi[i - 1]) / h;
                    }
                    else if (x > xi[i] && x <= xi[i + 1])
                    {
                        kurant = (xi[i + 1] - x) / h;
                    }
                    else
                    {
                        kurant = 0;
                    }

                    uh.Add(qi[i] * kurant);

                }
                uh.Add(0);

                double uh0 = 0;
                for (int i = 0; i < qi.Count() - 1; i++)
                {
                    uh0 += Math.Pow(qi[i], 2) + qi[i] * qi[i + 1] + Math.Pow(qi[i + 1], 2);
                }
                uh0 = Math.Sqrt((h / 3) * uh0);

                double uh1 = 0;
                for (int i = 0; i < qi.Count() - 1; i++)
                {
                    uh1 += Math.Pow(qi[i] - qi[i + 1], 2);
                }
                uh1 = Math.Sqrt((uh1/h) + Math.Pow(uh0, 2));

                dataGridView.Rows.Add(N, Math.Round(uh0, 5), Math.Round(uh1, 5));

                allGraphics.Series.Add($"N={N}");
                allGraphics.ChartAreas[0].AxisX.Minimum = 0;
                allGraphics.ChartAreas[0].AxisX.Maximum = 1;
                allGraphics.Series[$"N={N}"].ChartType = SeriesChartType.Line;
                for (int i = 0; i < uh.Count; i++)
                {
                    allGraphics.Series[$"N={N}"].Points.AddXY(xi[i], uh[i]);
                }

                if (N >= 10)
                {
                    N += 10;
                }
                else
                {
                    N += 2;
                }
                
            }
            for (double i = 0.0; i <= 1; i += 0.001)
            {
                functionGraphics.Series[0].Points.AddXY(i, ux.calculate(i));
            }
        }

     
    }
}
