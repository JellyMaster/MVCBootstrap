MVCBootstrap
============


<h2>So what is this? </h2>

This is a simple project that provides an alternative replace to the the default MVC validation summary html helper. 

I was not happy with it's lack of styling and customization in the modern world and as a big fan of using Twitter's Bootstrap framework I wanted something more in keeping with it. 

In addition I missed some of the controls that I had from asp.net webforms and included a simple visual "required fields indicator"

With that in mind here is my little pet project which replaces the default control and gives you the flexibility to show errors in a number of ways. 

<h2>Before you start</h2>
Ensure you have bootstrap version 3 and jquery setup within your project before you use this. 
Also make sure that you have jquery loaded on the page before this is called. Due to using JQuery a lot in this control a javascript error will fire up if it is loaded at the bottom. This is scheduled as part of an update in the future to pull out all the javascript into a separate file and get this called in. 

<h2>How to get it working?</h2>

Well it's pretty simple: 

Step 1) Download the source code from here or install from nuget (search for BootstrapMvc via nuget) 

      Install-Package BootstrapMvc 
      
Step 2) Add the following declaration to your views\webconfig file under pages: 
 (Version 1.0.0.4 has a webconfig transform for this but if you are using areas you will need add this change manually)
 
     <system.web.webPages.razor>
    <host factoryType="System.Web.Mvc.MvcWebRazorHostFactory, System.Web.Mvc, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31BF3856AD364E35" />
    <pages pageBaseType="System.Web.Mvc.WebViewPage">
      <namespaces>
      ..... //removed for brevity
     <add namespace="BootstrapMvc.HtmlHelpers"/>
      </namespaces>
    </pages>
    </system.web.webPages.razor>


Step 3) Go to the view you want to add this too and simply add: 

     @Html.BootStrapValidationSummary()
     
This adds the default Alert panel mode like this: 

![Alert Model(Default Mode)](https://github.com/JellyMaster/MVCBootstrap/raw/master/BootstrapMvc/BootstrapMvc/Sample%20Images/image009.png)


Step 4) Leave as is or customise. 

Samples of the various modes available currently: 

![Sample Showing all main modes](https://github.com/JellyMaster/MVCBootstrap/raw/master/BootstrapMvc/BootstrapMvc/Sample%20Images/sample%20of%20main%20modes.png)

![Sample Showing modal mode with required field indicators on](https://github.com/JellyMaster/MVCBootstrap/raw/master/BootstrapMvc/BootstrapMvc/Sample%20Images/sample%20showing%20modal%20window.png)


<h2>How to use it?</h2>

For full details go to the project wiki below: 

https://github.com/JellyMaster/MVCBootstrap/wiki/BootStrapped-Validation-Summary
     

To customise the summary panel we pass in a new BootstrapValidationSummaryOptions() object. 

This allows you to pass in the various settings to enable/disable features as well as change the styling of the summary panel. 


    public BootstrapValidationSummaryOptions(
     ErrorMode mode = ErrorMode.Alert,
     bool showModelErrors = true,
     string title = "Oops! There seems to be a problem.",
     string introductionBlock = "There seems to have been a problem with your request. See below: ",
     bool enableRequiredFieldIndicators = false,
     bool enableRequiredFieldHelp = false,
     AlertStyleSettings alertStyleSettings = null,
     PanelStyleSettings panelStyleSettings = null,
     ModalStyleSettings modalStyleSettings = null)
     {
         DisplayMode = mode;
         ShowModelErrors = showModelErrors;
         Title = title;
         IntroductionBlock = introductionBlock;
         EnableRequiredFieldIndicators = enableRequiredFieldIndicators;
         EnableRequiredFieldHelp = enableRequiredFieldHelp;
         AlertDisplaySettings = (alertStyleSettings == null) ? new AlertStyleSettings() : alertStyleSettings;
         PanelDisplaySettings = (panelStyleSettings == null) ? new PanelStyleSettings() : panelStyleSettings;
         ModalDisplaySettings = (modalStyleSettings == null) ? new ModalStyleSettings() : modalStyleSettings;
     }

<ul>
<li><strong>DisplayMode mode</strong>:  this is an enum and can be put in ErrorMode.Alert, ErrorMode.ClosableAlert, ErrorMode.Panel, ErrorMode.CollapsablePanel, ErrorMode.Modal </li>
<li><strong>bool showModelErrors</strong>: turns on or off model errors</li>
<li><strong>string title</strong>: The text displayed at the top of the summary panel </li>
<li><strong>string introductionBlock</strong>: Some text introducing the errors to the user</li>
<li><strong> bool enableRequiredFieldIndicators</strong>: Turns on/off highlighting fields that are set as required </li>
<li><strong>bool enableRequiredFieldHelp</strong>: Turns on/off the required field text help section </li>
<li><strong>AlertStyleSettings alertStyleSettings</strong>: Sets the css classes for the Alert panel styling </li>
<li><strong>PanelStyleSettings panelStyleSettings</strong>: Sets the css classes for the Panel Alert styling </li>
<li><strong>ModalStyleSettings modalStyleSettings</strong>: Sets the css classes for the Modal Alert styling  </li>
</ul>

For further details check the wiki. 

https://github.com/JellyMaster/MVCBootstrap/wiki/BootStrapped-Validation-Summary

<h2>So what's next?</h2>

Well a feature I am still looking at is unobtrusive support and this is something that will hopefully give you the same level of customization as this control. It also gives me the perfect chance to pull out all the jquery that I have stuffed in the helper and maintain it in a more sensible way. 



Thanks for taking the time to have a look at this project and if you have any suggestions on improvements/bugs feel free to let me know. 
