using Dapper.Business.Managers;
using Dapper.Models;
using System.Web.Http;

namespace Dapper.API.Controllers
{
    [System.Web.Http.RoutePrefix("api/Licenses")]
    public class LicenseController : ApiController
    {
        private readonly ILicenseManager _licenseManager;

        public LicenseController(ILicenseManager licenseManager)
        {
            _licenseManager = licenseManager;
        }

        [HttpPost]
        [Route("CreateLicense")]
        public IHttpActionResult CreateLicense(License license)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_licenseManager.CreateLicense(license));
        }

        [HttpGet]
        [Route("GetAllLicensesEF")]
        public IHttpActionResult GetAllLicensesEF()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_licenseManager.GetAllLicensesEF());
        }

        [HttpGet]
        [Route("GetAllLicensesDapper")]
        public IHttpActionResult GetAllLicensesDapper()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_licenseManager.GetAlllicensesDapper());
        }

        [HttpGet]
        [Route("GetLicenseLiteByLicenseIdEF/{licenseId}")]
        public IHttpActionResult GetLicenseLiteByLicenseIdEF(int licenseId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_licenseManager.GetLicenseLiteEFByLicenseId(licenseId));
        }

        [HttpGet]
        [Route("GetLicenseLiteByLicenseIdDapper/{licenseId}")]
        public IHttpActionResult GetLicenseLiteByLicenseIdDapper(int licenseId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_licenseManager.GetLicenseLiteDapperByLicenseId(licenseId));
        }
    }
}