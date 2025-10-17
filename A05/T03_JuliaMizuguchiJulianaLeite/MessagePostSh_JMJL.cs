using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class MessagePostSh_JMJL
    {
        String username_JMJL;
        String message_JMJL;
        long timestamp_JMJL;
        int likes_JMJL;
        List<String> comments_JMJL;

        public MessagePostSh_JMJL(String username_JMJL,
        String message_JMJL)
        {
            this.username_JMJL = username_JMJL;
            this.message_JMJL = message_JMJL;
            timestamp_JMJL =
            System.DateTime.Now.Millisecond;
            likes_JMJL = 0;
            comments_JMJL = new List<String>();
        }
        public MessagePostSh_JMJL() : this("Anónimo", "Vazio") { }
        public void like()
        {
            likes_JMJL++;
        }
        public void unlike()
        {
            if (likes_JMJL > 0)
            {
                likes_JMJL--;
            }
        }

        public void AddComment(String text)
        {
            comments_JMJL.Add(text);
        }
        public String GetText()
        {
            return message_JMJL;
        }
        // sem private => PRIVATE! em C#
        private String timeString(long time)
        {
            long current =
            System.DateTime.Now.Millisecond;
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
            String tmp = username_JMJL
                        + "\n    " + message_JMJL
                        + "\n";
            tmp += "     " + timeString(timestamp_JMJL)
            + "\n";
            if (likes_JMJL > 0)
            {
                tmp += " - " + likes_JMJL
                + " people like this.";
            } else
            {
                tmp += "";
            }
            if (comments_JMJL.Count == 0)
            { 
                    tmp += "        No comments.";
            } else
            {
                tmp += "        " + comments_JMJL.Count +
                " comment(s). Click here to view.";
            }
            return tmp + "\n";
        }

    }
}
