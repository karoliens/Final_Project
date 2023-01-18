using Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Data.InitialData
{
    public static class TicketInitialData
    {
        public static readonly Ticket[] DataSeed = new Ticket[]
        {
            new Ticket
            {
                TicketId = 1,
                ClientName = "Karolis",
                ClientEmail = "karoliens@gmail.com",
                ClientPhoneNumber = "+37061212121",
                CreateDateTime = DateTime.Now,
                TypeOfDevice = ETypeOfDevice.iPhone,
                TypeOfService = ETypeOfService.Repair,
                Description = "Reikia pakeisti iPhone 7 ekraną"
            },

                new Ticket
            {
                TicketId = 2,
                ClientName = "Ieva",
                ClientEmail = "ievuzis@gmail.com",
                ClientPhoneNumber = "+37061252121",
                CreateDateTime = DateTime.Now,
                TypeOfDevice = ETypeOfDevice.iPhone,
                TypeOfService = ETypeOfService.Repair,
                Description = "Reikia pakeisti iPhone X bateriją"
            },

                new Ticket
            {
                TicketId = 3,
                ClientName = "Tomas",
                ClientEmail = "tomukas@gmail.com",
                ClientPhoneNumber = "+37061212128",
                CreateDateTime = DateTime.Now,
                TypeOfDevice = ETypeOfDevice.Android,
                TypeOfService = ETypeOfService.Repair,
                Description = "Reikia pakeisti SAMSUNG S20 ekraną"
            },

                new Ticket
            {
                TicketId = 4,
                ClientName = "Saulius",
                ClientEmail = "sauliens@gmail.com",
                ClientPhoneNumber = "+37061215121",
                CreateDateTime = DateTime.Now,
                TypeOfDevice = ETypeOfDevice.Other,
                TypeOfService = ETypeOfService.Repair,
                Description = "Reikia perlituoti PS5 pultelio krovimo lizdą"
            },
        };
    }
}