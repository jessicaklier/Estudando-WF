using System;
using System.Windows.Forms;

namespace SimpleVSWinFormsApp
{
    public partial class MainWindow : Form
    {
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
        public MainWindow()
        {
            InitializeComponent();
            CenterToScreen();
            FormClosing += new FormClosingEventHandler(MainWindow_Closing);
            Load += new EventHandler(MainWindow_Load);
            FormClosed += new FormClosedEventHandler(MainWindow_Closed);
            Activated += new EventHandler(MainWindow_Activated);
            Deactivate += new EventHandler(MainWindow_Deactivate);
            
        }

        private string lifeTimeInfo = "";

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {

            lifeTimeInfo += "Deactive event \n";
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            lifeTimeInfo += "Activated event \n";
        }

        private void MainWindow_Closed(object sender, FormClosedEventArgs e)
        {
            lifeTimeInfo += "FormClosed event \n";
            MessageBox.Show(lifeTimeInfo);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lifeTimeInfo += "Load event \n";
        }

        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            lifeTimeInfo += "FormClosing event \n";
            // Exiba uma caixa de mensagem com os botoes yes/no
            DialogResult dr = MessageBox.Show("Do you Readlly want to close this app?",
                "FormClosing event!", MessageBoxButtons.YesNo);

            // qual o botão foi clicado
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }
    }
}
