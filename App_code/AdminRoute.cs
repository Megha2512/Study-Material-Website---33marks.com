using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Routing;

/// <summary>
/// Summary description for AdminRoute
/// </summary>
public class AdminRoute
{

    public AdminRoute()
    {
      


    }

    public static void RegisterRoutes(RouteCollection routes)
    { 
				//<------------------------------user ------------------------------------------------->
        routes.MapPageRoute("blank", "", "~/user/index.aspx");
        routes.MapPageRoute("index", "index", "~/user/index.aspx");
		 routes.MapPageRoute("About_Details", "about", "~/user/about.aspx");
        routes.MapPageRoute("Contact_Details", "contact", "~/user/contact.aspx");
        routes.MapPageRoute("TeamRout", "team", "~/user/team.aspx");
		        routes.MapPageRoute("question", "question", "~/user/question.aspx");

		 routes.MapPageRoute("ParaRoutcontent-list", "content-list/{value}", "~/user/content-list.aspx");
		        routes.MapPageRoute("Routcontent-list", "content-list", "~/user/content-list.aspx");
		routes.MapPageRoute("ContentView_Details", "content/{id}", "~/user/content-view.aspx");
		
		//<------------------------------Admin ------------------------------------------------->
		
		 //admin-login
        routes.MapPageRoute("AdminLogin", "login", "~/admin/adminlogin.aspx");
		        routes.MapPageRoute("AdminLogout", "logout", "~/admin/logout.aspx");

        routes.MapPageRoute("createRoute", "create", "~/admin/create.aspx");

        //Admin-dashboard
        routes.MapPageRoute("AdminDashboard", "dashboard", "~/admin/dashboard.aspx");


        //admin-profile
        routes.MapPageRoute("EditAdminProfile_Details", "adproedit", "~/adminadmin-profile-edit.aspx");
        routes.MapPageRoute("ViewAdminProfile_Details", "profile", "~/admin/admin-profile-view.aspx");

        //Branch
       // routes.MapPageRoute("ViewBranch_Details", "adbrview/{branch_id}", "~/admin/branch-view.aspx");
        routes.MapPageRoute("ViewBranch_Details", "adbrview", "~/admin/branch-view.aspx");
        routes.MapPageRoute("EditBranch_Details", "adbredit", "~/admin/branch-edit.aspx");
        routes.MapPageRoute("EditBranch_DetailsParameter", "adbredit/{branch_id}", "~/admin/branch-edit.aspx");
        
        //Content
        routes.MapPageRoute("InsertContent_Deatils", "adconinsert", "~/admin/content-edit.aspx");
        routes.MapPageRoute("ParaInsertContent_Deatils", "adconinsert/{id}", "~/admin/content-edit.aspx");
        // routes.MapPageRoute("InsertContent_Deatils", RouteUrl, "~/admin/content-insert.aspx");
        routes.MapPageRoute("ViewContent_Deatils", "adconview", "~/admin/content-view.aspx");

        //course
        routes.MapPageRoute("EditCourse", "adcourseedit","~/admin/course-edit.aspx");
        routes.MapPageRoute("EditCourseParameter", "adcourseedit/{course_id}", "~/admin/course-edit.aspx");
        routes.MapPageRoute("ViewCourse", "adcourseview", "~/admin/course-view.aspx");

        //mcq
        routes.MapPageRoute("EditMCQ_Details", "admcqedit", "~/admin/mcq-edit.aspx");
        routes.MapPageRoute("ViewMCQ_Details", "admcqview", "~/admin/mcq-view.aspx");

        //subject
        routes.MapPageRoute("EditSubject_Details", "adsubedit", "~/admin/subject-edit.aspx");
        routes.MapPageRoute("EditValueSubject_Details", "adsubedit/{sub_id}", "~/admin/subject-edit.aspx");
        routes.MapPageRoute("ViewSubject_Details", "adsubview", "~/admin/subject-view.aspx");

		 //Year
        routes.MapPageRoute("EditYear", "adyearedit", "~/admin/year-edit.aspx");
        routes.MapPageRoute("EditYearParameter", "adyearedit/{year_id}", "~/admin/year-edit.aspx");
        routes.MapPageRoute("ViewYear", "adyearview", "~/admin/year-view.aspx");
		
        //query-list
        routes.MapPageRoute("MessageQueryList", "adqr", "~/admin/query-list.aspx");
        routes.MapPageRoute("ViewQueryList", "adqrview", "~/admin/query-list-view.aspx");

        //query-list
        routes.MapPageRoute("edit", "adsemedit", "~/admin/semester-edit.aspx");
        routes.MapPageRoute("view", "adsemview", "~/admin/semester-view.aspx");

        //question-paper
        routes.MapPageRoute("EditQuestionPaper", "adqtedit", "~/admin/question-paper-edit.aspx");
        routes.MapPageRoute("EditQuestionPaperParameter", "adqtedit/{que_id}", "~/admin/question-paper-edit.aspx");
        routes.MapPageRoute("ViewQuestionPaper", "adqtview", "~/admin/question-paper-view.aspx");


        // content file uplode
        routes.MapPageRoute("ContentFileUpload", "file/{id}", "~/admin/FileUpload.aspx");

        //contact  us view
        routes.MapPageRoute("contact-view", "adcontact", "~/admin/contact-view.aspx");
		
		//change password
        routes.MapPageRoute("Password", "password", "~/admin/change-password.aspx");

		 //error
        routes.MapPageRoute("404", "404", "~/admin/pages/error/404.aspx");
        routes.MapPageRoute("ViewError_Page", "{*.aspx}", "~/admin/pages/error/404.aspx");
		


        routes.RouteExistingFiles = true;
    }
}
   