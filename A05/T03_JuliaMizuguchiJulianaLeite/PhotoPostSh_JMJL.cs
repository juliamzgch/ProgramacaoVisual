using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class PhotoPostSh_JMJL
    {
        String username_JMJL;
        String caption_JMJL;
        String filename_JMJL;
        long timestamp_JMJL;
        int likes_JMJL;
        List<String> comments_JMJL;

        public PhotoPostSh_JMJL(String username_JMJL,
        String caption_JMJL,
        String filename_JMJL)
        {
            this.username_JMJL = username_JMJL;
            this.filename_JMJL = filename_JMJL;
            this.caption_JMJL = caption_JMJL;
            timestamp_JMJL =
            System.DateTime.Now.Millisecond;
            likes_JMJL = 0;
            comments_JMJL = new List<String>();
        }
        public PhotoPostSh_JMJL() :
        this("Anónimo", "nocaption_JMJL", "noFile")
        {
        }
        public void Like()
        {
            likes_JMJL++;
        }
        public void Unlike()
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
        public String GetImageFile()
        {
            return filename_JMJL;
        }
        public String GetCaption_JMJL()
        {
            return caption_JMJL;
        }

        // sem private => PRIVATE! em C#
        String timeString(long time)
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
                        + "\n    [" + caption_JMJL
                        + "]\n";
            tmp += "    " + filename_JMJL
                          + "\n      "
                          + timeString(timestamp_JMJL)
                          + "\n";
            if (likes_JMJL > 0)
            {
                tmp += " - " + likes_JMJL
                + " people like this.";
            }
            else
            {
                tmp += "";
            }
            if (comments_JMJL.Count == 0)
            {
                tmp += "        No comments.";
            }
            else
            {
                tmp += "        " + comments_JMJL.Count +
                " comment(s). Click here to view.";
            }
            return tmp + "\n";
        }
    }
}
