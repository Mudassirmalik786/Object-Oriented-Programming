using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainManagementSystemGUI.DL
{
    public class AdminDL
    {
        public static void storeAnnouncementIntoFile(string announcement, string announcementpath)
        {
            StreamWriter file = new StreamWriter(announcementpath, true);
            file.WriteLine(announcement);
            file.Flush();
            file.Close();
        }
        public static string readAnnouncement(string feedbackPath)
        {
            try
            {
                // Open the file using a stream reader
                using (StreamReader sr = new StreamReader(feedbackPath))
                {
                    string fileContents = sr.ReadToEnd();
                    return fileContents;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
