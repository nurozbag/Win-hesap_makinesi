namespace hesapmak
{
    public partial class Form1 : Form
    {
      
        bool oprtislm = false;
        double sonuc = 0;
        string oprt = "";
    
        
        
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {    
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {    
        }

        private void button8_Click(object sender, EventArgs e)
        { 
        }

        private void button7_Click(object sender, EventArgs e)
        {
        

        }

        private void button6_Click(object sender, EventArgs e)
        {
 

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
 
        }

        private void oprthesap(object sender, EventArgs e)
        {
            Button bttn=(Button)sender;
            string yeniorpt=bttn.Text;
            label2.Text = label2.Text + " " + textBox1.Text + " " + yeniorpt;
            switch (oprt)
            {
                case "+":textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString();break;
                case "-":textBox1.Text=(sonuc-Double.Parse(textBox1.Text)).ToString();break;
                case "x":textBox1.Text=(sonuc*Double.Parse(textBox1.Text)).ToString();break;
                case "/":textBox1.Text=(sonuc/Double.Parse(textBox1.Text)).ToString();break;

            }
            sonuc=Double.Parse(textBox1.Text);
            oprtislm = true;
            textBox1.Text=sonuc.ToString();
            oprt = yeniorpt;
        }

        private void rakamlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || oprtislm)
                textBox1.Clear();
            oprtislm=false;
            Button bttn=(Button)sender;
            textBox1.Text+=bttn.Text;
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";
            oprt = "";
            sonuc = 0;
            oprtislm = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            oprtislm = true;
            switch (oprt)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "x": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;

            }
            sonuc=double.Parse(textBox1.Text);
            textBox1.Text=sonuc.ToString();
            sonuc = 0;
            oprt = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text="0";

            }
            else if (oprtislm)
            {
                textBox1.Text = "0";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            oprtislm=false;
        }
    }
}