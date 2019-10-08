using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorrisWinForms
{
    public partial class frmNorrisJokes : Form
    {
        public frmNorrisJokes()
        {
            InitializeComponent();
        }

        private void FrmNorrisJokes_Load(object sender, EventArgs e)
        {
            PopulateCategoriesAsync();
        }

        private async void PopulateCategoriesAsync()
        {
            cboCategories.DataSource = await ChuckNorrisClient.GetCategories();
        }

        private async void BtnGetJoke_ClickAsync(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            MessageBox.Show(j.JokeText);
        }
    }
}
