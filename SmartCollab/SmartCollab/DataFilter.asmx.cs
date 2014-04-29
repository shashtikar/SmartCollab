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

namespace SmartCollab
{
    /// <summary>
    /// Summary description for DataFilter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataFilter : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public string filterString(String input)
        {
            return "Hello";
        }

        [WebMethod]
        public void searchKeyword(String keyString)
        {
            StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            System.IO.Directory.CreateDirectory("IndexFS");
            System.IO.FileStream index = System.IO.File.Create(@"IndexFS\index.sha");
            Lucene.Net.Store.Directory index1 = new RAMDirectory();
            IndexWriter iw = new IndexWriter(index1, analyzer, true, IndexWriter.MaxFieldLength.LIMITED);
              

            String fileName = "index";
            String pathString = System.IO.Path.Combine("indexFS",fileName);

            Document doc = new Document();
            StreamReader reader = new StreamReader(@"IndexFS\index.sha");

            
            doc.Add(new Field("description", reader));
            doc.Add(new Field("serviceID", "12345", Field.Store.YES, Field.Index.ANALYZED));

            iw.AddDocument(doc);
            iw.Optimize();
            iw.Dispose();
        }

        [WebMethod]
        public int searchResult(String keyword)
        {

            searcherModule sm = new searcherModule();

            return sm.hitCounter(keyword);
        
        }

    }
}
