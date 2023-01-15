using System.Diagnostics;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<Student> list = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string id = textBox_ID.Text;
            string year = textBox_yaer.Text;
            string height = textBox_body.Text;
            string grade = textBox_grad.Text;
            string major = textBox_major.Text;

            int Year = Int32.Parse(year);
            double Grade = Double.Parse(grade);

            Student newStudent = new Student(name, id, Year, height, Grade, major);
            this.list.Add(newStudent);



            BindingSource source = new BindingSource();
            source.DataSource = this.list;
            this.all.DataSource = source;

            this.textBox_name.Text = "";
            this.textBox_ID.Text = "";
            this.textBox_yaer.Text = "";
            this.textBox_body.Text = "";
            this.textBox_grad.Text = "";
            this.textBox_major.Text = "";

 
            all_min1.Text = (from DataGridViewRow row in all.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double max = 0;
            for (int i = 1; i <= all.Rows.Count - 1; i++)
            {
                if (max < double.Parse(all.Rows[i].Cells[1].Value.ToString()))
                {
                    max = double.Parse(all.Rows[i].Cells[1].Value.ToString());
                }
            }

            all_min1.Text = max.ToString();

            double[] cmax = new double[all.Rows.Count];
            cmax = (from DataGridViewRow row in all.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            all_min1.Text = cmax.Max().ToString();
            //

            all_min2.Text = (from DataGridViewRow row in all.Rows
                             where row.Cells[1].FormattedValue.ToString() != string.Empty
                             select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double min = 0;
            for (int i = 1; i <= all.Rows.Count - 1; i++)
            {
                if (min < double.Parse(all.Rows[i].Cells[1].Value.ToString()))
                {
                    min = double.Parse(all.Rows[i].Cells[1].Value.ToString());
                }
            }

            all_min2.Text = max.ToString();

            double[] cmin = new double[all.Rows.Count];
            cmin = (from DataGridViewRow row in all.Rows
                    where row.Cells[1].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            all_min2.Text = cmin.Min().ToString();
            int bts = all.Rows.Count;
            all_min3.Text = bts.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}