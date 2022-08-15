using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web;
using dotnet_ws;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Linq;

namespace dotnet_ws.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]

    public class AtmController : ControllerBase
    {
        public async static Task<AtmResponse> FetchAtms(string url)
        {
            string token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6MywiZW1haWwiOiJhdG1pZHByb2plY3RAZ21haWwuY29tIiwibmFtZSI6Ik1pc2FmaXIgS3VsbGFuxLFjxLEiLCJtZW1iZXJubyI6MiwiZXhwaXJhdGlvbkRhdGUiOiIyMzIyLTEyLTA4VDE1OjQzOjExLjA2NFoiLCJpYXQiOjE2NTk5NzMzOTF9.NYvX7IN8QlZZlgzB_M2GhcQ0x_lVP9LkUz0PrmZ5ND0";
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", token);

                var response = await client.GetStringAsync(url);
                AtmResponse parsedResponse = JsonConvert.DeserializeObject<AtmResponse>(response);
                return parsedResponse;
            };
        }

        private readonly DataContext _context;
        public AtmController(DataContext context)
        {
            _context = context;
        }




        [HttpGet]
        public async Task<ActionResult<List<Atm>>> Get()
        {
             return Ok(await _context.Atms.ToListAsync());
        }


        public class UpdateResponse
        {
            public List<string> successfull = new List<string>();
            public List<string> error = new List<string>();
            public int totalAdded = 0;
            public int totalError = 0;
        };

        [HttpGet]
        [Route("/api/update")]
        public async Task<ActionResult> Update()
        {
            var fetchedAtms = await FetchAtms("https://atm-id-app.herokuapp.com/atm");
            List<Atm> listAtm = fetchedAtms.results.rows;

            UpdateResponse updatedRecords = new UpdateResponse();

            foreach (var atm in listAtm)
            {
                try
                {
                    _context.Atms.Add(atm);
                    var dbResponse = await _context.SaveChangesAsync();
                    if(dbResponse == 1)
                    {
                        updatedRecords.successfull.Add(atm.globalatmid.ToString());
                        updatedRecords.totalAdded = updatedRecords.totalAdded + 1;
                    }
                }
                catch (Exception exc)
                {
                    updatedRecords.error.Add(atm.globalatmid.ToString());
                    updatedRecords.totalAdded = updatedRecords.totalError + 1;
                }
                finally
                {

                }
            }

            string serialized = JsonConvert.SerializeObject(updatedRecords);

            return Ok(serialized);
        }

        [HttpGet]
        [Route("/api/fetch")]
        public async Task<ActionResult<List<Atm>>> FetchTyped()
        {
            var fetchedAtms = await FetchAtms("https://atm-id-app.herokuapp.com/atm");
            List<Atm> listAtm = fetchedAtms.results.rows;
            return Ok(listAtm);
        }

        [HttpPost]
        public async Task<ActionResult<List<Atm>>> Post(Atm atmFromBody)
        {
             _context.Atms.Add(atmFromBody);
            await _context.SaveChangesAsync();

            return Ok(await _context.Atms.ToListAsync());
        }

    }
}

