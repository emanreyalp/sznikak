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

namespace WinFormsHF
{
    public partial class Form1 : Form
    {
        FileInfo loadedFile = null;
        int countdown = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string result = dlg.InputText;

                MessageBox.Show(result);

                DirectoryInfo parentDI = new DirectoryInfo(result);
                listView1.Items.Clear();
                try
                {
                    foreach (FileInfo fi in parentDI.GetFiles())
                    {
                        listView1.Items.Add(new ListViewItem(new string[] { fi.Name,
						fi.Length.ToString(), fi.LastWriteTime.ToString(), fi.FullName }));
                    }


                }
                catch { }

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1) return;
            string fullName = listView1.SelectedItems[0].SubItems[3].Text;
            if (fullName != null)
            {
                textBox1.Text = File.ReadAllText(fullName);
                reloadTimer.Start();
                countdown = 100;
                loadedFile = new FileInfo(fullName);
                lCreated.Text = loadedFile.CreationTime.ToString();
                lName.Text = loadedFile.Name.ToString();
            }
        }

        private void detailsPanel_Paint(object sender, PaintEventArgs e)
        {
            if (loadedFile == null)
                return;

            e.Graphics.FillRectangle(Brushes.Green, 0, 0, countdown, 5);
        }

        private void reloadTimer_Tick(object sender, EventArgs e)
        {
            countdown--;
            detailsPanel.Invalidate();
            if (countdown <= 0)
            {
                countdown = 100;
                textBox1.Text = File.ReadAllText(loadedFile.FullName);
            }
        }
    }
}
