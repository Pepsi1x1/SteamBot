using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SteamBot
{
    class UserHandlerConfigurationBase<T>
    {
        public static T LoadConfiguration(string filename)
        {
            TextReader reader = new StreamReader(filename);
            string json = reader.ReadToEnd();
            reader.Close();

            T config = JsonConvert.DeserializeObject<T>(json);

            return config;
        }

        public static void WriteConfiguration(T cls, string filename)
        {
            string json = JsonConvert.SerializeObject(cls);
            TextWriter writer = new StreamWriter(filename);
            writer.Write(json);
            writer.Close();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var fields = this.GetType().GetProperties();

            foreach (var propInfo in fields)
            {
                sb.AppendFormat("{0} = {1}" + Environment.NewLine,
                    propInfo.Name,
                    propInfo.GetValue(this, null));
            }

            return sb.ToString();
        }
    }
}
