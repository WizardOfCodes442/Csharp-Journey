/**
this is the file of the controller that contains a specified view 
to render html on your homepage

Views that are associated with the home controller are stored in a folder called Views/Home
Views that are not specific to a single controller are stored in the folder called Views/Shared
Visual studio created the Home and the Shared folder automatically when the Web application template
is used and puts in some placeholder to get the project going

To create a view right click the Home folder in the solution explorer and select add new 
item from the pop-up menu 
*/

using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers {
    public class HomeController3 : Controllers {
        public ViewResult Index() {
            return View("MyView");
        }
    }
}

