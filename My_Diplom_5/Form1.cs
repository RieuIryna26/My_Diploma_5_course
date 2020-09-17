using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variants;


namespace My_Diplom_5
{
    public partial class Form1 : Form
    {
        string RunningPath;

        private IVariant[] variants;
        private IVariant currentVariant;
        public Form1()
        {
            InitializeComponent(); ResetVariants();
            currentVariant = variants[0];
            RunningPath = AppDomain.CurrentDomain.BaseDirectory;

        }

        private void ResetVariants()
        {
            variants = new IVariant[11]
          {
                new Variant0(),
                new Variant1(),
                new Variant2(),
                new Variant3(),
                new Variant4(),
                new Variant5(),
                new Variant6(),
                new Variant7(),
                new Variant8(),
                new Variant9(),
                new Variant10(),
           };
        }

        private void comboBoxVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ResetVariants();
                int index = comboBoxVariant.SelectedIndex;
                currentVariant = variants[index];
                numUD_m.Value = Convert.ToDecimal(currentVariant.m);
                numUD_a.Value = Convert.ToDecimal(currentVariant.a);
                numUD_c.Value = Convert.ToDecimal(currentVariant.c);
                numUD_alfa.Value = Convert.ToDecimal(currentVariant.alpha);
                numUD_R.Value = Convert.ToDecimal(currentVariant.R);
                numUD_betta.Value = Convert.ToDecimal(currentVariant.betta);
                numUD_vA.Value = Convert.ToDecimal(currentVariant.vA);
                numUD_f.Value = Convert.ToDecimal(currentVariant.f);
                numUD_Delta0.Value = Convert.ToDecimal(currentVariant.delta0);
                numUD_tau.Value = Convert.ToDecimal(currentVariant.tau);  
                textBox_output.Text = currentVariant.Calculate();
                pictureBox1.Image = new Bitmap(string.Format($"{Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))}Resources\\{currentVariant.path}"));
                pictureBox2.Image = new Bitmap(string.Format($"{Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))}Resources\\{currentVariant.path2}"));
            }
            catch (Exception ex)
            {
                textBox_output.Text = ex.Message;
 
            }  

        }



        private void numUD_m_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                currentVariant.m = Convert.ToDouble(numUD_m.Value);
                currentVariant.a = Convert.ToDouble(numUD_a.Value);
                currentVariant.c = Convert.ToDouble(numUD_c.Value);
                currentVariant.alpha = Convert.ToDouble(numUD_alfa.Value);
                currentVariant.R = Convert.ToDouble(numUD_R.Value);
                currentVariant.betta = Convert.ToDouble(numUD_betta.Value);
                currentVariant.vA = Convert.ToDouble(numUD_vA.Value);
                currentVariant.f = Convert.ToDouble(numUD_f.Value);
                currentVariant.delta0 = Convert.ToDouble(numUD_Delta0.Value);
                currentVariant.tau = Convert.ToDouble(numUD_tau.Value);
                textBox_output.Text = currentVariant.Calculate();
                //currentVariant.path = Convert.ToDouble(pictureBox1.Image);//currentVariant.path = pictureBox1.Image;

            }
            catch (Exception ex)
            {
                textBox_output.Text = ex.Message;
                
            }
        }

        
    }
}