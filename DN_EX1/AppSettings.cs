using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DN_EX1
{
    public class AppSettings
    {
        private const string k_XmlFilePath = @".\DNFFacebookAppSettings.xml";

        private bool m_RememberMe;
        private string m_LastAccsessToken;
        private AppSettings()
        {
            m_RememberMe = false;
            m_LastAccsessToken = null;
        }

        internal static AppSettings loadFromFile()
        {
            AppSettings loadAppSettings = new AppSettings();
            if (File.Exists(k_XmlFilePath))
            {
                using (Stream stream = new FileStream(k_XmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    try
                    {
                        loadAppSettings = serializer.Deserialize(stream) as AppSettings;
                    }
                    catch (Exception e)
                    {
                        loadAppSettings = new AppSettings();
                    }
                }
            }

            return loadAppSettings;
        }

        internal void SaveToFile()
        {
            FileMode fileModeToLoad = FileMode.CreateNew;
            if (File.Exists(k_XmlFilePath))
            {
                fileModeToLoad = FileMode.Truncate;
            }

            using (Stream stream = new FileStream(k_XmlFilePath, fileModeToLoad))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }



        public bool RememberMe
        {
            get { return m_RememberMe; }
            set { m_RememberMe = value; }
        }

        public string LastAccsessToken
        {
            get { return m_LastAccsessToken; }
            set { m_LastAccsessToken = value; }
        }



    }
}
