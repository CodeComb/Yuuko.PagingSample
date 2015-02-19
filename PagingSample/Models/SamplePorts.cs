using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeComb.Yuuko;
using CodeComb.Yuuko.Schema;

namespace PagingSample.Models
{
    public class SamplePorts : PortsContext
    {
        public SamplePorts()
        {
            ArticleSource = new List<Article>();
            for(var i = 1; i <= 25; i ++)
                ArticleSource.Add(new Article { Title = "Article " + i, Time = Convert.ToDateTime("2015-2-18"), Content = "Lorem ipsum dolor sit er elit lamet, consectetaur cillium adipisicing pecu, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Nam liber te conscient to factor tum poen legum odioque civiuda." });
        }

        // Data source
        [OrderBy("Time desc")]
        [Paging(10)]
        public List<Article> ArticleSource { get; set; }

        // Port
        [CollectionPort]
        [Binding("ArticleSource")]
        public List<Article> ArticlePort { get; set; }
    }
}