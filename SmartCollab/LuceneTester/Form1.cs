using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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



namespace LuceneTester
{
    public partial class Form1 : Form
    {
        Lucene.Net.Store.Directory luceneWorkingSet;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         String indexPath = @"inputFileFS";
            if (System.IO.Directory.Exists(indexPath))
            {
            System.IO.Directory.Delete(indexPath, true);
            }

           luceneWorkingSet = FSDirectory.Open(indexPath);

           StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

           IndexWriter writer = new IndexWriter(luceneWorkingSet, analyzer, true, IndexWriter.MaxFieldLength.LIMITED);

           StreamReader reader = new StreamReader(@"InputFS\sampleText.txt");

           Document doc = new Document();

            //Start Here

           doc.Add(new Field("lyrics", reader.ReadToEnd(), Field.Store.YES,Field.Index.ANALYZED));
           doc.Add(new Field("songName", "Tonight", Field.Store.YES, Field.Index.NOT_ANALYZED));

           writer.AddDocument(doc);
           writer.Optimize();
           
           writer.Dispose();
           luceneWorkingSet.Dispose();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string indexPath = @"inputFileFS";
            IndexSearcher searcher = new IndexSearcher(FSDirectory.Open(indexPath));
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30,"lyrics", new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30));

            Query query = parser.Parse(searchTerm.Text.Trim());

            TopDocs topResults = searcher.Search(query, 10);

            
            ScoreDoc[] topHits = topResults.ScoreDocs;
            String[] docList = new String[10];

            for (int i = 0; i < topHits.Length; i++)
            {
                int docsId = topHits[i].Doc;
                Document d = searcher.Doc(docsId);
                docList[i] = d.Get("songName");
            }
          //  MessageBox.Show(topHits.Length.ToString());
          
            MessageBox.Show(docList[0]);


            

            //StandardAnalyzer analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

        }


        
    }
}
