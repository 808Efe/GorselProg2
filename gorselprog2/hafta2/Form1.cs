namespace hafta2
{
    public partial class Form1 : Form
    {
        private Button draggableButton;
        private bool isDragging = false;
        private Point clickOffset;

        public Form1()
        {
            InitializeComponent();

            draggableButton = new Button();
            draggableButton.Text = "Drag";
            draggableButton.Size = new Size(100, 50);
            draggableButton.Location = new Point(150, 100);


            draggableButton.MouseDown += DraggableButton_MouseDown;
            draggableButton.MouseMove += DraggableButton_MouseMove;
            draggableButton.MouseUp += DraggableButton_MouseUp;


            this.Controls.Add(draggableButton);
        }

        private void DraggableButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                clickOffset = e.Location;
            }
        }

        private void DraggableButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = draggableButton.Location;
                newLocation.X += e.X - clickOffset.X;
                newLocation.Y += e.Y - clickOffset.Y;

                draggableButton.Location = newLocation;
            }
        }

        private void DraggableButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
