using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void initialize()
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //FilterEngine.DataFilterSoapClient fe = new FilterEngine.DataFilterSoapClient();
            //MessageBox.Show(fe.filterString("BhagLuke"));


        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.initialize();

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String url = serviceURL.Text;
            String desc = serv_desc.Text;

            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(MessageRender(sc.publishMyService(int.Parse(tenant_id.Text.ToString()), url, desc)));

        }

        public String MessageRender(int messageCode)
        {
            if (messageCode == 400)
            {
                return "The action could not be completed";
            }
            else
            {
                return "Success !!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(MessageRender(sc.publishMyRequirements(reqKW.Text, int.Parse(tenant_id.Text))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(sc.searchService(searchServ.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(sc.searchRequirement(searchReq.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(MessageRender(sc.unpublishReq(int.Parse(tenant_id.Text.ToString()), int.Parse(requirement_id.Text))));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(MessageRender(sc.unpublish_service(int.Parse(serv_id.Text),int.Parse(tenant_id.Text.ToString()))));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(MessageRender(sc.republishService(int.Parse(repubServ.Text),int.Parse(tenant_id.Text.ToString()))));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            servSubRslt.Text = String.Join(",",sc.getServiceSubscriber(int.Parse(subListServ.Text)).ToArray());
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            reqSubRslt.Text = String.Join(",", sc.getRequirementSubscriber(int.Parse(reqSubList.Text)).ToArray());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            MessageBox.Show(sc.getRequirementsOwner(int.Parse(reqOwner.Text)).ToString());

        }

        private void button11_Click(object sender, EventArgs e)
        {
            SmartCollabRef.DataFilterSoapClient sc = new SmartCollabRef.DataFilterSoapClient();
            ownRslt.Text = String.Join(",", sc.getOwnedServiceList(int.Parse(ServOwn.Text)).ToArray());

        }





    }
}