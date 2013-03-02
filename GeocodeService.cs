using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Geocoder {
  public class GeocodeService {
    private WebClient _client;

    public GeocodeService() {
      _client = new WebClient();
    }

    public Location GeocodeLocation(string address) {
      var url = "http://maps.googleapis.com/maps/api/geocode/xml?sensor=false&address=" + System.Web.HttpUtility.UrlEncode(address);

      var xmlString = _client.DownloadString(url);
      var xmlDoc = new System.Xml.XmlDocument();
      xmlDoc.LoadXml(xmlString);

      var loc = new Location();
      loc.Latitude = Double.Parse(xmlDoc.SelectSingleNode("//geometry/location/lat").InnerText);
      loc.Longitude = double.Parse(xmlDoc.SelectSingleNode("//geometry/location/lng").InnerText);

      return loc;
    }

    //public Task GeocodeLocationAsync(string address) {
    //  return null;
    //}
  }
}
