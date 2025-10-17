using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class NewsFeed_JMJL
    {
        private List<Post_JMJL> posts_JMJL;

        public NewsFeed_JMJL()
        {
            posts_JMJL = new List<Post_JMJL>();
        }

        public void AddPost_JMJL(Post_JMJL post_JMJL)
        {
            posts_JMJL.Add(post_JMJL);
        }

        public List<Post_JMJL> GetPosts_JMJL()
        {
            return posts_JMJL;
        }

        override
            public String ToString()
        {
            String tmp_JMJL = "";
            foreach (Post_JMJL p in posts_JMJL)
            {
                // display all text posts
                tmp_JMJL += p.ToString() + "\n";
            }
            return tmp_JMJL;
        }
    }
}
