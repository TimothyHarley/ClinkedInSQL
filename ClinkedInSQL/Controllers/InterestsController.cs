using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinkedInSQL.Data;
using ClinkedInSQL.Models;

namespace ClinkedInSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestsController : ControllerBase
    {
        readonly UserInterestRepository _userInterestRepository;

        public InterestsController()
        {
            _userInterestRepository = new UserInterestRepository();
        }

        //Get api/userInterests
        [HttpGet]
        [Route("userInterests")]
        public ActionResult GetAllUserInterests()
        {
            return Ok(_userInterestRepository.GetAllUserInterests());
        }
    }
}