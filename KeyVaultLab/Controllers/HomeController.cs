using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KeyVaultLab.Controllers
{
    public class HomeController : Controller
    {
        // Lab: get values from Web.config and Key Vault
        public async Task<ActionResult> Index()
        {
            // From Web.config
            string db = ConfigurationManager.ConnectionStrings["ConnDb"].ConnectionString;
            string sec = ConfigurationManager.AppSettings["SecretFromKeyVault"];
            string env = ConfigurationManager.AppSettings["Environment"];
            ViewBag.WebConfigEnv = $"From {env}";
            ViewBag.WebConfigDb = $"DB: {db}";
            ViewBag.WebConfigSecret = $"Secret: {sec}";

            // TODO
            return View();
        }

        // Lab: get values from Key Vault with client service
        public async Task<ActionResult> About()
        {
            try
            {
                string secretValue = ConfigurationManager.AppSettings["SecretFromKeyVault"];
                // TODO
                ViewBag.Secret = $"Secret from: {secretValue}";
            }
            catch (Exception exp)
            {
                ViewBag.Error = $"Something went wrong: {exp.Message}";
            }

            return View();
        }

        // Lab: get data from Azure Blob Storage
        public async Task<ActionResult> Contact()
        {
            // Azure Blob Storage Infomation
            string containerName = "keyvaultdemo";
            string blobName = "employee.json";

            // Connect Azure Blob with Managed Identity
            try
            {
                // TODO
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message, exp.StackTrace);
                ViewBag.Error = $"Something went wrong: {exp.Message}";
            }


            // Connect Azure Blob with Connection String
            try
            {
                // Azure Blob Storage code
                string blobConnectionString = ConfigurationManager.AppSettings["ConnSg"];

                // TODO
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                ViewBag.Error = $"Something went wrong: {exp.Message}";
            }

            return View();
        }
    }
}