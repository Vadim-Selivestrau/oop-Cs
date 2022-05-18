using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1
{
    public class ClientPresenter
    {
        private readonly ClientModel Model;
        private readonly ClientForm View;

        public ClientPresenter(ClientForm view, ClientModel model)
        {
            Model = model;
            View = view;
        }
        public List<string> BankInit()
        {
            return Model.BankInit();
        }

        public Client ClientUpdate(Client client)
        {
            return Model.ClientUpdate(client);
        }

        public string BankIndex(string bankNBID)
        {
            return Model.BankIndex(bankNBID);
        }

        public void CreateBill(Client client, string bank, string billNumber)
        {
            Model.CreateBill(client, bank, billNumber);
        }

        public List<string> BillInit(Client client)
        {
            return Model.BillInit(client);
        }


    }
}
