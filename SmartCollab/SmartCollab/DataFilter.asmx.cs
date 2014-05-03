using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Lucene.Net.Search;
using Lucene.Net.Index;
using Lucene.Net.QueryParsers;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Util;
using Lucene.Net.Store;
using Lucene.Net.Documents;
using System.IO;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections;

namespace SmartCollab
{
    /// <summary>
    /// This is the service interface of the web service that would facilitate 
    /// collaboration amongst tenants.
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataFilter : System.Web.Services.WebService
    {
        Lucene.Net.Store.Directory luceneWorkingSet;

        [WebMethod]
        public String searchService(String keyword)
        {

            Indexing i = new Indexing();
            return i.searchService(keyword);            
        }

        [WebMethod]
        public String searchRequirement(String keyword)
        {
            Indexing i = new Indexing();
            return i.searchRequirement(keyword);
            

        }

        [WebMethod]
        public int republishService(int service_id, int tenant_id)
        {
            dataConn con = new dataConn();
            if (con.getServiceOwnerId(service_id) == tenant_id)
            {
                return con.republishService(service_id);
            }
            else
            {
                return 400;
            }
        }

        [WebMethod]
        public int unpublish_service(int service_id, int tenant_id)
        {
            dataConn con = new dataConn();
            if (con.getServiceOwnerId(service_id)==tenant_id)
            {
            return con.unpublishService(service_id);
            }
            else{
            return 400;
            }
        }
        
        [WebMethod]
        public int unpublishReq(int tenant_id, int req_id)
        {
            dataConn con = new dataConn();
            if (con.getReqOwnerId(req_id) == tenant_id)
            {
                return con.unpublish_req(req_id);

            }
            else
            {
                return 400;
            }
        }

        [WebMethod]
        public int getRequirementsOwner(int req_id)
        {
            dataConn con = new dataConn();
            return con.getReqOwnerId(req_id);
        }

        [WebMethod]
        public int publishMyService(int tenant_id, String serviceURL, String description)
        {
            Indexing i = new Indexing();
            return i.indexService(tenant_id, serviceURL, description);
        }

        [WebMethod]
        public ArrayList getOwnedServiceList(int tenant_id)
        {
            dataConn con = new dataConn();
            return con.getServiceList(tenant_id);
        }

        [WebMethod]
        public int bindService(int service_id, int tenant_id)
        {
           dataConn con = new dataConn();
            return con.bindService(service_id,tenant_id);
        }

        [WebMethod]
        public int bindRequirment(int req_id, int tenant_id)
        {
            dataConn con = new dataConn();
            return con.bindRequirement(req_id,tenant_id);        
        }

        [WebMethod]
        public ArrayList getServiceSubscriber(int service_id)
        {
            dataConn con = new dataConn();
            return con.getServiceSubscribers(service_id);
        }

        [WebMethod]
        public ArrayList getRequirementSubscriber(int req_id)
        {
            dataConn con = new dataConn();
            return con.getRequirementSubscribers(req_id);
        }




        [WebMethod]
        public int publishMyRequirements(String description, int tenant_id)
        {
            Indexing i = new Indexing();
           return i.indexRequirements(description, tenant_id);

        }

    }
}
