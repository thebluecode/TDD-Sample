﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitTestSample;

namespace WebApp.Ninject.Controllers
{
    public class EnrollmentController : ApiController
    {
        public EnrollmentController(IEnrollmentBo enrollmentBo)
        {
            this.enrollmentBo = enrollmentBo;
        }

        private readonly IEnrollmentBo enrollmentBo;

        public string Get()
        {
            return "Ninject - Enrollment Controller 1.0";
        }

        public string Post([FromBody] Account account)
        {
            var result = enrollmentBo.Enroll(account);

            return string.Format("Ninject - {0}", result);
        }
    }
}