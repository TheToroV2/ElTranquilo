using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Net;
using System.Web;
using System.Windows.Forms;


namespace ElTranquilo
{
    public class DBapi
    {
        public static List<Usuario> Get(string urlApi)
        {
            HttpWebRequest objPedido = (HttpWebRequest)WebRequest.Create(urlApi);
            objPedido.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            objPedido.Credentials = CredentialCache.DefaultCredentials;
            objPedido.Proxy = null;
            HttpWebResponse objRespuesta = (HttpWebResponse)objPedido.GetResponse();
            Stream objFlujo = objRespuesta.GetResponseStream();
            StreamReader objFlujoLectura = new StreamReader(objFlujo);
            string datosJson = HttpUtility.HtmlDecode(objFlujoLectura.ReadToEnd());
            List<Usuario> datos = JsonConvert.DeserializeObject<List<Usuario>>(datosJson);
            return datos;
        }
    }

}
