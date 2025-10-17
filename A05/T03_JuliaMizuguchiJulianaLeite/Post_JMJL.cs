using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class Post_JMJL
    {
        String username_JMJL;
        long timestamp_JMJL;
        int likes_JMJL;
        List<String> comments_JMJL;

        public Post_JMJL(String username_JMJL)
        {
            this.username_JMJL = username_JMJL;
            timestamp_JMJL =
            System.DateTime.Now.Millisecond;
            likes_JMJL = 0;
            comments_JMJL = new List<String>();
        }
        
        public Post_JMJL() : this("Anónimo") { }

        public void Like_JMJL() { likes_JMJL++; }
        public void Unlike_JMJL()
        {
            if (likes_JMJL > 0)
            {
                likes_JMJL--;
            }
        }

        public void AddComment(String text) { comments_JMJL.Add(text); }

        private String timeString(long time)
        {
            long current = System.DateTime.Now.Millisecond;
            long pastMillis = current - time;
            long seconds = pastMillis / 1000;
            long minutes = seconds / 60;
            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
        override public String ToString()
        { 
            String tmp_JMJL = username_JMJL + " *** \n" + " " + timeString(timestamp_JMJL) + "\n";
            if (likes_JMJL > 0)
            {
            tmp_JMJL += " - " + likes_JMJL + " people like this.";
            }
            else
            {
            tmp_JMJL += "";
            }
            if (comments_JMJL.Count == 0)
            { 
                    tmp_JMJL += " No comments.";
            }
            else
            {
                tmp_JMJL += " " + comments_JMJL.Count + " comment(s).";
                foreach (String c in comments_JMJL)
                {
                    tmp_JMJL += "\n      " + c + " ";
                }
            }
            return tmp_JMJL + "\n";
        }
    }
}
