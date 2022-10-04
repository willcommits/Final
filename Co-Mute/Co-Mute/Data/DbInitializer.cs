using Co_Mute.Models;

using System.Diagnostics;

namespace Co_Mute.Data
{
    public class DbInitializer
    {
        public static void Initialize(Trip context)
        {
            // Look for any students.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }

            var Users = new User[]
            {
                new User{FirstName="Carson",LastName="Alexander",phone="0763617892",Email="pmambambo2@gmail.com",Password="Helloworld"},
                new User{FirstName="Meredith",LastName="Alonso",phone="0763617892",Email="pmambambo3@gmail.com",Password="killerwhale"},
                new User{FirstName="Arturo",LastName="Anand",phone="0763617892",Email="pmambambo4@gmail.com",Password="hecticsponge"},
                new User{FirstName="Gytis",LastName="Barzdukas",phone="0763617892",Email="pmambambo5@gmail.com",Password="unrivaledwhale"},
                new User{FirstName="Yan",LastName="Li",phone="0763617892",Email="pmambambo6@gmail.com",Password="animelover"},
                new User{FirstName="Peggy",LastName="Justice",phone="0763617892",Email="pmambambo7@gmail.com",Password="goku"},
                new User{FirstName="Laura",LastName="Norman",phone="0763617892",Email="pmambambo8@gmail.com",Password="naruto"},
                new User{FirstName="Nino",LastName="Olivetto",phone="0763617892",Email="pmambambo9@gmail.com",Password="glad"}
            };

            context.User.AddRange(Users);
            context.SaveChanges();

          

            var Carpools = new Carpool[]
            {
                  new Carpool{UserID=1,PoolID=1050,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new Carpool{UserID=1,PoolID=4022,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=1,PoolID=4041,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=2,PoolID=1045,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=2,PoolID=3141,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=2,PoolID=2021,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new Carpool{UserID=3,PoolID=1050,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=4,PoolID=1050,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=4,PoolID=4022,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=5,PoolID=4041,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=6,PoolID=1045,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"},
                new  Carpool{UserID=7,PoolID=3141,ExpectedArrivalTime="23:00pm",Origin="Cape Town",Destination="Joburg",DaysAvailable=3,AvailableSeats=1,Owner="Bongie",Notes="Do not smoke"}
                

            };

            context.Carpools.AddRangeAsync(Carpools);
            context.SaveChanges();


            var AvailablePools = new AvailablePool[]

          {
              new AvailablePool{AvailablePoolId=1,FirstName="Chemistry",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=4022,FirstName="Microeconomics",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=4041,FirstName="Macroeconomics",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=1045,FirstName="Calculus",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=3141,FirstName="Trigonometry",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=2021,FirstName="Composition",LastName="Mkaza"},
                new AvailablePool{AvailablePoolId=2042,FirstName="Literature",LastName="Mkaza" }
     
          };

            context.AvailablePools.AddRange(AvailablePools);
            context.SaveChanges();
        }

        
            
        
    }
}
