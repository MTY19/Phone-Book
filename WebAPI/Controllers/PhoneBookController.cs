using Business.Abstract;
using Entitities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneBookController : ControllerBase
    {

        public IPersonService _personService;
        public IPersonAddressService _personAddressService;

        public PhoneBookController(IPersonService personService, IPersonAddressService personAddressService)
        {
            _personService = personService;
            _personAddressService = personAddressService;
        }

        #region Person

        [HttpPost("addperson")]
        public IActionResult AddPerson(Person person)
        {
            var result = _personService.Add(person);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("deleteperson")]
        public IActionResult DeletePerson(Person person)
        {
            var result = _personService.Delete(person);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("updateperson")]
        public IActionResult UpdatePerson(Person person)
        {
            var result = _personService.Update(person);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        #endregion

        #region PersonAddress

        [HttpPost("addpersonaddress")]
        public IActionResult AddPersonAddress(PersonAddress personAddress)
        {
            var result = _personAddressService.Add(personAddress);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("deletepersonaddress")]
        public IActionResult DeletePersonAddress(PersonAddress personAddress)
        {
            var result = _personAddressService.Delete(personAddress);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("updatepersonaddress")]
        public IActionResult UpdatePersonAddress(PersonAddress personAddress)
        {
            var result = _personAddressService.Update(personAddress);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        #endregion


    }
}
