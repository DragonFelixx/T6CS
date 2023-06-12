using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4_CSharp
{
    internal class Utils
    {
        public static void updateListBox(TableLamp tableLamp, ListBox listBox1)
        {
            listBox1.Items.Clear();
            StringBuilder sb = new StringBuilder();

            sb.Append(tableLamp.toString());
            string objToString = sb.ToString();
            string[] values = objToString.Split('|');

            foreach (string value in values)
            {
                if (value.Trim() == "")
                    continue;
                listBox1.Items.Add(value.Trim());
            }
        }
    }
}
