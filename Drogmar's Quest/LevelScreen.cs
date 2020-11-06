using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drogmar_s_Quest
{
    public partial class LevelScreen : UserControl
    {
        public LevelScreen()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            EasyScreen es = new EasyScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(es);

            es.Focus();
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            MediumScreen ms = new MediumScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(ms);

            ms.Focus();
        }

        private void bossButton_Click(object sender, EventArgs e)
        {
            BossScreen bs = new BossScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(bs);

            bs.Focus();
        }

        private void bossButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = false;
            normalUnderline.Visible = false;
            bossUnderline.Visible = true;
        }

        private void normalButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = false;
            normalUnderline.Visible = true;
            bossUnderline.Visible = false;
        }

        private void easyButton_Enter(object sender, EventArgs e)
        {
            easyUnderline.Visible = true;
            normalUnderline.Visible = false;
            bossUnderline.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            Form form = this.FindForm();

            form.Controls.Remove(this);
            form.Controls.Add(ms);

            ms.Focus();
        }
    }
}
