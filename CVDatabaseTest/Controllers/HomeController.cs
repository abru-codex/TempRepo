using CVDatabaseTest.Data;
using CVDatabaseTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CVDatabaseTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var user =await _dbContext.DemoUser.FindAsync(1);

            

            var newcv = new Cv
            {

                FullName = "Test Bin Rahmat Ullah",
                Email = "abd@gmail.com",
                Number = 01777,
                Skype = "test-skype",
                Linkdin = "test-linkdin",
                Address = "test Maijdee,Bangladesh",
                Summary = "test to say",
                Experiences = new List<Experience>()
                {
                    new Experience()
                    {
                        Position="Senior Software Enginee",
                        Companay="B Green Limited. – Sankar, Dhanmondi, Dhaka -1209",
                        JoiningDate=DateTime.Now,
                        ResignationDate=DateTime.Now,
                        Responsibilities = new List<string>
                        {
                            "Develop enterprise software solutions by studying information needs, conferring with users, studying system flow and work processes, investigating problem areas, following the software development life cycle",
                            "Determine operational feasibility by evaluating analysis, problem definition, requirements,solution development and proposed solutions.",
                            "Document and demonstrate solutions by developing documentation, flowcharts, layouts, diagrams etc"
                        }
                    },
                    new Experience()
                    {
                        Position="Senior Software Engineer (.Net)",
                        Companay="Hello Solutions Ltd. – BDBL Bhaban (6th Floor), Kawran Bazar, Dhaka 1215",
                        JoiningDate=DateTime.Now,
                        ResignationDate=DateTime.Now,
                        Responsibilities = new List<string>
                        {
                            "Gathering information, user requirement analysis for developing high quality Application",
                            "Review, Modify and debug Code and Integration",
                            "Collaborate with Internal team",
                            "Communications with the foreign Clients to identify, understand the daily task and other functional dependencies"
                        }
                    }
                },
                Projects = new List<Project>()
                {
                    new Project
                    {
                        Author="ABC Ltd.",
                        Name="ERP (ISP Billing, Cloud Billing, Accounting, Inventory etc.)",
                        Description="This ERP project basically concentrating on ISP business consists of customer management, customer care management, product management, financial management, logistics & inventory management, order management & ISP billing collection, Cisco Cloud billing, accounting, sales CRM etc.Language/Tools: .Net Core Web API, SQL Server 2016, Angular 6"
                    },
                    new Project
                    {
                        Author="Personal",
                        Name="Hotel Management System",
                        Description="Language/Tools: Asp.net, C#, SQL Server 2008, Crystal Report 9, JavaScript"
                    }
                },
                Trainings = new List<string>
                {
                    "Workshop on Software Design and Architecture at Nerd Castle, BASIS, Dhaka from Feb 03 to Mar 03,2017",
                    "Training on Object Oriented Programming on .Net at BASIS, Dhaka from Nov 2009 to Feb 2010",
                    "Industrial Training on J2EE at DPS pvt. Ltd, Kolkata, India from June 2007 to July 2007",
                    "Red Hat Certified Technician (RHCT) at Micropo pvt. ltd, Kolkata, India from June 2006 to July 2006"
                },
                Educations = new List<Education>
                {
                    new Education
                    {
                        Level="Master of Science in Computer Science",
                        University="Asian University, Dhaka, Bangladesh",
                        Grade="90%",
                        PassingYear=DateTime.Now,
                    },
                    new Education
                    {
                        Level="B.Sc. in Computer Science & Engineering",
                        University="American International University - Bangladesh",
                        Grade="87%",
                        PassingYear=DateTime.Now,
                    },
                    new Education
                    {
                        Level="Higher Secondary (H.S.C) in Science Group",
                        University="Rangpur Govt. College, Rangpur",
                        Grade="2nd Division",
                        PassingYear=DateTime.Now,
                    }
                },
                References = new List<Reference>
                {
                    new Reference
                    {
                        Name="Abdullah Maruf",
                        Designation="JR",
                        Compnay="ABCD Private Ltd",
                        Address="House 1, Road 02, Block C, Section D",
                        Email="maru@gmail.com",
                        Number=018888
                    },
                }
            };


            //var euser = _dbContext.DemoUser.Find(1);

            //euser.Cvs.Add(new Cv
            //{

            //    FullName = "Test 2 Bin Rahmat Ullah",
            //    Email = "abd@gmail.com",
            //    Number = 01777,
            //    Skype = "test-skype",
            //    Linkdin = "test-linkdin",
            //    Address = "test Maijdee,Bangladesh",
            //    Summary = "test to say",
            //    Skills = new List<string>()
            //            {
            //                ".Net Core, Web API, NodeJs","C#","AWS","Docker","UnitTest"
            //            },
            //    Experiences = new List<Experience>()
            //            {
            //                new Experience()
            //                {
            //                    Position="Senior Software Enginee",
            //                    Companay="B Green Limited. – Sankar, Dhanmondi, Dhaka -1209",
            //                    JoiningDate=DateTime.Now,
            //                    ResignationDate=DateTime.Now,
            //                    Responsibilities = new List<string>
            //                    {
            //                        "Develop enterprise software solutions by studying information needs, conferring with users, studying system flow and work processes, investigating problem areas, following the software development life cycle",
            //                        "Determine operational feasibility by evaluating analysis, problem definition, requirements,solution development and proposed solutions.",
            //                        "Document and demonstrate solutions by developing documentation, flowcharts, layouts, diagrams etc"
            //                    }
            //                },
            //                new Experience()
            //                {
            //                    Position="Senior Software Engineer (.Net)",
            //                    Companay="Hello Solutions Ltd. – BDBL Bhaban (6th Floor), Kawran Bazar, Dhaka 1215",
            //                    JoiningDate=DateTime.Now,
            //                    ResignationDate=DateTime.Now,
            //                    Responsibilities = new List<string>
            //                    {
            //                        "Gathering information, user requirement analysis for developing high quality Application",
            //                        "Review, Modify and debug Code and Integration",
            //                        "Collaborate with Internal team",
            //                        "Communications with the foreign Clients to identify, understand the daily task and other functional dependencies"
            //                    }
            //                }
            //            },
            //    Projects = new List<Project>()
            //            {
            //                new Project
            //                {
            //                    Author="ABC Ltd.",
            //                    Name="ERP (ISP Billing, Cloud Billing, Accounting, Inventory etc.)",
            //                    Description="This ERP project basically concentrating on ISP business consists of customer management, customer care management, product management, financial management, logistics & inventory management, order management & ISP billing collection, Cisco Cloud billing, accounting, sales CRM etc.Language/Tools: .Net Core Web API, SQL Server 2016, Angular 6"
            //                },
            //                new Project
            //                {
            //                    Author="Personal",
            //                    Name="Hotel Management System",
            //                    Description="Language/Tools: Asp.net, C#, SQL Server 2008, Crystal Report 9, JavaScript"
            //                }
            //            },
            //    Trainings = new List<string>
            //            {
            //                "Workshop on Software Design and Architecture at Nerd Castle, BASIS, Dhaka from Feb 03 to Mar 03,2017",
            //                "Training on Object Oriented Programming on .Net at BASIS, Dhaka from Nov 2009 to Feb 2010",
            //                "Industrial Training on J2EE at DPS pvt. Ltd, Kolkata, India from June 2007 to July 2007",
            //                "Red Hat Certified Technician (RHCT) at Micropo pvt. ltd, Kolkata, India from June 2006 to July 2006"
            //            },
            //    Educations = new List<Education>
            //            {
            //                new Education
            //                {
            //                    Level="Master of Science in Computer Science",
            //                    University="Asian University, Dhaka, Bangladesh",
            //                    Grade="90%",
            //                    PassingYear=DateTime.Now,
            //                },
            //                new Education
            //                {
            //                    Level="B.Sc. in Computer Science & Engineering",
            //                    University="American International University - Bangladesh",
            //                    Grade="87%",
            //                    PassingYear=DateTime.Now,
            //                },
            //                new Education
            //                {
            //                    Level="Higher Secondary (H.S.C) in Science Group",
            //                    University="Rangpur Govt. College, Rangpur",
            //                    Grade="2nd Division",
            //                    PassingYear=DateTime.Now,
            //                }
            //            },
            //    References = new List<Reference>
            //            {
            //                new Reference
            //                {
            //                    Name="Abdullah Maruf",
            //                    Designation="JR",
            //                    Compnay="ABCD Private Ltd",
            //                    Address="House 1, Road 02, Block C, Section D",
            //                    Email="maru@gmail.com",
            //                    Number=018888
            //                },
            //            }
            //});

            //await _dbContext.DemoUser.AddAsync(user);
            //await _dbContext.SaveChangesAsync();
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            //var data = await _dbContext.DemoUser.Include(x => x.Cvs)
            //    .ThenInclude(c => c.Projects)
            //    .Include(x => x.Cvs)
            //    .ThenInclude(c => c.Educations)
            //    .Include(x => x.Cvs)
            //    .ThenInclude(c => c.Experiences)
            //    .Include(x => x.Cvs)
            //    .ThenInclude(c => c.References)
            //    .ToListAsync();
                
            return View();
        }
         
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}