using System;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace BootstrapMvc.HtmlHelpers
{
    public static class BootStrapExtensions
    {
        public enum ErrorMode
        {
            Alert,
            ClosableAlert,
            Panel,
            Modal,
            CollapsePanel
        }
        public class BootstrapValidationSummaryOptions
        {


            public ErrorMode DisplayMode { get; set; }

            public bool ShowModelErrors { get; set; }

            public string Title { get; set; }

            public string IntroductionBlock { get; set; }

            public AlertStyleSettings AlertDisplaySettings { get; set; }

            public PanelStyleSettings PanelDisplaySettings { get; set; }


            public ModalStyleSettings ModalDisplaySettings { get; set; }

            public bool EnableRequiredFieldIndicators { get; set; }

            public bool EnableRequiredFieldHelp { get; set; }


            public BootstrapValidationSummaryOptions(ErrorMode mode = ErrorMode.Alert,
                                                        bool showModelErrors = true,
                                                        string title = "Oops! There seems to be a problem.",
                                                        string introductionBlock = "There seems to have been a problem with your request. See below: ",
                                                        bool enableRequiredFieldIndicators = true,
                                                        bool enableRequiredFieldHelp = true,
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

        }

        public class BaseStyleSettings
        {
            public string ContainerClass { get; internal protected set; }
            public string ContainerEmphasisClass { get; internal protected set; }

            public string HeadingClass { get; internal protected set; }

            public string TitleClass { get; internal protected set; }

            public string BodyClass { get; internal protected set; }

            public string IntroductionBlockClass { get; internal protected set; }

            public string IntroductionBlockEmphasisClass { get; internal protected set; }

            public string DefaultModelErrorGroupClass { get; internal protected set; }

            public string DefaultModelErrorBaseItemClass { get; internal protected set; }


            public string DefaultModelErrorItemClass { get; internal protected set; }



            public string DefaultModelErrorItemAltClass { get; internal protected set; }

            public string AdditionalModelErrorGroupClass { get; internal protected set; }

            public string AdditionalModelErrorGroupEmphasis { get; internal protected set; }






            public BaseStyleSettings(string container, string containerEmphasis, string heading, string title,
                                     string body, string introduction, string introductionEmphasis, string defaulterrorgroup,
                                     string defaulterroritembase, string defaulterroritem, string defaulterroraltitem,
                                     string additionalerrorgroup, string additionalerrorgroupemphasis)
            {
                ContainerClass = container;
                ContainerEmphasisClass = containerEmphasis;
                HeadingClass = heading;
                TitleClass = title;
                BodyClass = body;
                IntroductionBlockClass = introduction;
                IntroductionBlockEmphasisClass = introductionEmphasis;
                DefaultModelErrorGroupClass = defaulterrorgroup;
                DefaultModelErrorBaseItemClass = defaulterroritembase;
                DefaultModelErrorItemClass = defaulterroritem;
                DefaultModelErrorItemAltClass = defaulterroraltitem;
                AdditionalModelErrorGroupClass = additionalerrorgroup;
                AdditionalModelErrorGroupEmphasis = additionalerrorgroupemphasis;
            }
        }

        public class AlertStyleSettings : BaseStyleSettings
        {

            public string ContainerDismissibleClass { get; internal protected set; }

            public string CloseButtonClass { get; internal protected set; }

            public AlertStyleSettings(string container = "alert",
                                        string containerEmphasis = "alert-danger",
                                        string containerDismissible = "alert-dismissible",
                                        string heading = "",
                                        string title = "",
                                        string body = "",
                                        string closebutton = "close",
                                        string introduction = "well",
                                        string introductionEmphasis = "well-sm",
                                        string defaultmodelerrorgroup = "list-group",
                                        string defaultmodelerroritembase = "list-group-item",
                                        string defaultmodelerroritem = "",
                                        string defaultmodelerroraltitem = "list-group-item-warning",
                                        string additionalmodelerrorgroup = "alert",
                                        string additionalmodelerrorgroupemphasis = "alert-danger"
                                               )
                : base(container, containerEmphasis, heading, title, body,
                        introduction, introductionEmphasis, defaultmodelerrorgroup,
                        defaultmodelerroritembase, defaultmodelerroritem, defaultmodelerroraltitem,
                        additionalmodelerrorgroup, additionalmodelerrorgroupemphasis)
            {

                ContainerDismissibleClass = containerDismissible;
                CloseButtonClass = closebutton;
            }

        }

        public class PanelStyleSettings : BaseStyleSettings
        {




            public PanelStyleSettings(string container = "panel",
                                        string containerEmphasis = "panel-danger",
                                        string heading = "panel-heading",
                                        string title = "panel-title",
                                        string body = "panel-body",
                                        string introduction = "well",
                                        string introductionEmphasis = "well-sm",
                                        string defaultmodelerrorgroup = "list-group",
                                        string defaultmodelerroritembase = "list-group-item",
                                        string defaultmodelerroritem = "",
                                        string defaultmodelerroraltitem = "list-group-item-warning",
                                        string additionalmodelerrorgroup = "alert",
                                        string additionalmodelerrorgroupemphasis = "alert-danger"
                                               )
                : base(container, containerEmphasis, heading, title, body,
                        introduction, introductionEmphasis, defaultmodelerrorgroup,
                        defaultmodelerroritembase, defaultmodelerroritem, defaultmodelerroraltitem,
                        additionalmodelerrorgroup, additionalmodelerrorgroupemphasis)
            {

            }

        }

        public class ModalStyleSettings : BaseStyleSettings
        {


            public string ModalDialogClass { get; internal protected set; }

            public string ModalDialogContentClass { get; internal protected set; }

            public string CloseButtonClass { get; internal protected set; }


            public ModalStyleSettings(string container = "modal",
                                        string containerEmphasis = "fade",
                                        string heading = "modal-header",
                                        string title = "modal-title",
                                        string body = "modal-body",
                                        string introduction = "well",
                                        string introductionEmphasis = "well-sm",
                                        string defaultmodelerrorgroup = "list-group",
                                        string defaultmodelerroritembase = "list-group-item",
                                        string defaultmodelerroritem = "",
                                        string defaultmodelerroraltitem = "list-group-item-warning",
                                        string additionalmodelerrorgroup = "alert",
                                        string additionalmodelerrorgroupemphasis = "alert-danger",
                                        string modaldialog = "modal-dialog",
                                        string modaldialogcontent = "modal-content",
                                        string closebutton = "close")
                : base(container, containerEmphasis, heading, title, body,
                     introduction, introductionEmphasis, defaultmodelerrorgroup,
                     defaultmodelerroritembase, defaultmodelerroritem, defaultmodelerroraltitem,
                     additionalmodelerrorgroup, additionalmodelerrorgroupemphasis)
            {
                ModalDialogClass = modaldialog;
                ModalDialogContentClass = modaldialogcontent;
                CloseButtonClass = closebutton;

            }



        }

        public static MvcHtmlString BootStrapValidationSummary(this HtmlHelper helper, BootstrapValidationSummaryOptions options = null)
        {
            ///This is the full script for altering the labels on required fields. 
            ///I have tweaked from original version to handle checkbox and text box validation. 
            string requiredDecoratingScript = "<script>" +
                                                "$(this).ready(function () {" +
                                               "$('[data-val-required]').each(function () {" +
                                               "var label = $(\"label[for='\" + $(this).attr('id') + \"']\");" +
                                               "var isCheckbox = $(this).is(':checkbox');" +

                                               "var isTextbox = $(this).is(':text');" +
                                               "var isPassword = $(this).is(':password');" +
                                               "var isValidTextValue = true;" +
                                               
                                               "if(isTextbox || isPassword)" +
                                               "{" +

                                               "isValidTextValue = $(this).val() !== '';" +
                                               "}" +
                                               "label.removeClass(\"text-success\");" +
                                               "label.removeClass(\"text-danger\");" +
                                               "if ((" + ((helper.ViewData.ModelState.IsValid) ? "true" : "false") +
                                               "|$(this).hasClass(\"input-validation-error\") | !isValidTextValue) " +
                                               "&& !isCheckbox" +
                                                ") {" +
                                               "label.addClass(\"text-danger\");" +
                                               "}" +
                                               "else " +
                                               "{" +
                                               "if(!isCheckbox){" +
                                               "label.addClass(\"text-success\");" +
                                               "}" +
                                               "}" +
                                               "});" +
                                               "}); " +
                                               "</script>";

            string requiredbox = "<div class=\"well well-sm\"><p>All labels like <strong class=\"text-danger\">this</strong> are required fields.</p>" +
                                 "<p>All labels like <strong class=\"text-success\">this</strong> are valid required fields.</p></div>";

            StringBuilder stringBuilder = new StringBuilder();

            if (options == null)
            {
                options = new BootstrapValidationSummaryOptions();
            }


            if (!options.EnableRequiredFieldHelp)
            {
                requiredbox = string.Empty;
            }

            if (!options.EnableRequiredFieldIndicators)
            {
                requiredDecoratingScript = string.Empty;
            }

            // first lets check to see if we have any errors in the system. 
            if (helper.ViewData.ModelState.IsValid)
            {
                //we have a valid model lets not do anything. 
                return new MvcHtmlString(requiredbox + requiredDecoratingScript);
            }


            //To ensure compatability with JQuery Validate We need to wrap this up into a new validation div that will be hidden by default but will display once the system is launched 
            //Need to see how I can do this is a nicer way without having to rewrite the entire helper. 

            string unObtrusiveStringOpen = string.Format("<div class=\"{0}\" data-valmsg-summary=\"true\">", (helper.ViewData.ModelState.IsValid) ? "validation-summary-valid" : "validation-summary-errors");
            string unObtrusiveStringEnd = string.Format("</div>");




            switch (options.DisplayMode)
            {
                case ErrorMode.Alert:
                    {
                        stringBuilder = AlertMode(helper, false, options);
                        break;
                    }
                case ErrorMode.ClosableAlert:
                    {
                        stringBuilder = AlertMode(helper, true, options);
                        break;
                    }
                case ErrorMode.Modal:
                    {
                        stringBuilder = ModalAlertMode(helper, options);
                        break;
                    }
                case ErrorMode.Panel:
                    {
                        stringBuilder = PanelAlertMode(helper, options);
                        break;
                    }
                case ErrorMode.CollapsePanel:
                    {
                        stringBuilder = CollapsePanelAlertMode(helper, options);
                        break;
                    }

                default:
                    {
                        //default mode will be standard alert mode. 
                        stringBuilder = AlertMode(helper, false, options);

                        break;
                    }

            }



            //  MvcHtmlString returnString = new MvcHtmlString(requiredbox + unObtrusiveStringOpen + stringBuilder.ToString() + unObtrusiveStringEnd + requiredDecoratingScript);
            MvcHtmlString returnString = new MvcHtmlString(requiredbox + stringBuilder.ToString() + requiredDecoratingScript);


            return returnString;
        }

        private static StringBuilder CollapsePanelAlertMode(HtmlHelper helper, BootstrapValidationSummaryOptions options)
        {
            StringBuilder builder = new StringBuilder();

            //add the main panel 
            builder.AppendFormat("<div class=\"{0} {1}\" id=\"{2}\">", options.PanelDisplaySettings.ContainerClass, options.PanelDisplaySettings.ContainerEmphasisClass, "SummaryCollapsePanel");

            //add the header 
            builder.AppendFormat("<div class=\"{0}\">", options.PanelDisplaySettings.HeadingClass);
            builder.AppendFormat("<div class=\"{0}\">", options.PanelDisplaySettings.TitleClass);
            builder.AppendFormat("<a href=\"#{0}\" data-toggle=\"collapse\" data-parent=\"#{1}\">", "SummaryErrorBody", "SummaryCollapsePanel");
            builder.AppendFormat("<h4>{0} <span id=\"Errorheader-icon\" class=\"pull-right glyphicon glyphicon-plus-sign\"></span> </h4>", options.Title);
            builder.AppendFormat("</a>");
            //close the header
            builder.Append("</div>");
            builder.Append("</div>");

            //open the panel body 
            builder.AppendFormat("<div class=\"{0}\" id=\"{1}\">", "panel-collapse collapse in", "SummaryErrorBody");


            builder.Append(AddIntroductionText(options.IntroductionBlock, options.PanelDisplaySettings));

            builder.Append(AddModelErrors(helper, options.ShowModelErrors, options.PanelDisplaySettings));



            //close the panel body
            builder.Append("</div>");


            //close the panel 
            builder.Append("</div>");


            //now build in the collapse script 
            builder.AppendFormat("<script>");

            builder.Append("$(document).ready(function () {" +
                                 " $(\"#SummaryCollapsePanel\").click(function () { " +
                                           "var control = $(\"#Errorheader-icon\");" +
                                           "if (control.hasClass(\"glyphicon-plus-sign\")) {" +
                                           "control.removeClass(\"glyphicon-plus-sign\");" +
                                           "control.removeClass(\"glyphicon\");" +
                                           "control.addClass(\"glyphicon\");" +
                                           "control.addClass(\"glyphicon-minus-sign\");" +
                                           " } else {" +
                                           "control.removeClass(\"glyphicon-minus-sign\");" +
                                           "control.removeClass(\"glyphicon\");" +
                                           "control.addClass(\"glyphicon\");" +
                                           "control.addClass(\"glyphicon-plus-sign\");" +
                                            "} " +
                                    " });" +
                                    "});"

                                    );


            //close the script tag 
            builder.AppendFormat("</script>");


            return builder;
        }



        private static StringBuilder PanelAlertMode(HtmlHelper helper, BootstrapValidationSummaryOptions options)
        {
            StringBuilder builder = new StringBuilder();

            //add the main panel 
            builder.AppendFormat("<div class=\"{0} {1}\">", options.PanelDisplaySettings.ContainerClass, options.PanelDisplaySettings.ContainerEmphasisClass);

            //add the header 
            builder.AppendFormat("<div class=\"{0}\">", options.PanelDisplaySettings.HeadingClass);

            builder.AppendFormat("<h4 class=\"{0}\">{1}</h4>", options.PanelDisplaySettings.TitleClass, options.Title);

            //close the header
            builder.Append("</div>");

            //open the panel body 
            builder.AppendFormat("<div class=\"{0}\">", options.PanelDisplaySettings.BodyClass);


            builder.Append(AddIntroductionText(options.IntroductionBlock, options.PanelDisplaySettings));

            builder.Append(AddModelErrors(helper, options.ShowModelErrors, options.PanelDisplaySettings));



            //close the panel body
            builder.Append("</div>");


            //close the panel 
            builder.Append("</div>");

            return builder;
        }

        private static StringBuilder ModalAlertMode(HtmlHelper helper, BootstrapValidationSummaryOptions options)
        {
            StringBuilder builder = new StringBuilder();





            //open up the modal window 
            builder.AppendFormat("<div class=\"{0} {1} \" id=\"SummaryErrors\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"SummaryErrorLabel\" aria-hidden=\"true\">",
                                    options.ModalDisplaySettings.ContainerClass,
                                    options.ModalDisplaySettings.ContainerEmphasisClass);

            //add the dialog
            builder.AppendFormat("<div class=\"{0}\">", options.ModalDisplaySettings.ModalDialogClass);
            //add the content
            builder.AppendFormat("<div class=\"{0}\">", options.ModalDisplaySettings.ModalDialogContentClass);

            //add the header 
            builder.AppendFormat("<div class=\"{0}\">", options.ModalDisplaySettings.HeadingClass);

            //add button to close the modal 
            builder.AppendFormat("<button type=\"button\" class=\"{0}\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>",
                options.ModalDisplaySettings.CloseButtonClass);

            builder.AppendFormat("<h4 class=\"{0}\" id=\"SummaryErrorLabel\">{1}</h4>", options.ModalDisplaySettings.TitleClass, options.Title);
            //close the header
            builder.Append("</div>");

            //open the body 
            builder.AppendFormat("<div class=\"{0}\">", options.ModalDisplaySettings.BodyClass);


            //add introduction text 
            builder.Append(AddIntroductionText(options.IntroductionBlock, options.ModalDisplaySettings).ToString());



            //add the model errors 
            builder.Append(AddModelErrors(helper, options.ShowModelErrors, options.ModalDisplaySettings));


            //close the body 
            builder.Append("</div>");


            //close the content 
            builder.Append("</div>");

            //close the dialog 
            builder.Append("</div>");



            //close the modal window
            builder.Append("</div>");
            //add javascript to fire up the modal when the document has finished loading. 
            builder.Append("<script>$(document).ready(function(){ $(\"#SummaryErrors\").modal(\"show\");}); </script>");
            return builder;
        }

        private static StringBuilder AlertMode(this HtmlHelper helper, bool closable, BootstrapValidationSummaryOptions options)
        {
            //this is the standard alert mode box. 
            StringBuilder builder = new StringBuilder();

            if (closable)
            {
                builder.AppendFormat("<div class=\"{0} {1} {2}\">", options.AlertDisplaySettings.ContainerClass,
                                                                    options.AlertDisplaySettings.ContainerEmphasisClass,
                                                                    options.AlertDisplaySettings.ContainerDismissibleClass);
                builder.AppendFormat("<button type=\"{0}\" class=\"{1}\" data-dismiss=\"{2}\" aria-hidden=\"{3}\">&times;</button>",
                    "button", options.AlertDisplaySettings.CloseButtonClass, "alert", "true");

            }
            else
            {
                builder.AppendFormat("<div class=\"{0} {1} \">",
                                                                options.AlertDisplaySettings.ContainerClass,
                                                                options.AlertDisplaySettings.ContainerEmphasisClass);

            }

            builder.AppendFormat("<h4>{0}</h4>", options.Title);


            builder.Append(AddIntroductionText(options.IntroductionBlock, options.AlertDisplaySettings).ToString());



            //add the model errors here. 

            builder.Append(AddModelErrors(helper, options.ShowModelErrors, options.AlertDisplaySettings).ToString());




            builder.Append("</div>");

            return builder;


        }

        private static StringBuilder AddIntroductionText(string introductionblock, BaseStyleSettings style)
        {

            StringBuilder builder = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(introductionblock))
            {

                builder.AppendFormat("<div class=\"{0} {1} \">", style.IntroductionBlockClass, style.IntroductionBlockEmphasisClass);
                builder.Append(introductionblock);
                builder.Append("</div>");
            }



            return builder;
        }

        private static StringBuilder AddModelErrors(this HtmlHelper helper, bool showModelErrors, BaseStyleSettings style)
        {
            StringBuilder builder = new StringBuilder();
            bool alternativestyle = false;

            if (showModelErrors && !helper.ViewData.ModelState.IsValid)
            {
                builder.AppendFormat("<ul class=\"{0}\">", style.DefaultModelErrorGroupClass);
                foreach (string key in helper.ViewData.ModelState.Keys)
                {

                    if (key != "")
                    {

                        foreach (ModelError error in helper.ViewData.ModelState[key].Errors)
                        {
                            builder.AppendFormat("<li class=\"{0} {1}\">{2}</li>", style.DefaultModelErrorBaseItemClass, alternativestyle ? style.DefaultModelErrorItemClass : style.DefaultModelErrorItemAltClass, !string.IsNullOrWhiteSpace(error.ErrorMessage) ? error.ErrorMessage : error.Exception.Message);
                            alternativestyle = !alternativestyle;
                        }
                    }

                }




                builder.Append("</ul>");


                foreach (string key in helper.ViewData.ModelState.Keys)
                {

                    if (key == "")
                    {
                        builder.AppendFormat("<div class=\"{0} {1}\">", style.AdditionalModelErrorGroupClass, style.AdditionalModelErrorGroupEmphasis);

                        builder.Append("<strong>The following general errors have occurred:</strong>");
                        builder.Append("<hr/>");

                        foreach (ModelError error in helper.ViewData.ModelState[key].Errors)
                        {
                            builder.AppendFormat("<p>{0}</p>", !string.IsNullOrWhiteSpace(error.ErrorMessage) ? error.ErrorMessage : error.Exception.Message);

                        }


                        builder.Append("</div>");
                    }

                }


            }
            else
            {
                //builder.AppendFormat("<ul class=\"{0}\">", style.DefaultModelErrorGroupClass);

                //builder.Append("</ul>");
            }




            return builder;

        }



    }
}
