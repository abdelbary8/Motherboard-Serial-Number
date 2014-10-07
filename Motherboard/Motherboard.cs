using System.Management;

namespace Motherboard
{
    public class Board
    {
        ManagementObjectSearcher managementObjectSearcher;

        public string SerialNumber()
        {
            managementObjectSearcher = new ManagementObjectSearcher((ObjectQuery)new SelectQuery("Win32_BaseBoard"));
            ManagementObjectCollection.ManagementObjectEnumerator enumerator = null;
            string str = "";

            try
            {
                enumerator = managementObjectSearcher.Get().GetEnumerator();
                while (enumerator.MoveNext())
                {
                    str = enumerator.Current["SerialNumber"].ToString();
                }
            }
            finally
            {
                if (enumerator != null) enumerator.Dispose();
            }
            return str;
        }

    }
}
