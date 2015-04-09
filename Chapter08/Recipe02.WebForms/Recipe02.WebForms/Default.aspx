<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Recipe02.WebForms._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>This is a Web Forms Project created VS 2012.</h2>
            </hgroup>
            <p>
                This is a Web Forms project created in Visual Studio 2012. We will be integrating this solution with an ASP.NET 5 MVC 6 Application.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>This solution contains the web forms examples for chapter 8:</h3>
    <ol class="round">
        <li>
            <h5>Recipe 8-3</h5>
            <a href="Members/MyWorkspaces.aspx">Converting a web forms page to MVC</a>
        </li>
        <li>
            <h5>Recipe 8-4</h5>
            <a href="DataControlExamples/DataListExample.aspx">Creating a Multiple Column Data List using a custom HTML helper extension</a>            
        </li>
        <li>
            <h5>Recipe 8-5</h5>
            <a href="DataControlExamples/GridViewExample.aspx">Creating a Data Grid with Paging, Sorting, and Filtering Support</a>
            
        </li>
        <li>
            <h5>Recipe 8-6</h5>
            <a href="DataControlExamples/GridViewExample.aspx">Creating a Data Grid that allows in-line editing</a>
            
        </li>
        <li>
            <h5>Recipe 8-7</h5>
            <a href="DataControlExamples/MasterDetailsView.aspx">Creating a Master / Details View in ASP.NET MVC</a>
            
        </li>
        <li>
            <h5>Recipe 8-8</h5>
            <a href="Forms/CustomValidation.aspx">Custom Validators in ASP.NET MVC</a>
            
        </li>
        <li>
            <h5>Recipe 8-9</h5>
            Moving from Master Pages in ASP.NET Web Forms to Layout pages in Razor (See site.master)
            
        </li>
        <li>
            <h5>Recipe 8-10</h5>
            <a href="DataControlExamples/GridViewExample.aspx">Creating a Multi-page Wizard using ASP.NET MVC</a>
            
        </li>
        <li>
            <h5>Recipe 8-11</h5>
            <a href="Forms/RichTextEditor.aspx">Using a client side rich text editor</a>
            
        </li>
        <li>
            <h5>Recipe 8-12</h5>
            <a href="Forms/AutoComplete.aspx">Creating a Text box with Auto-complete</a>
            
        </li>
        <li>
            <h5>Recipe 8-13</h5>
            <a href="Forms/EnteringDates.aspx">Using a Calendar for Entering Dates</a>
            
        </li>
        <li>
            <h5>Recipe 8-14</h5>
            <a href="Forms/DragAndDropReorder.aspx">Reordering items in a list using drag and drop</a>
            
        </li>
        <li>
            <h5>Recipe 8-15</h5>
            <a href="DataControlExamples/TabControlExample.aspx">Using a Tabbed Layout</a>
            
        </li>
        <li>
            <h5>Recipe 8-16</h5>
            <a href="Account/Login.aspx">Detecting if CAPS LOCK is enabled on a password field</a>
            
        </li>
        <li>
            <h5>Recipe 8-17</h5>
            <a href="Forms/CascadingDropDownList.aspx">Creating cascading Drop Down Lists</a>
            
        </li>
    </ol>
</asp:Content>
