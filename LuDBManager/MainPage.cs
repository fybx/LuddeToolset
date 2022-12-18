using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuddeToolset;

namespace LuDBManager
{
    public partial class MainPage : Form
    {
        public Database Database { get; private set; }

        private bool animate = false;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Event_ConnectDatabase(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".db",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "(*.db)|*.db"
            };
            OpenFileDialog ofd2 = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".keystore",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Filter = "(*.keystore)|*.keystore"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                animate = true;
                Task task = new Task(new Action(this.AnimateLoading));
                task.Start();
                Database = new Database();
            }
        }

        private void Event_CloseDatabase(object sender, EventArgs e)
        {

        }

        private void Event_SaveDatabase(object sender, EventArgs e)
        {

        }

        private void AnimateLoading()
        {
            if (animate)
            {
                progressBar1.Increment(5);
                Label_Loading.Text = @"Loading";
            }
        }
    }
}
