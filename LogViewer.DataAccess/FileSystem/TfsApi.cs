using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.VersionControl.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.DataAccess.FileSystem
{
    public class TfsApi
    {
        private string collectionUri = "http://wwww.app.com";
        public  string GetFileContent(string path)
        {
            // Get TfsTeamProjectCollection using standard SOAP convention
            using (TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(new Uri(collectionUri)))
            {
                // Can retrieve SOAP service from TfsTeamProjectCollection instance
                VersionControlServer vcServer = tpc.GetService<VersionControlServer>();
                ItemSet itemSet = vcServer.GetItems("$/", RecursionType.OneLevel);
                foreach (Item item in itemSet.Items)
                {
                    Console.WriteLine(item.ServerItem);
                }
            }
            return null;
        }
    }
}
