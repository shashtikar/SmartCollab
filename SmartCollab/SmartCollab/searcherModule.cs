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
using Lucene.Net.Analysis.Reverse;


namespace SmartCollab
{
    public class searcherModule
    {
        public int hitCounter(String kw)
        {
            Lucene.Net.Store.Directory dir = new RAMDirectory();
            IndexSearcher searcher = new IndexSearcher(dir);

            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "description", new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));
            Query query = parser.Parse("+"+kw);

            //10 is the number of top results 
            TopDocs topResults = searcher.Search(query, 10);
            ScoreDoc[] topHits = topResults.ScoreDocs;
            String[] docList =  new String[10];

            for (int i = 0; i < topHits.Length; i++)
            {
                int docsId = topHits[i].Doc;
                Document d = searcher.Doc(docsId);
                docList[i] = d.Get("serviceID");
            }
            return topHits.Length;
        }

    }
}