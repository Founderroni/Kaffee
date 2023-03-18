using System;
using System.Windows.Forms;

namespace KaffeeUtility
{
    public partial class Loader : Form
    {
        public Loader() =>
            InitializeComponent();

        private async void Main_Load(object sender, EventArgs e)
        {
            var LoaderTask = await Utils.Loader.LoaderTask();
            if (LoaderTask == "Complete")
            {
                Hide();
                new Dashboard().Show();
            } else
                MessageBox.Show($"An error occured, it will be printed below:\n{LoaderTask}", "Loader Error");
        }
    }
}
