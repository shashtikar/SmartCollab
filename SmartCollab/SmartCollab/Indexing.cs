using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public class Indexing
    {

        Lucene.Net.Store.Directory luceneWorkingSet;
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

        public int indexService(int tenant_id, String serviceURL, String description)
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

        public int indexRequirements(String description, int tenant_id)
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
