using System;
using System.Collections.Generic;
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleConnect(txtFhirServer.Text);
        }

        private void btnDocumentReference_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleDocumentReference(txtPatientId.Text);
        }

        private void btnDocumentManifest_Click(object sender, EventArgs e)
        {
            _mainHandler.HandleDocumentManifest(txtPatientId.Text);
        }

        

    }
}
