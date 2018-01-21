using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace HWApp
{
    public class HWClass
    {
        static void Main(string[] args)
        {
            HWClass hw = new HWClass();
            // Show message on screen
            MessageBox.Show(hw.GetHWMessage());
        }

        // Retrun the Hello World message string
        public string GetHWMessage()
        {
            return "Hello World";
        }

        // Update a database
        public Boolean HWDBUpdate()
        {
            // Get DB connection string
            string DBConn = System.Configuration.ConfigurationManager.AppSettings["DBConn"];
            // logic to update DB here - return true if successful, false otherwise
            return true;
        }
    }
}
