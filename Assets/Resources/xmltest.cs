using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

public class xmltest : MonoBehaviour
{
    private void Start()
    {
        string filepath = Application.dataPath.ToString() + "/Resources/Character.xml";

        if(!System.IO.File.Exists(filepath))
        {
            CreateXml();
        }

       // CreateXml();
    }

    void CreateXml()
    {
        XmlDocument xmlDoc = new XmlDocument();

        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "yes"));

        XmlNode root = xmlDoc.CreateNode(XmlNodeType.Element, "CharacterInfo", string.Empty);
        xmlDoc.AppendChild(root);

        // �ڽ� ���
        XmlNode child = xmlDoc.CreateNode(XmlNodeType.Element, "Character", string.Empty);
        root.AppendChild(child);

        // �ڽ� ��� �Ӽ� ����
        XmlElement lv = xmlDoc.CreateElement("Level");
        lv.InnerText = "1";
        child.AppendChild(lv);

        XmlElement exp = xmlDoc.CreateElement("Exp");
        exp.InnerText = "0";
        child.AppendChild(exp);

        XmlElement coin = xmlDoc.CreateElement("coin");
        coin.InnerText = "100";
        child.AppendChild(coin);

        xmlDoc.Save("./Assets/Resources/Character.xml");

    }
}