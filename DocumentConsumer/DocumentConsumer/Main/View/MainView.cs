using System;
using System.Collections.Generic;
using System.Linq;
using DocumentConsumer.Main.Handler;
using System.Windows.Forms;

namespace DocumentConsumer.Main.View
{
    public partial class MainView : Form, IMainView
    {
        private IMainHandler _mainHandler;

        public MainView()
        {
            InitializeComponent();
        }

        public void SetMainHandler(IMainHandler mainHandler)
        {
            _mainHandler = mainHandler;
        }

        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        public void UpdateStatusBarConnection(string text)
        {
            tsslConnection.Text = text;
        }

        public void EnableDocumentButtons(bool enable)
        {
            btnDocumentReference.Enabled = enable;
            btnDocumentManifest.Enabled = enable;
        }

        public void FillResults<T>(List<T> results)
        {
            dgvResults.DataSource = results;
        }

        public void FillOutput(string output)
        {
            txtOutput.Text = output;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleConnect(txtFhirServer.Text);
        }

        private void btnDocumentReference_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleDocumentReference(txtSubject.Text);
        }

        private void btnDocumentManifest_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleDocumentManifest(txtSubject.Text);
        }

        private void dgvResults_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in from DataGridViewRow r in dgvResults.Rows
                from DataGridViewColumn c in dgvResults.Columns
                where "Location".Equals(c.Name)
                select r)
            {
                r.Cells["Location"] = new DataGridViewLinkCell();
            }

            foreach (DataGridViewRow r in from DataGridViewRow r in dgvResults.Rows
                from DataGridViewColumn c in dgvResults.Columns
                where "Content".Equals(c.Name)
                select r)
            {
                r.Cells["Content"] = new DataGridViewLinkCell();
            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
            {
                _mainHandler.HandleCellClick(dgvResults.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
            }
        }
    }
}