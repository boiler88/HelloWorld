using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;


namespace HWAPI
{
     public class HWService : IHWService
    {
        /// <summary>
        /// Retrieves the Hello World messae
        /// </summary>
        /// <returns>string of Hello World message</returns>
        public string GetMessage()
        {
            HWApp.HWClass helloWorld = new HWApp.HWClass();
            return helloWorld.GetHWMessage();
        }

        /// <summary>
        /// Updates the database
        /// </summary>
        /// <returns>true if database update succcessful;  false otherwise</returns>
        public Boolean HWDBUpdate()
        {
            HWApp.HWClass helloWorld = new HWApp.HWClass();
            return helloWorld.HWDBUpdate();
        }

        // Add more API methods as needed
    }
}
