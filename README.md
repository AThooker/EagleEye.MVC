# Eagle Eye (MVC design pattern)
## Austin Hooker
#### *Software Development Bootcamp @ Eleven Fifty Academy*

The final requirement to earn the Red Badge for this program was to create an ASP.Net web application using the model-view-controller (MVC) design pattern. My .Net Framework MVC Web Application provides users the ability to report any curious situations in which someone may be or has been a victim of human trafficking. This application allows users to input what they saw, who was involved(if they saw someone), the times at which it took place, and any of their own past reports. They can also go back into their account and update anything else they think of at a later date. This app allows for an administrator of the app to go in and see the entire database, whether it be all victims, all perps, or all incidents. The admin also has the authority to delete objects while the lay user does not.
<br />
#### How to install the project locally:
<br />
<i>(This application was built and tested in Visual Studio)</i>
<br />
<br />
1.	Go to https://github.com/AThooker/EagleEye.MVC/tree/master 
<br />
2.	On this page, make sure you are on the master branch (located directly above the blue box containing the name of the last committed changes)
<br />
3.	Once you know you are on the master branch, click the green box containing “Code” and copy the URL given in the dropdown menu, either by copying the link manually or clicking the clipboard icon. 
<img src="https://user-images.githubusercontent.com/66280480/89951164-e6df7d00-dbf8-11ea-8209-9c967092f45f.png" align="left" width="500" height="180"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
4.	Now you can navigate to where you’d like the project to be stored, and open your command prompt. 
<br />
5.	In your command prompt, type “git clone”, put a space after “clone”, then paste the URL you copied from Github. Press enter and the project should clone to your local computer.
<br />
6.	After the project is cloned, if there are build errors then you may have to restore NuGet packages that come along with the project. Another solution may be restarting Visual Studio.
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br/>
<b>Run the App</b>
<br/>
Once you have successfully cloned the project locally, you can run the project by pushing the green start button near the top of the page.
<br/>
If it has successfully run, it should look like this:
<br />
<br/>
<img src="https://user-images.githubusercontent.com/66280480/92505612-57ff5980-f1d2-11ea-9478-8f656b997c55.png" align="left" width="500" height="240"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
- From here, you can register as a new user, and navigate your way through the application testing it's functionality.
<br />
- As mentioned before, the app does contain user roles. The "Admin" role is programmed within the code and cannot be accessed by someone using the app without the code. 
<br/>
- To do this, logout of your current account and press the log in button near the top right of the web page.
<br /> 
- Use these credentials to login: Username = Austin , Password = testing
<br/>
- This will give you access due to the hard coded profile in the project here: 
<br/>
<br/>
<img src="https://user-images.githubusercontent.com/66280480/92507414-f2f93300-f1d4-11ea-87ef-1157146ead58.png" align="left" width="500" height="240"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br/>
<b>Using the Admin Role</b>
<br/>
- Now that you are an admin, you have relatively unrestructed access to the projects' functionality
<br/>
- You will notice that the navbar is now different since you are in an admin role, this is achieved by using C# in the razor pages of the "layout" view. 
<br/>
<img src="https://user-images.githubusercontent.com/66280480/92508959-73209800-f1d7-11ea-8f54-02d2c8ccb8ae.png" align="left" width="500" height="240"/>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br/>
- You may create an incident, and delete any report, perp, or victim. However, you cannot edit others' submissions nor the corresponding victims or perps. 
<br/> 
<br />
---------------------------------------------------------------------------------------------------------------------------------------------------
<br/>
<b>Stretch Goals</b>
  <br/>
- I had many stretch goals for this app, some of the ones I did not achieve in the alotted time are:
  <br/>
  <br/>
1. Get perps or victims by similarities and try to pinpoint any trends that may take effect throughout the incidents reported
<br />
  <br/>
2. Allow users to more easily share their location without have to type in the entire address
  <br/>
  <br/>
3. Let all users see incidents in their specific area (maybe by radius of address or something alike)
---------------------------------------------------------------------------------------------------------------------------------------------------
<br/>
<b>Additional Resources used</b>: 
<br />
https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application#:~:text=The%20Entity%20Framework%20doesn't,updates%20simpler%20and%20more%20efficient.
<br />
https://stackoverflow.com/questions/18165879/mvc-4-displaying-a-list-property-on-a-view
<br />
https://docs.microsoft.com/en-us/dotnet/csharp/linq/query-a-collection-of-objects
<br />
https://www.c-sharpcorner.com/UploadFile/asmabegam/Asp-Net-mvc-5-security-and-creating-user-role/
<br />
https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/hands-on-labs/aspnet-mvc-4-models-and-data-access
<br />
https://trello.com/b/wnf5ywSh/eagleeye
<br/>
---------------------------------------------------------------------------------------------------------------------------------------------------
<br />
<b>Project Created by</b>:
<br />
@AThooker
