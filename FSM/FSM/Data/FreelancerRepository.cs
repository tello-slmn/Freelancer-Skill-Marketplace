using FSM.Models;

namespace FSM.Data
{
    public class FreelancerRepository : IFreelancerRepository
    {
        public IEnumerable<Freelancer> AllFreelancers =>
        [
            new Freelancer { FreelancerID = 1, FreelancerFName = "Alice", FreelancerLName = "Johnson", FreelancerEmail = "alice.johnson@example.com", FreelancerBio = "Front-end developer specializing in React and UI design.", },
            new Freelancer { FreelancerID = 2, FreelancerFName = "Brian", FreelancerLName = "Smith", FreelancerEmail = "brian.smith@example.com", FreelancerBio = "Full-stack engineer with experience in ASP.NET Core and SQL Server." },
            new Freelancer { FreelancerID = 3, FreelancerFName = "Carla", FreelancerLName = "Nguyen", FreelancerEmail = "carla.nguyen@example.com", FreelancerBio = "Data analyst passionate about turning raw data into insights." },
            new Freelancer { FreelancerID = 4, FreelancerFName = "David", FreelancerLName = "Brown", FreelancerEmail = "david.brown@example.com", FreelancerBio = "Mobile app developer focusing on Android and Kotlin." },
            new Freelancer { FreelancerID = 5, FreelancerFName = "Ella", FreelancerLName = "Martinez", FreelancerEmail = "ella.martinez@example.com", FreelancerBio = "UX researcher with a background in psychology and design." },
            new Freelancer { FreelancerID = 6, FreelancerFName = "Felix", FreelancerLName = "Garcia", FreelancerEmail = "felix.garcia@example.com", FreelancerBio = "Cloud solutions architect experienced in Azure and AWS." },
            new Freelancer { FreelancerID = 7, FreelancerFName = "Grace", FreelancerLName = "Lee", FreelancerEmail = "grace.lee@example.com", FreelancerBio = "Content writer specializing in technical documentation." },
            new Freelancer { FreelancerID = 8, FreelancerFName = "Henry", FreelancerLName = "Wilson", FreelancerEmail = "henry.wilson@example.com", FreelancerBio = "Cybersecurity consultant with penetration testing expertise." },
            new Freelancer { FreelancerID = 9, FreelancerFName = "Isabella", FreelancerLName = "Taylor", FreelancerEmail = "isabella.taylor@example.com", FreelancerBio = "Graphic designer skilled in Adobe Creative Suite." },
            new Freelancer { FreelancerID = 10, FreelancerFName = "Jack", FreelancerLName = "Harris", FreelancerEmail = "jack.harris@example.com", FreelancerBio = "Backend developer with strong knowledge of C# and APIs." },
            new Freelancer { FreelancerID = 11, FreelancerFName = "Kylie", FreelancerLName = "Roberts", FreelancerEmail = "kylie.roberts@example.com", FreelancerBio = "SEO specialist helping businesses grow their online presence." },
            new Freelancer { FreelancerID = 12, FreelancerFName = "Liam", FreelancerLName = "Clark", FreelancerEmail = "liam.clark@example.com", FreelancerBio = "Game developer with Unity and C# experience." },
            new Freelancer { FreelancerID = 13, FreelancerFName = "Maya", FreelancerLName = "Lopez", FreelancerEmail = "maya.lopez@example.com", FreelancerBio = "Project manager with Agile and Scrum certifications." },
            new Freelancer { FreelancerID = 14, FreelancerFName = "Noah", FreelancerLName = "Hall", FreelancerEmail = "noah.hall@example.com", FreelancerBio = "AI researcher working on natural language processing." },
            new Freelancer { FreelancerID = 15, FreelancerFName = "Olivia", FreelancerLName = "Allen", FreelancerEmail = "olivia.allen@example.com", FreelancerBio = "Marketing strategist with expertise in digital campaigns." },
            new Freelancer { FreelancerID = 16, FreelancerFName = "Paul", FreelancerLName = "Young", FreelancerEmail = "paul.young@example.com", FreelancerBio = "DevOps engineer automating CI/CD pipelines." },
            new Freelancer { FreelancerID = 17, FreelancerFName = "Quinn", FreelancerLName = "Scott", FreelancerEmail = "quinn.scott@example.com", FreelancerBio = "Copywriter crafting compelling brand stories." },
            new Freelancer { FreelancerID = 18, FreelancerFName = "Rosa", FreelancerLName = "King", FreelancerEmail = "rosa.king@example.com", FreelancerBio = "Data scientist with Python and machine learning skills." },
            new Freelancer { FreelancerID = 19, FreelancerFName = "Sam", FreelancerLName = "Wright", FreelancerEmail = "sam.wright@example.com", FreelancerBio = "IT support specialist with strong troubleshooting skills." },
            new Freelancer { FreelancerID = 20, FreelancerFName = "Tina", FreelancerLName = "Evans", FreelancerEmail = "tina.evans@example.com", FreelancerBio = "Social media manager growing communities online." },
            new Freelancer { FreelancerID = 21, FreelancerFName = "Uma", FreelancerLName = "Hill", FreelancerEmail = "uma.hill@example.com", FreelancerBio = "QA tester ensuring software quality and reliability." },
            new Freelancer { FreelancerID = 22, FreelancerFName = "Victor", FreelancerLName = "Green", FreelancerEmail = "victor.green@example.com", FreelancerBio = "Blockchain developer building decentralized applications." },
            new Freelancer { FreelancerID = 23, FreelancerFName = "Wendy", FreelancerLName = "Adams", FreelancerEmail = "wendy.adams@example.com", FreelancerBio = "Illustrator creating digital art and storyboards." },
            new Freelancer { FreelancerID = 24, FreelancerFName = "Xavier", FreelancerLName = "Nelson", FreelancerEmail = "xavier.nelson@example.com", FreelancerBio = "Systems analyst optimizing enterprise workflows." },
            new Freelancer { FreelancerID = 25, FreelancerFName = "Yara", FreelancerLName = "Bennett", FreelancerEmail = "yara.bennett@example.com", FreelancerBio = "Web developer specializing in responsive design." }
        ];

        public Freelancer GetFreelancerById(int freelancerId) => AllFreelancers.FirstOrDefault(f => f.FreelancerID == freelancerId);
    }
}
