﻿using ParksService.Data.Abstract.Repositories;
using Microsoft.AspNetCore.Hosting;

namespace ParksService.Data.Abstract
{
    public interface IUnitOfWork
    {
        IHostingEnvironment Environment { get; }
        IAddressRepository AddressRepository { get; }
        IParkRepository ParkRepository { get; }
        IImageDataRepository ImageDataRepository { get; }
        IEntranceFeeRepository EntranceFeeRepository { get; }
        IOperatingHoursRepository OperatingHoursRepository { get; }
        IHoursExceptionsRepository HoursExceptionsRepository { get; }
        IWeeklyHoursRepository WeeklyHoursRepository { get; }
    }
}
