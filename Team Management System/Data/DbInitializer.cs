using Team_Management_System.Models;
using System;
using System.Linq;

namespace Team_Management_System.Data
{

    public static class DbInitializer
    {
        public static void Initialize(TMNDb context)
        {
            context.Database.EnsureCreated();

            // Look for any Member.
            if (context.Members.Any())
            {
                return;   // DB has been seeded
            }

            var members = new Member[]
            {
            new Member{member_FirstName="Carson",member_lastName="Alexander",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Meredith",member_lastName="Alonso",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Arturo",member_lastName="Anand",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Gytis",member_lastName="Barzdukas",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Yan",member_lastName="Li",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Peggy",member_lastName="Justice",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Laura",member_lastName="Norman",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"},
            new Member{member_FirstName="Nino",member_lastName="Olivetto",member_contacNo="0789654428",member_email="carson.alex@gmail,com",captain_status="No",member_username="zombie",member_password="1897hyt"}
            };
            foreach (Member s in members)
            {
                context.Members.Add(s);
            }
            context.SaveChanges();

            var administrators = new Administrator[]
            {
            new Administrator{Adminstrator_ID=1050,Adminstrator_lastname="Chemistry",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=4022,Adminstrator_lastname="Microeconomics",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=4041,Adminstrator_lastname="Macroeconomics",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=1045,Adminstrator_lastname="Calculus",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=3141,Adminstrator_lastname="Trigonometry",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=2021,Adminstrator_lastname="Composition",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"},
            new Administrator{Adminstrator_ID=2042,Adminstrator_lastname="Literature",Adminstrator_firstname="Credits",Adminstrator_username="java",Adminstrator_password="1237077"}
            };
            foreach (Administrator c in administrators)
            {
                context.Administrators.Add(c);
            }
            context.SaveChanges();

            var match_Sessions = new Match_Session[]
            {
            new Match_Session{team_ID=1,matchSession_ID=1050,matchSession_score=1500},
            new Match_Session{team_ID=1,matchSession_ID=4022,matchSession_score=354324},
            new Match_Session{team_ID=1,matchSession_ID=4041,matchSession_score=3435234},
            new Match_Session{team_ID=2,matchSession_ID=1045,matchSession_score=6576767},
            
            };
            foreach (Match_Session e in match_Sessions)
            {
                context.Match_Sessions.Add(e);
            }
            context.SaveChanges();
        }
    }
}