using DocumentConsumer.Main.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
