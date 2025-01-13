using Microsoft.AspNetCore.Mvc;
using MyCV.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;
using System.Numerics;
using System.Security.Principal;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Net;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using System.Buffers.Text;
using System.Data.Common;
using System.Buffers;
using System.Diagnostics.Metrics;
//using System.Text.Encodings.Web;

namespace MyCV.Controllers
{
    public class CVInfoController : Controller
    {
        public IEnumerable<MyCVInfo> myCVInfos = [new MyCVInfo
        {
            Name= "Nita Kalukhe" ,
            MobileNumber= "+07424992549" ,
            Email="nita.kalukhe@gmail.com",
            BasicSalary=35000,
            ProfessionalSummary = new List<string>
            {
            "Experienced .NET Developer with over 4+ years in software design, coding, and system analysis.",
            "Proven expertise in designing, developing, and maintaining scalable software solutions in various sectors.",
            "Proficient in unit testing, Test-Driven Development (TDD), and Agile methodologies.",
            "Self-motivated and driven by a passion for solving complex problems.",
            "Striving to learn new technologies to enhance job performance and contribute effectively to innovative projects."
            },
            CompanyName=new List<string>
            {
                "Bincom Global,Wolverhampton,UK",
                "Jendamark India Pvt.Ltd.Pune,India",
                "TriarQ Health LLP Hinjewadi, Pune,India",
                "Graiseley Primary School, Wolverhampton, UK.",
                "Hi-Tech Engineering Corporation India Pvt. Ltd, Pune,India",
                "Joshi’s Kohinoor Technical Institute, Baramati,India",
                "Sneash Software, Pune,India"

            },
            Experience1=new List<string>
            {
                "Designed and developed scalable backend services using C# and .NET technologies",
                "Writing and optimizing SQL queries for efficient data handling and reporting.",
                "Explore and use technology, including open-source tools and online communities.",
                "Documented processes and modules to streamline knowledge sharing and reduce onboarding time."

            },
            Experience2=new List<string>
            {
                "Spearheaded the development of integrated digital technologies aimed at enhancing production efficiencies in the global manufacturing sector.",
                "Led the design, testing, and deployment of multiple services and applications critical to production operations Integrated Git for source code control, ensuring seamless versioning and collaboration across teams.",
                "Collaborated closely with cross-functional engineering teams to drive innovation and develop new global products, leveraging cutting-edge technologies.",
                "played a key role in implementing Odin-related software solutions in collaboration with the procurement team, significantly improving operational efficiency.",
                "Engaged in prototyping and experimentation to drive innovation, identify issues, and continuously enhance product performance",
                "Utilized agile methodologies to improve project management efficiency and deliver 95% of milestones on time."

            },
            Experience3=new List<string>
            {
                "Successfully developed and deployed RxMed, significantly improving healthcare service efficiency and patien care quality.",
                "Improved user experience through front-end development with HTML5, CSS, JavaScript, and Bootstrap.",
                "Enhanced regulatory compliance and patient safety through the implementation of PDMP functionality.",
                "Automated manual processes, resulting in operational cost savings and increased staff productivity.",
                "Collaborated with cross-functional teams utilizing Git for version control and JIRA for bug tracking and project management."

            },
            Experience4=new List<string>
            {
                "Supervised and ensured the safety of children during lunch breaks, demonstrating strong organizational And interpersonal skills.",
	            "Managed student behavior effectively, promoting a positive and inclusive environment conducive to Learning and social development.",
                "Collaborated with colleagues to resolve conflicts and address student needs promptly and professionally."

            },
            Experience5=new List<string>
            {
                "Developed FireCAD, a sophisticated Windows-based design software tailored for engineers to efficiently design a diverse range of boilers.",
	            "Empowered engineers to select from a comprehensive database of gases or add custom gases, enhancing flexibility and customization options.",
                "Implemented advanced alert systems to notify users of any design parameter exceeding specified limits,ensuring design accuracy and safety compliance.",
                "Provided intuitive design tips and generated detailed design reports, facilitating informed decision-making and Streamlined project management.",
                "Engineered using cutting-edge.NET technologies, including C# and XML, to deliver a user-friendly interface and Robust functionality."
            },
             Experience6=new List<string>
             {
                 "Instructed students in various programming languages, including C, VB, VB.Net, C#.Net, and SQL, imparting foundational and advanced programming concepts.",
                 "Facilitated hands-on learning through practical projects, guiding students in applying theoretical knowledge to real-world scenarios.",
	             "Supported students in conceptualizing, designing, and implementing their own software projects, fostering Creativity and problem solving skills."
             },
             Experience7=new List<string>
             {
                 "Developed and maintained the Pinnacle desktop application to streamline sales inquiry processes, collaborating closely with users to troubleshoot issues and ensure optimal system performance.",
                 "Diagnosed and resolved SQL-related issues in the Inventory Management System, enhancing data accuracy and application efficiency.",
                 "Provided training and support for the Cost Binder and Estimation Modules of the ECON software, helping users understand advanced features and best practices.",
                 "Created detailed documentation, including user manuals and technical support guides, to enhance knowledge sharing and efficiency within the team."
             },
             Academic=new List<string>{
             "Master of Computer Management (MCM), Pune University,  India ,",
            "Bachelor of Computer Science (Mathematics), Pune University,  India ,",
             },
             Interest="I enjoy reading books, listening to music, to do art (Madhubani art, Warli art, pencil sketch).",
             Year=new List<string>
             {
                 "Oct 2024 – Present","Oct 2023 – April 2024","Jan 2023 – June 2023","May-2021 to Jan-2022","Jan-2011 to Dec-2012","June-2009 to Jan-2011","Oct-2007 to March-2009","June 2005-June 2007","June 2002-June 2005"
             }

        }];

        public IActionResult GetInfo()
        {
            return View(myCVInfos);
        }
        public IActionResult GetTax()
        {
            return View(myCVInfos);
        }
       
    }
}
