using CMS.Core;
using CMS.Helpers;
using System;

namespace MedioClinic.Helpers
{
    public class MedioClinicAttachmentHelper
    {
        private static Uri siteURL = new Uri("http://localhost:51872/");


        /// <summary>
        /// GetFullPath
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFullPath(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {

                    if (!URLHelper.CheckPrefixes(ref path, new string[] { "http", "https" }, false))
                    {
                        return new Uri(siteURL + path.Replace("~", string.Empty)).AbsoluteUri;
                    }
                }
                catch (Exception ex)
                {
                    Service.Resolve<IEventLogService>().LogException("MedioClinicAttachmentHelper", "GetFullPath", ex);
                }
                return path;

            }
            return string.Empty;
        }

    }
}
