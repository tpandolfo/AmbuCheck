using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AmbuCheckPrototype
{
    class Checklist
    {
        List<Control> Controls;

        public Checklist()
        {

        }

        // FUTURE
        // Loads a checklist template from an XML document.
        public void LoadTemplate(string templateFileName)
        {
            using (XmlReader reader = XmlReader.Create(templateFileName))
            {
                bool inSection = false;

                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name == "section")
                        {
                            inSection = true;
                        }
                    }
                }
            }
        }
    }
}
