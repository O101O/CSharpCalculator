namespace Dynamic;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void  Form1_Load(object sender, EventArgs e)
    {
        string[][] keys = [["7", "8","9","+"],["4","5","6","-"],["1","2","3","*"],["0",".","=","/"],["sqrt","^","%","EX"]];
        for (int i = 0; i < keys.Length; i++)
        {
            for (int j = 0; j < keys[i].Length; j++)
            {
                Button btn = new Button();
                btn.Text = keys[i][j];
                btn.Location = new Point(10+(i*60),10+(j*60));
                btn.Size = new Size(50, 50);
                btn.Click += btn_Click;
                this.Controls.Add(btn);
            }
            
        }

             // Label label = new Label();
        // label.Text = "Hello World!";
        // label.Location = new Point(10, 10);
        // label.AutoSize = true;
        // this.Controls.Add(label);
        //
        // Button button = new Button();
        // button.Text = "click";
        // button.Location = new Point(10, 50);
        // button.Size = new Size(100, 100);
        // this.Controls.Add(button);
        
    }
    private void btn_Click(object sender, EventArgs e)
    {
            Button btn = (Button)sender;
            
            
    }  
}