using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using project.Models;


namespace project.Controllers
{
    public class staffController : ApiController
    {
        IList<student> StudentList = new List<student>()
       {
           new student (){stdid=1,stdname="ankit",stdclass=12,stdage=18,stdcontactno=700863432},
           new student (){stdid=2,stdname="anuj",stdclass=12,stdage=18,stdcontactno=700678976},
           new student (){stdid=3,stdname="rahul",stdclass=12,stdage=18,stdcontactno=985963432},
           new student (){stdid=4,stdname="muchkund",stdclass=12,stdage=18,stdcontactno=600863432}
        };
        public ActionResult index()

        {
            return view(StudentList);
        }
    }
}