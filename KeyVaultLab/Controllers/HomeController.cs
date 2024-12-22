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

            // TODO: 2) Connect from Web.config with config builder
            return View();
        }

        // Lab: get values from Key Vault with client service
        public async Task<ActionResult> About()
        {
            try
            {
                string secretValue = ConfigurationManager.AppSettings["SecretFromKeyVault"];
                // TODO: 1) Connet Azure Key Vault Directly
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
                // TODO: 3-2) Client Credential with Azure PaaS
                // Use DefaultAzureCredential to authenticate with managed identity
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message, exp.StackTrace);
                ViewBag.Error = $"Something went wrong: {exp.Message}";
            }


            // Connect Azure Blob with Connection String
            try
            {
                // TODO: 3-1) Client Credential with Azure PaaS
                // Connect Azure Blob with Connection String

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