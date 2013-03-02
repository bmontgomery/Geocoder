# Geocoder

Geocoder is a simple .NET library which utilizes Google's Geolocation API to geocode street addresses.

# Example (C#)

    var geocoder = new Geocoder.GeocodeService();

    // geocode the location of the White House
    var whiteHouseLocation = geocoder.GeocodeLocation("1600 Pennsylvania Ave NW Washington, DC 20500");

    Console.WriteLine("Location: Latitude: " + whiteHouseLocation.Latitude.ToString() + "; Longitude: " + whiteHouseLocation.Longitude.ToString());
