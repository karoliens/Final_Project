using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data.InitialData
{
    public static class ClientInitialData
    {
        public static readonly Client[] DataSeed = new Client[]
        {
            new Client
            {
                ClientId = 1,
                Name = "Karolis",
                Email = "karoliens@gmail.com",
                PhoneNumber = "+37061212121",
            },

                new Client
            {
                ClientId = 2,
                Name = "Ieva",
                Email = "ievuzis@gmail.com",
                PhoneNumber = "+37061252121",
            },

                new Client
            {
                ClientId = 3,
                Name = "Tomas",
                Email = "tomukas@gmail.com",
                PhoneNumber = "+37061212128",
            },

                new Client
            {
                ClientId = 4,
                Name = "Saulius",
                Email = "sauliens@gmail.com",
                PhoneNumber = "+37061215121",
            },
        };
    }
}