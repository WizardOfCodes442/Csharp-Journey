/**
To display a basic hello word on your homepage
edit the controller file with the following code 
*/

using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers {
    public class HomeController : Controller {

        public string Index() {
            return "Hello World";
        }
    }
}