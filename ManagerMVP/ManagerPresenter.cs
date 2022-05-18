using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public class ManagerPresenter
    {
        private readonly ManagerModel Model;
        private readonly ManagerForm View;
        public ManagerPresenter(ManagerForm view, ManagerModel model)
        {
            Model = model;
            View = view;
        }
        public List<Panel> Aprovement(string BID, TableLayoutPanel tb)
        {
            return Model.Aprovement(BID, tb);
        }

        public List<Panel> InitializeCreditRequest(string BID, TableLayoutPanel tb)
        {
            return Model.InitializeCreditRequest(BID, tb);
        }

        public List<Panel> InitializeInstallementRequest(string BID, TableLayoutPanel tb)
        {
            return Model.InitializeInstallementRequest(BID, tb);
        }
        public List<Panel> InitializeTransferRequest(Manager manager, TableLayoutPanel tb)
        {
            return Model.InitializeTransferRequest(manager, tb);
        }
        public List<Panel> InitializeSPRequest(string BID, TableLayoutPanel tb)
        {
            return Model.InitializeSPRequest(BID, tb);
        }
    }
}
