using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace Kuncii.Models
{
    public class ClsAppSetting
    {
        //private string m_sFileName;
        //private Hashtable m_oItems;

        // Untuk baca XML
        public string Baca(string node)
        {
            string kunci;
            XmlDocument doc = new XmlDocument();
            doc.Load("SettingWeb.xml");
            string xpath = "SettingConfig/" + node;
            XmlNode element = doc.SelectSingleNode(xpath);
            kunci = element.InnerText;
            //XmlTextReader reader = new XmlTextReader("SettingWeb.xml");
            //string kunci;
            //do
            //{

            //    reader.Read();
            //    switch (reader.NodeType)
            //    {
            //        case XmlNodeType.Element:

            //            break;
            //    }
            //    kunci = reader.Value;

            //} while (node != reader.Name);


            return kunci;
        }


        //public ClsAppSetting()
        //{
        //    FileName(AppDomain.CurrentDomain.BaseDirectory + "SettingWeb.xml");
        //}

        //public ClsAppSetting(string filename)
        //{
        //    FileName(filename);
        //}

        //public string FileName(string value)
        //{
        //    m_sFileName = value;
        //    LoadDOM();
        //    return m_sFileName;
        //}

        // Filename
        //string Filename = AppDomain.CurrentDomain.BaseDirectory + "SettingWeb.xml";

        //public Hashtable Items
        //{
        //    get
        //    {
        //        return m_oItems;
        //    }
        //    set
        //    {
        //        m_oItems = value;

        //    }
        //}

        //public void LoadDOM()
        //{
        //    m_oItems = new Hashtable();
        //    XmlDocument oDOc = new XmlDocument();
        //    XmlNode oNode;
        //    try
        //    {
        //        oDOc.Load(Filename);
        //        oNode = oDOc.FirstChild;
        //        while (oNode == null)
        //        {
        //            m_oItems.Add(oNode.Name, oNode.InnerText);
        //            oNode = oNode.NextSibling;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        oDOc = null;
        //    }
        //}
        public string getPrefix()
        {
            return "mujiyono";
        }
    }
}
