using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB1
{
    public partial class Utils : Form
    {
        int count = 0;
        Random rnd;
        public Utils()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFO1\nINFO2", "About");
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            int result;

            if ((Convert.ToInt32(numericUpDown2.Value) - Convert.ToInt32(numericUpDown1.Value) < Convert.ToInt32(numericUpDown3.Value)) && chkbxWORepit.Checked)
            {
                MessageBox.Show("Increase boundaries or reduce the amount of numbers or uncheck \"W/o repetition\" ", "Error");

            }

            else
            {

                int countOfNums = Convert.ToInt32(numericUpDown3.Value);
                int[] nums = new int[countOfNums];

                for (int i = 0; i < countOfNums; i++)
                {
                    result = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    lblResult.Text = result.ToString();

                    if (chkbxWORepit.Checked)
                    {

                        if (Array.IndexOf(nums, result) == -1)
                            nums[i] = result;

                        else
                            i--;

                    }
                    else
                        nums[i] = result;
                }

                foreach (var item in nums)
                {
                    txtbx.AppendText(item + " ");
                }

            }
        }

        private void txtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtbx.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtbx.Text))
                Clipboard.SetText(txtbx.Text);
        }

    }
}
