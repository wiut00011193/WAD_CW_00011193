using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Collections.Generic;
using WebApp_00011193.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace WebApp_00011193.Controllers
{
    public class EmployeeController : Controller
    {
        // The Definition of Base URL
        public const string baseUrl = "http://localhost:41522/";
        Uri ClientBaseAddress = new Uri(baseUrl);
        HttpClient clnt;

        // Constructor for initiating request to the given base URL publicly
        public EmployeeController()
        {
            clnt = new HttpClient();
            clnt.BaseAddress = ClientBaseAddress;
        }

        public void HeaderClearing()
        {
            // Clearing default headers
            clnt.DefaultRequestHeaders.Clear();

            // Define the request type of the data
            clnt.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        // GET: Employee
        public async Task<ActionResult> Index()
        {
            // Creating the list of new Employees list
            List<Employee> EmployeeInfo = new List<Employee>();

            HeaderClearing();

            // Sending Request to the find web api Rest service resources using HTTPClient
            HttpResponseMessage httpResponseMessage = await clnt.GetAsync("api/Employee");

            // If the request is success
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                // storing the web api data into model that was predefined prior
                var responseMessage = httpResponseMessage.Content.ReadAsStringAsync().Result;

                EmployeeInfo = JsonConvert.DeserializeObject<List<Employee>>(responseMessage);
            }

            return View(EmployeeInfo);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            // Creating a Get Request to get single Employee
            Employee EmployeeDetails = new Employee();

            HeaderClearing();

            // Creating a get request after preparation of get URL and assignin the results
            HttpResponseMessage httpResponseMessageDetails = clnt.GetAsync(clnt.BaseAddress + "api/Employee/" + id).Result;

            // Checking for response state
            if (httpResponseMessageDetails.IsSuccessStatusCode)
            {
                // storing the response details received from web api 
                string detailsInfo = httpResponseMessageDetails.Content.ReadAsStringAsync().Result;

                // deserializing the response
                EmployeeDetails = JsonConvert.DeserializeObject<Employee>(detailsInfo);
            }

            return View(EmployeeDetails);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            employee.EmployeeDepartment = new Department { ID = employee.EmployeeDepartmentId };
            if (ModelState.IsValid)
            {
                // serializing employee object into json format to send
                /*string jsonObject = "{"+employee."}"*/ ;
                string createEmployeeInfo = JsonConvert.SerializeObject(employee);

                // creating string content to pass as Http content later
                StringContent stringContentInfo = new StringContent(createEmployeeInfo, Encoding.UTF8, "application/json");

                // Making a Post request
                HttpResponseMessage createHttpResponseMessage = clnt.PostAsync(clnt.BaseAddress + "api/Employee/", stringContentInfo).Result;
                if (createHttpResponseMessage.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
