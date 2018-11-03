using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var article = new MarkdownNet.Models.ArticleModel();
            article.ArticleName = "評価仕様書兼成績書";
            article.Title = "タイトル";
            article.SubTitle = "サブタイトル";
            article.Content = "ddddd,ddddd,dddddd,dddddf,,,ddddd,\r\nddddd,ddddd,dddddd,dddddf,,,ddddd,";

            MarkdownNet.GenerateMarkdown.CreateMarkdown(article);
        }
    }
}
