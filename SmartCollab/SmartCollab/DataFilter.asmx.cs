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

            dataConn con = new dataConn();
            string indexPath = @"C:\Users\Shashank\Documents\SD\Project\working\inputFileFS"; ;
            IndexSearcher searcher = new IndexSearcher(FSDirectory.Open(indexPath));
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "description", new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));

            Query query = parser.Parse(keyword);
            try
            {
                TopDocs topResults = searcher.Search(query, 10);

                ScoreDoc[] topHits = topResults.ScoreDocs;
                String[] docList = new String[10];

                for (int i = 0; i < topHits.Length; i++)
                {
                    int docsId = topHits[i].Doc;
                    Document d = searcher.Doc(docsId);
                    docList[i] = d.Get("serviceURL");
                }

                if (topHits.Length > 0 && (con.isPublished(docList[0])))
                {
                    return (docList[0]);
                }
                else
                {
                    return "noData";  
                }
            }
            catch
            {
                return "noData";
            }
            finally
            {
                searcher.Dispose();
            }
            
        }

        [WebMethod]
        public String searchRequirement(String keyword)
        {

            dataConn con = new dataConn();
            string indexPath = @"C:\Users\Shashank\Documents\SD\Project\working\inputFileFS"; ;
            IndexSearcher searcher = new IndexSearcher(FSDirectory.Open(indexPath));
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "req_description", new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));

            Query query = parser.Parse(keyword);
            try
            {
                TopDocs topResults = searcher.Search(query, 10);

                ScoreDoc[] topHits = topResults.ScoreDocs;
                String[] docList = new String[10];

                for (int i = 0; i < topHits.Length; i++)
                {
                    int docsId = topHits[i].Doc;
                    Document d = searcher.Doc(docsId);
                    docList[i] = d.Get("tenant_id");
                }

                if (topHits.Length > 0)
                {
                    return (docList[0]);
                }
                else
                {
                    return "noData";
                }
            }
            catch
            {
                return "noData";
            }
            finally
            {
                searcher.Dispose();
            }

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
            dataConn con = new dataConn();

            if (con.publishService(serviceURL, description, tenant_id) == 200)
            {
                String indexPath = @"C:\Users\Shashank\Documents\SD\Project\working\inputFileFS";
                
                if (!System.IO.Directory.Exists(indexPath))
                {
                    System.IO.Directory.CreateDirectory(indexPath);
                }

                luceneWorkingSet = FSDirectory.Open(indexPath);

                StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

                IndexWriter writer = new IndexWriter(luceneWorkingSet, analyzer, true, IndexWriter.MaxFieldLength.LIMITED);
                Document doc = new Document();

                doc.Add(new Field("description", description, Field.Store.YES, Field.Index.ANALYZED));
                doc.Add(new Field("serviceURL", serviceURL, Field.Store.YES, Field.Index.NOT_ANALYZED));

                writer.AddDocument(doc);
                writer.Optimize();

                writer.Dispose();
                luceneWorkingSet.Dispose();
                return 200;
            }

            else
            {
                return 400;
            }

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
            dataConn con = new dataConn();

            if (con.publish_requirement(description, tenant_id) == 200)
            {
                String indexPath = @"C:\Users\Shashank\Documents\SD\Project\working\inputFileFS";

                if (!System.IO.Directory.Exists(indexPath))
                {
                    System.IO.Directory.CreateDirectory(indexPath);
                }

                luceneWorkingSet = FSDirectory.Open(indexPath);

                StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

                IndexWriter writer = new IndexWriter(luceneWorkingSet, analyzer, true, IndexWriter.MaxFieldLength.LIMITED);
                Document doc = new Document();

                doc.Add(new Field("req_description", description, Field.Store.YES, Field.Index.ANALYZED));
                doc.Add(new Field("tenant_id", tenant_id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));

                writer.AddDocument(doc);
                writer.Optimize();

                writer.Dispose();
                luceneWorkingSet.Dispose();
                return 200;
            }

            else
            {
                return 400;
            }

        }

    }
}
