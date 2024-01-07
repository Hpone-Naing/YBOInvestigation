using YBOInvestigation.Models;

namespace YBOInvestigation.Services
{
    public interface DriverService
    {
        public Driver FindDriverByLicense(string licenseNumber);
        public string FindDriverLicenseByDriverName(string driverName);
        public List<Driver> GetDriversByVehicleDataId(int vehicleDataPkId);
        public bool CreateDriver(Driver driver);

        public bool EditDriver(Driver driver);
    }
}
