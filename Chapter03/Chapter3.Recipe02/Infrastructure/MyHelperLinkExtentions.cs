﻿using Microsoft.AspNet.Mvc.Rendering;
using System;
/// <summary>
/// these are the extention methods described in Recipe 3-7.
/// </summary>
namespace Chapter3.Recipe02.Infrastructure
{
    /// <summary>
    /// Summary description for MyHelperLinkExtentions
    /// </summary>
    public static class MyHelperLinkExtentions
    {
        public static HtmlString SslActionLink(
            this IHtmlHelper helper,
            string linkText,
            string actionName)
        {
            if (helper == null )
                throw new ArgumentNullException("helper");

            if(string.IsNullOrEmpty(linkText))
                throw new ArgumentNullException("linkText");

            return helper.ActionLink(
                linkText,
                actionName,
                controllerName: null,
                protocol: "https",
                hostname: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null);
        }

        public static HtmlString SslActionLink(
            this IHtmlHelper helper,
            string linkText,
            string actionName,
            string controllerName)
        {
            if (helper == null)
                throw new ArgumentNullException("helper");

            if (string.IsNullOrEmpty(linkText))
                throw new ArgumentNullException("linkText");

            return helper.ActionLink(
                linkText,
                actionName,
                controllerName,
                protocol: "https",
                hostname: null,
                fragment: null,
                routeValues: null,
                htmlAttributes: null);
        }



    }
}