namespace task12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        Random g = new Random();
        Random b = new Random();

        Random xL = new Random();
        Random yL = new Random();
        int count = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            label2.Text = count.ToString();

            Panel p = new Panel();
            p.Size = new Size(60, 60);
            p.Location = new Point(xL.Next(0, 700), yL.Next(0, 280));
            p.BackColor = Color.FromArgb(r.Next(0, 256), g.Next(0, 256), b.Next(0, 256));
            this.Controls.Add(p);
            p.BringToFront();

            if (p.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                DialogResult cavab = MessageBox.Show("Oyun bitdi!, Xalınız: " + count);

                if (cavab == DialogResult.OK)
                {
                    Application.Restart();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(xL.Next(0, 700), yL.Next(0, 280));
        }
    }
}
