namespace Restaurant_Table_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false) {
                menuContainer.Height += 18;
                if(menuContainer.Height >= 165)
                {
                    menuTransition.Stop ();
                    menuExpand = false;
                }
            }
            else
            {
                menuContainer.Height -= 18;
                if(menuContainer.Height <= 53)
                {
                    menuTransition.Stop ();
                    menuExpand = true;
                }
            }
        }
    }
}