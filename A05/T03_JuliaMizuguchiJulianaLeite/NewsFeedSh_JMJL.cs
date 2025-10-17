using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03_JuliaMizuguchiJulianaLeite
{
    internal class NewsFeedSh_JMJL
    {
        List<MessagePostSh_JMJL> messages_JMJL;
        List<PhotoPostSh_JMJL> photos_JMJL;

        public NewsFeedSh_JMJL()
        {
            messages_JMJL = new List<MessagePostSh_JMJL>();
            photos_JMJL = new List<PhotoPostSh_JMJL>();
        }

        public void AddMessagePost_JMJL(MessagePostSh_JMJL message_JMJL)
        {
            messages_JMJL.Add(message_JMJL);
        }

        public void AddPhotoPost_JMJL(PhotoPostSh_JMJL photo_JMJL)
        {
            photos_JMJL.Add(photo_JMJL);
        }

        public List<MessagePostSh_JMJL> GetMessagePosts_JMJL()
        {
            return messages_JMJL;
        }

        public List<PhotoPostSh_JMJL> GetPhotoPosts_JMJL()
        {
            return photos_JMJL;
        }

        override 
        public String ToString()
        {
            String tmp = "";
            foreach (MessagePostSh_JMJL message in messages_JMJL)
            {
                //display all text posts
                tmp += message.ToString() + "\n";
            }

            foreach (PhotoPostSh_JMJL photo in photos_JMJL)
            {
                //display all photos
                tmp += photo.ToString() + "\n";
            }

            return tmp;
        }
    }
}
