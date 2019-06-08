using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();   
        }
        double l = 0, Im = 0, e = 0, nu = 0, f = 0;
        
        void Make_Scroll(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
        }


        void Solve(double l, double Im, double e, double nu, double f)
        {
            chart_polar.Series[0].Points.Clear();
            chart_dekart.Series[0].Points.Clear();
            chart_polar.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            chart_dekart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Polar;
            Make_Scroll(chart_polar);
            Make_Scroll(chart_dekart);

            this.l = l;
            this.Im = Im;
            this.nu = nu;
            this.e = e;
            this.f = f;

            double lyamda = 3 * Math.Pow(10, 8) / f;
            double r = 1;
            Double.TryParse(textBox_r.Text, out r);

            double middle_border = lyamda / (2 * Math.PI);
            double border_to_near_zone = middle_border / 1000;
            double border_to_far_zone = middle_border * 1000;

            textBox_border_zone_far.Text = border_to_far_zone.ToString("F4");
            textBox_border_zone_middle.Text = middle_border.ToString("F4");
            textBox_border_zone_near.Text = border_to_near_zone.ToString("F4");
            textBox_lyamda.Text = lyamda.ToString("F4");

            double to_rad = Math.PI / 180;

            if (r >= border_to_far_zone)
            {
                for (int teta = 1; teta <= 360; teta++)
                {
                    chart_polar.Series[0].Points.AddXY(teta, Em_teta_FAR(lyamda, teta * to_rad, r).Magnitude);
                    chart_dekart.Series[0].Points.AddXY(teta, H_phi_FAR(lyamda, teta * to_rad, r).Magnitude);
                }
            }
            else if (r <= border_to_near_zone)
            {
                for (int teta = 1; teta <= 360; teta++)
                {
                    chart_polar.Series[0].Points.AddXY(teta, Em_teta_NEAR(lyamda, teta * to_rad, r).Magnitude);
                    chart_dekart.Series[0].Points.AddXY(teta, Hm_phi_NEAR(lyamda, teta * to_rad, r).Magnitude);
                }
            }
            else
            {
                for (int teta = 1; teta <= 360; teta++)
                {
                    chart_polar.Series[0].Points.AddXY(teta, Em_teta(lyamda, teta * to_rad, r).Magnitude);
                    chart_dekart.Series[0].Points.AddXY(teta, Em_phi(lyamda, teta * to_rad, r).Magnitude);
                }
            }
        }

        Complex Emr(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(Math.Pow((1 / (k * r)), 2), Math.Pow((-1 / (k * r)), 3));
            number *= new Complex(Math.Cos(-k * r), Math.Sin(-k * r));
            Complex Emr = (Im * l * Math.Pow(k, 3)) / (2 * Math.PI * w * e) * number * Math.Cos(teta);
            return Emr;
        }
        Complex Emr_NEAR(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(Math.Cos(-k * r - Math.Atan(1 / (k * r))), Math.Sin(-k * r - Math.Atan(1 / (k * r))));
            double sqrt = Math.Sqrt(Math.Pow(1 / (k * r), 4) + Math.Pow(1 / (k * r), 6));
            Complex Emr = 2 * E0(lyamda) * sqrt * number * Math.Cos(teta);
            return Emr;
        }

        Complex Em_teta(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(1 / (k * r) - Math.Pow((1 / (k * r)), 3), -Math.Pow((1 / (k * r)), 2));
            number *= new Complex(Math.Cos(-k * r), Math.Sin(-k * r));
            Complex Em_teta = (Im * l * Math.Pow(k, 3)) / (4 * Math.PI * w * e) * number * Math.Sin(teta);
            return Em_teta;
        }
        Complex Em_teta_FAR(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(Math.Cos(-k * r), Math.Sin(-k * r));
            Complex Em_teta = (Im * l * k) / (4 * Math.PI * w * e * r) * number * Math.Sin(teta);
            return Em_teta;
        }
        Complex Em_teta_NEAR(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(Math.Cos(-k * r + Math.PI / 2 - Math.Atan((k * r) / (k * k * r * r - 1))), Math.Sin(-k * r + Math.PI / 2 - Math.Atan((k * r) / (k * k * r * r - 1))));
            double sqrt = Math.Sqrt(Math.Pow((1 / (k * r) - Math.Pow(1 / (k * r), 3)), 2) + Math.Pow(1 / (k * r), 4));
            Complex Em_teta = E0(lyamda) * sqrt * number * Math.Sin(teta);
            return Em_teta;
        }

        Complex Em_phi(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            double real = Im * l * Math.Pow(k, 2) / (4 * Math.PI) * Math.Pow((1 / (k * r)), 2);
            double imaginary = Im * l * Math.Pow(k, 2) / (4 * Math.PI) * (1 / (k * r));
            Complex number = new Complex(real, imaginary);
            number *= new Complex(Math.Cos(-k * r), Math.Sin(-k * r));
            Complex Em_phi = number * Math.Sin(teta);
            return Em_phi;
        }
        Complex Hm_phi_NEAR(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(Math.Cos(-k * r + Math.PI / 2 - Math.Atan(1 / (k * r))), Math.Sin(-k * r + Math.PI / 2 - Math.Atan(1 / (k * r))));
            double sqrt = Math.Sqrt(Math.Pow(1 / (k * r), 2) + Math.Pow(1 / (k * r), 4));
            Complex Em_teta = H0(lyamda) * sqrt * number * Math.Sin(teta);
            return Em_teta;
        }


        double E0(double lyamda)
        {
            double k = 2 * Math.PI / lyamda;
            return Im * l * Math.Pow(k, 2) / (4 * Math.PI) * Math.Sqrt(nu / e);
        }

        double H0(double lyamda)
        {
            double k = 2 * Math.PI / lyamda;
            return Im * l * Math.Pow(k, 2) / (4 * Math.PI);
        }

        double Er(double lyamda, double t, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            double E_0 = E0(lyamda);
            return 2 * E_0 * Math.Sqrt(Math.Pow((1 / (k * r)), 4) + Math.Pow((1 / (k * r)), 6)) * Math.Cos(w * t - k * r - Math.Atan(1 / (k * r))) * Math.Cos(teta);
        }

        double E_teta(double lyamda, double t, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            double E_0 = E0(lyamda);
            double sqrt = Math.Sqrt(Math.Pow((1 / (k * r) - Math.Pow(1 / (k * r), 3)), 2) + Math.Pow(1 / (k * r), 4));
            return E_0 * sqrt * Math.Cos(w * t - k * r + Math.PI / 2 - Math.Atan(k * r / (k * k * r * r - 1))) * Math.Sin(teta);
        }

        double Direction_Point(double lyamda, double teta, double max_function)
        {
            double k = 2 * Math.PI / lyamda;
            return (Math.Cos(k * l * Math.Cos(teta)) - Math.Cos(k * l)) / (max_function * Math.Sin(teta));
        }

        double H_phi(double lyamda, double t)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            double r = 1;
            double teta = 0;
            double H_0 = H0(lyamda);
            return H_0 * Math.Sqrt(Math.Pow((1 / (k * r)), 2) + Math.Pow((1 / (k * r)), 4)) * Math.Cos(w * t - k * r - Math.Atan(1 / (k * r))) * Math.Sin(teta);
        }
        Complex H_phi_FAR(double lyamda, double teta, double r)
        {
            double k = 2 * Math.PI / lyamda;
            double w = 2 * Math.PI * f;

            Complex number = new Complex(0, (Im * l * k) / (4 * Math.PI * r));
            return number * new Complex(Math.Cos(-k * r), Math.Sin(-k * r)) * Math.Sin(teta);
        }

        private void button_solve_Click(object sender, EventArgs ev)
        {
            double l = 0, Im = 0, e = 0, nu = 0, f = 0;
            try
            {
                l = Convert.ToDouble(textBox_l.Text);
                Im = Convert.ToDouble(textBox_Im.Text);
                e = Convert.ToDouble(textBox_e.Text);
                nu = Convert.ToDouble(textBox_nu.Text);
                f = Convert.ToDouble(textBox_f.Text);
                if (l <= 0 || Im <= 0 || e <= 0 || nu <= 0 || f <= 0)
                {
                    MessageBox.Show("Please, enter the positive number");
                }
                else
                {
                    Solve(l, Im, e, nu, f * 1000000);
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please, enter number less than this");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter number");
            }

        }
    }
}
