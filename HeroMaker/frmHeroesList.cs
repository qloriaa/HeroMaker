using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class frmHeroesList : Form
    {
        SuperHeroList heroList;

        public frmHeroesList()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Display list of heroes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmHeroesList_Load(object sender, EventArgs e)
        {
            // Get list of heroes from the Tag property
            heroList = (SuperHeroList)this.Tag;
            lblHeroStats.Text = "";

            // List the name of the heroes in list in the list box control
            foreach (SuperHero hero in heroList.HeroList)
            {
                lbHeroes.Items.Add(hero.Name);

            }

        }

        /// <summary>
        /// Display the stats of selected hero from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbHeroes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHeroes.SelectedIndex != -1)
            {
                int selectedItem = lbHeroes.SelectedIndex;

                SuperHero hero = heroList.HeroList[selectedItem];

                lblHeroStats.Text += hero.ToString();
                pbSymbol.ImageLocation = hero.SymbolFilePath;
                pbSymbol.Load(hero.SymbolFilePath);
            }
        }
    }
}
